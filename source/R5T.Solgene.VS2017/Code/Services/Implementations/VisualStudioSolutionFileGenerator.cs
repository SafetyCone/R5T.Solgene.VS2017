using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene.VS2017
{
    public class VisualStudioSolutionFileGenerator : IVisualStudioSolutionFileGenerator
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
