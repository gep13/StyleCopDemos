using System;
using System.Diagnostics.CodeAnalysis;

namespace StyleCopContrib.CustomRules.Tests.TargetFiles.Naming
{
    /// <summary>
    /// Test class for rule FileNameMustMatchTypeName
    /// </summary>
    [SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "For test")]
    internal class FileNameMustMatchTypeName3
    {
        #region Nested Type

        /// <summary>
        /// Test class
        /// </summary>
        [SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Justification = "For test")]
        private class Toto
        {
        }

        #endregion
    }
}