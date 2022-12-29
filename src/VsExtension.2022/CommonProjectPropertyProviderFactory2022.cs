extern alias LegacyDTE;
using System.Composition;
using LegacyDTE::EnvDTE;
using VsExtension.Common;

namespace VsExtension.Vs2022
{
    [Export(typeof(ICommonProjectPropertyProviderFactory))]
    public class CommonProjectPropertyProviderFactory2022 : ICommonProjectPropertyProviderFactory
    {
        public IProjectPropertyProvider Create(Project vsProject, IOptionsProvider optionsProvider)
        {
            return new CommonProjectPropertyProvider(vsProject, optionsProvider);
        }

        public bool IsNewProjectFormat(Project vsProject)
        {
            return CommonProjectPropertyProvider.IsNewProjectFormat(vsProject);
        }
    }
}
