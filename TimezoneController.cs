using Microsoft.AspNetCore.Mvc;
using TimeZoneConverter;

namespace Timezones;

[ApiController]
[Route ("[controller]")]
public class TimezoneController : Controller {

    [HttpGet]
    public IActionResult Get () {
        var tz = TimeZoneInfo.GetSystemTimeZones ();

        foreach (var tzInfo in tz) {
            TimeZoneInfo.FindSystemTimeZoneById(tzInfo.Id);
        }

        // var converted = tz.Where (t => TZConvert.TryIanaToWindows (t.Id, out var _)).Select (t => {
        //     var nt = TimeZoneInfo.CreateCustomTimeZone(TZConvert.IanaToWindows (t.Id), t.
        // });

        // // TZConvert.KnownWindowsTimeZoneIds.Select(h => )

        return Ok (tz);
    }
}