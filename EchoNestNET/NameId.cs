using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoNestNET
{
    public class NameId
    {
        public string NameOrArtistId(string nameOrId)
        {
            if (nameOrId.StartsWith("AR") && nameOrId.Length == 18)
            {
                return "&id=" + nameOrId;
            }

            else
            {
                return "&name=" + nameOrId;
            }
        }

        public string ArtistOrArtistId(string nameOrId)
        {
            if (nameOrId.StartsWith("AR") && nameOrId.Length == 18)
            {
                return "&artist_id=" + nameOrId;
            }

            else
            {
                return "&artist=" + nameOrId;
            }
        }

        public string SongOrTrackId(string id)
        {
            if (id.StartsWith("SO")) { return "&id=" + id; }
            if (id.StartsWith("TR")) { return "&track_id=" + id; }
            else { throw new ArgumentException("Method requires an ID"); }
        }
    }
}
