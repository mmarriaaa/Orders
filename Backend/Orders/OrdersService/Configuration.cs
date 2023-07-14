using Common;
using System.Globalization;

namespace OrdersService
{
    public class Configuration
    {
        public string Culture { get; set; }

        public string[] SupportedCulturesNames { get; set; }

        public IEnumerable<CultureInfo> SupportedCultures
        {
            get
            {
                foreach (var supportedCultureName in SupportedCulturesNames)
                {
                    Argument.NotNull(supportedCultureName, nameof(supportedCultureName));
                    yield return new CultureInfo(supportedCultureName);
                }
            }
        }
    }
}
