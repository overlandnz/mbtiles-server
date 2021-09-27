# mbtiles-server
Basic .NET Core MBTiles server for testing - probably don't use it in production, it's not really designed for it.

# To get it running

- Clone repo
- Update the `appsettings.json` with your Mapbox API key and path to your MBTiles database file
- Run the project

# Random stuff

If you have your MBTiles broken up into different databases for zoom level (ie for testing) you can include a `{zoom}` section in your path and it'll load that.

For example `/Users/Daniel/Desktop/Tiles/tiles-{zoom}.mbtiles`
