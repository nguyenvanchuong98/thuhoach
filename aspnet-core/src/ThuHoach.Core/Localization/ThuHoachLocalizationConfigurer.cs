using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ThuHoach.Localization
{
    public static class ThuHoachLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ThuHoachConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ThuHoachLocalizationConfigurer).GetAssembly(),
                        "ThuHoach.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
