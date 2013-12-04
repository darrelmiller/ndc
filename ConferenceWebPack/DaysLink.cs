using System.Net.Http;
using Tavis;
using Tavis.Home;
using Tavis.IANA;

namespace ConferenceWebPack
{
    [LinkRelationType("http://tavis.net/rels/days")]
    public class DaysLink : Link
    {
        public DaysLink()
        {
            this.AddHint<AllowHint>(h =>
                {
                    h.AddMethod(HttpMethod.Get);
                });
            this.AddHint<FormatsHint>(h => h.AddMediaType("application/vnd.collection+json"));
        }
    }
}