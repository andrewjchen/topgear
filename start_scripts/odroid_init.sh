#!/bin/bash
#
# This script needs to be run by /etc/rc.local on the ODROID.
#

su -l odroid -c 'screen -S nbserver -d -m ipython notebook --profile=nbserver'

screen -S netstarter -d -m python /home/odroid/topgear/python/netstarter.py