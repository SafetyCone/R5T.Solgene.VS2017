using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solgene.VS2017
{[ServiceImplementationMarker]
    public class VisualStudioSolutionFileGenerator : IVisualStudioSolutionFileGenerator,IServiceImplementation
    {
        private IVisualStudio2017SolutionFileGenerator VisualStudio2017SolutionFileGenerator { get; }


        public VisualStudioSolutionFileGenerator(IVisualStudio2017SolutionFileGenerator visualStudio2017SolutionFileGenerator)
        {
            this.VisualStudio2017SolutionFileGenerator = visualStudio2017SolutionFileGenerator;
        }

        public SolutionFile GenerateVisualStudioSolutionFile()
        {
            var solutionFile = this.VisualStudio2017SolutionFileGenerator.GenerateVisualStudio2017SolutionFile();
            return solutionFile;
        }
    }
}
