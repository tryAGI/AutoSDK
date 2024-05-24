//HintName: G.Models.RunnerLabelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of label. Read-only labels are applied automatically when the runner is configured.
    /// </summary>
    public abstract class RunnerLabelType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string ReadOnly = "read-only";
        /// <summary>
        /// 
        /// </summary>
        public const string Custom = "custom";
    }
}