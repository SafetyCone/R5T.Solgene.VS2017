using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene.VS2017
{
    public class VisualStudioSolutionFileGenerator : IVisualStudioSolutionFileGenerator
    {
        public SolutionFile GenerateSolutionFile()
        {
            var solutionFile = SolutionFileGenerator.NewVisualStudio2017();
            return solutionFile;
        }
    }
}
