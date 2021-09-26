using System.ComponentModel.DataAnnotations.Schema;

namespace MBTilesServer.Models
{
    /// <summary>
    /// Following https://github.com/mapbox/mbtiles-spec/blob/master/1.3/spec.md
    /// </summary>
    public class TileModel  
    {
        public int zoom_level { get; set; }
        public int tile_column { get; set; }
        public int tile_row { get; set; }
        public byte[] tile_data { get; set; }
    }
}