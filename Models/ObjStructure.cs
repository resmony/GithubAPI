using System.Collections.Generic;

namespace GithubAPI.Models {
    public class Collabs {
        public string login { get; set; }
        public int id { get; set; }
    }

    public class ObjStructure {
        public Item generalInfo { get; set; }
        public List<Collabs> collaborators { get; set; }

        public ObjStructure() {
            collaborators = new List<Collabs>();
        }
        
    }
}
