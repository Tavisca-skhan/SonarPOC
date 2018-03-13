using System;
using System.Collections.Generic;
using System.Text;

namespace SonarCubePoc
{
    public class CSharp

    {

        string Version;

        string Technology;

       
        
        public string GetDetails()
        {
              return Version + Technology;
        }

        public void SetDetails(string version, string technology)

        {

            Version = version;
            Technology = technology;

        }

    }
}
