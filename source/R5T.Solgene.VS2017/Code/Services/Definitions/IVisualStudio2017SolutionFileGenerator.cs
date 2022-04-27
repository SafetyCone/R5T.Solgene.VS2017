using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solgene.VS2017
{[ServiceDefinitionMarker]
    public interface IVisualStudio2017SolutionFileGenerator:IServiceDefinition
    {
        SolutionFile GenerateVisualStudio2017SolutionFile();
    }
}
