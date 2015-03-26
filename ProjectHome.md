# loci #

![http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=600&h=&cache=cache&media=monto.jpg](http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=600&h=&cache=cache&media=monto.jpg)

**loci** is Latin for places.  Knowing about places is what loci is about.  The eventual goal is to make the user aware of any the information available for a location, as well as contribute their own knowledge about locations.

[The source is available!](http://www.ece.utk.edu/~jgournea/loci.zip)

# Overview : How it works #


## live ##

![http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=live.png](http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=live.png)

This shows how loci works in the real world.  loci was designed to be as non platform dependent as possible.  However, for the scope of my project I only concentrated on getting my particular setup to work.

Let me walk through what has to happen for loci to give a user information about their current location.
> - The GPS receiver has to have a location fix
> - loci on Windows Mobile reads the NMEA sequence from the GPS receiver from [http://en.wikipedia.org/wiki/Bluetooth|bluetooth] emulated serial port
> - loci on Windows Mobile gets the longitude and latitude and converts them into [[84](http://en.wikipedia.org/wiki/World_Geodetic_System|WGS)]
> - loci on Windows Mobile uses integrated web browser passing the coordinates as arguments to connect to the loci.web application
> - the loci.web php client checks the mysql database for all points near the location submitted.

## in development ##

![http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=dev.png](http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=dev.png)


# The components #

## logi gateway for windows mobile ##
loci
![http://josh.gourneau.com/wiki/lib/exe/detail.php?id=411report&cache=cache&media=pda-gps-disp.jpg](http://josh.gourneau.com/wiki/lib/exe/detail.php?id=411report&cache=cache&media=pda-gps-disp.jpg)

The job of this application is to read the GPS location, and then go to the loci website for those coords.  This was written in C# within Visual Studio 2005.  It can run on Windows Mobile 2003 and up.

## loci website ##
![http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=pda-gps-web.jpg](http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=pda-gps-web.jpg)

All the data is stored on the website.  This part of the project was written using PHP with a MySQL database.

## parts ##

### search.php ###
Searches the database for nearby coords.  Also allows you to make new entries. It also allows you to edit, and delete old ones.

### edit.php ###
This does the MySQL processing for editing a database entry.

### add.php ###
This does the MySQL processing for adding a database entry.

### delete.php ###
This does the MySQL processing for deleting a database entry.

## MySQL ##

![http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=mysql-qb.jpg](http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=mysql-qb.jpg)

loci.sql

<code sql>
CREATE TABLE `map` (
> `id` int(10) unsigned NOT NULL auto\_increment,
> `time` timestamp NOT NULL default CURRENT\_TIMESTAMP on update CURRENT\_TIMESTAMP,
> `lat` double NOT NULL,
> `lng` double NOT NULL,
> `msg` varchar(10000) NOT NULL,
> `cat` varchar(1000) NOT NULL,
> `title` varchar(255) NOT NULL,
> PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO\_INCREMENT=1 ;


Unknown end tag for &lt;/code&gt;



# GPS Emulator #

![http://josh.gourneau.com/wiki/lib/exe/detail.php?id=411report&cache=cache&media=gpsemu.jpg](http://josh.gourneau.com/wiki/lib/exe/detail.php?id=411report&cache=cache&media=gpsemu.jpg)

gpsemu.py
![http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=loci-web.jpg](http://josh.gourneau.com/wiki/lib/exe/fetch.php?w=&h=&cache=cache&media=loci-web.jpg)

Because it is difficult to develop for something that is wholly dependent on GPS without having some way to control the GPS receiver I wrote a GPS Emulator in Python.  This is a overview of how it works.

> - Coordinates are selected using google maps and written to a text file on the web server.
> - the gps emulator reads that text file off the web
> - Generates nmea sequences form the coordinates in that text file outputs to serial


Because it is not possible to read the serial port that data is being written it becomes necessary to use a null-modem cable.  [http://com0com.sourceforge.net/|c0mc0m] is a open source null modem cable that was very useful.