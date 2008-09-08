#!/usr/bin/env python

from decimal import *
import binascii
import serial, time
import urllib

def intTrunc(num) :
    return int(num + .00001)

def DecDegToDegMin(coord,c) :
    # Convert decimal degrees to degrees.minutes
    # from http://www.shallowsky.com/software/topo/pytopo-0.5
    dir = ""

    if coord < 0:
        if c == "lat" :
            dir = "S"
        if c == "lon" :
            dir = "W"
    
    if coord > 0:
        if c == "lat" :
            dir = "N"
        if c == "lon" :
            dir = "E"
    
    coord = abs(coord)
    
    deg = intTrunc(coord)
    min = (coord - deg) * .6
    
    if c == "lon":
        deg = "%03d" % deg
    nmin = min*100
    nmin = "%06.3f" % nmin

    return "%s%s,%s," % (deg,nmin,dir)
    
def check_sum_gen(input_string):
    csum = 0
    i = 0
    
    while (i < len(input_string)):
    	inpt = binascii.b2a_hex(input_string[i])
    	inpt = int(inpt,16)
    	csum = csum ^ inpt #xor
    	i += 1
    
    return "%X" % csum

def BuildGGA(lat,lon) :
    
    DecDegToDegMin(lat,"lat")
    DecDegToDegMin(lon,"lon")
    
    #build the gpgga string with mostly bad data
    #I only care about the long, lat, and the checksum
    ga = "GPGGA,183730,"
    ga = ga + DecDegToDegMin(lat,"lat")
    ga = ga + DecDegToDegMin(lon,"lon")
    ga = ga + "1,05,1.6,646.4,M,-24.1,M,,"
    cs = check_sum_gen(ga)
    
    return "$%s*%s" % (ga,cs)

def BuildRMC(lat,lon) :

    DecDegToDegMin(lat,"lat")
    DecDegToDegMin(lon,"lon")
    
    #build the gpgga string with mostly bad data
    #I only care about the long, lat, and the checksum
    ga = "GPRMC,183729,A,"
    ga = ga + DecDegToDegMin(lat,"lat")
    ga = ga + DecDegToDegMin(lon,"lon")
    ga = ga + "000.0,360.0,080301,015.5,E"
    cs = check_sum_gen(ga)
    
    return "$%s*%s" % (ga,cs)

if __name__=='__main__':
   
    ser = serial.Serial(1, 4800)  #open first serial port
    print ser.portstr       #check which port was realy used
    
    while 1:
        time.sleep(1)
        #read the gps coords from the web
        #this is just a simple text file in the format
        #lat,lon
        sock = urllib.urlopen("http://loci.engr.utk.edu/gps.txt")
        gpstext = sock.read()
        gpstext = gpstext.split(',')
        lat = float(gpstext[0])
        lon = float(gpstext[1])
        
        print "Lat: %s Lon: %s" % (lat,lon)
        
        ga = BuildGGA(lat,lon) + "\r\n"
        mc = BuildRMC(lat,lon) + "\r\n"
        ser.write(ga)      #write a string
        print ga,
        ser.write(mc)      #write a string
        print mc,

    ser.close()             #close port
    sock.close()            #close http socket