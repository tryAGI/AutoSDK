//HintName: G.Models.CodeScanningAlertInstanceClassifications.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A classification of the file. For example to identify it as generated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertInstanceClassifications
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="source")]
        Source,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="test")]
        Test,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="library")]
        Library,
    }
}