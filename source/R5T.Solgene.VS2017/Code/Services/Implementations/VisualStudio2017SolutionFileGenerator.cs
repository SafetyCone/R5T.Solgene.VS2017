using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene.VS2017
{
    public class VisualStudio2017SolutionFileGenerator : IVisualStudio2017SolutionFileGenerator
    {
        public SolutionFile GenerateVisualStudio2017SolutionFile()
        {
            var solutionFile = SolutionFileGenerator.NewVisualStudio2017();
            return solutionFile;
        }
    }
}
