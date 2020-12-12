using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ElectricitytDemo.Localization
{
    public static class ElectricitytDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ElectricitytDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ElectricitytDemoLocalizationConfigurer).GetAssembly(),
                        "ElectricitytDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
