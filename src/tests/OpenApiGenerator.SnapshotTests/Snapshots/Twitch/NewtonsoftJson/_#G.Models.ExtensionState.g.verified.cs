//HintName: G.Models.ExtensionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The extension’s state. Possible values are:  <br/>
    ///   <br/>
    /// * Approved<br/>
    /// * AssetsUploaded<br/>
    /// * Deleted<br/>
    /// * Deprecated<br/>
    /// * InReview<br/>
    /// * InTest<br/>
    /// * PendingAction<br/>
    /// * Rejected<br/>
    /// * Released
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AssetsUploaded")]
        AssetsUploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Deprecated")]
        Deprecated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="InReview")]
        InReview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="InTest")]
        InTest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PendingAction")]
        PendingAction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Released")]
        Released,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtensionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtensionState value)
        {
            return value switch
            {
                ExtensionState.Approved => "Approved",
                ExtensionState.AssetsUploaded => "AssetsUploaded",
                ExtensionState.Deleted => "Deleted",
                ExtensionState.Deprecated => "Deprecated",
                ExtensionState.InReview => "InReview",
                ExtensionState.InTest => "InTest",
                ExtensionState.PendingAction => "PendingAction",
                ExtensionState.Rejected => "Rejected",
                ExtensionState.Released => "Released",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionState? ToEnum(string value)
        {
            return value switch
            {
                "Approved" => ExtensionState.Approved,
                "AssetsUploaded" => ExtensionState.AssetsUploaded,
                "Deleted" => ExtensionState.Deleted,
                "Deprecated" => ExtensionState.Deprecated,
                "InReview" => ExtensionState.InReview,
                "InTest" => ExtensionState.InTest,
                "PendingAction" => ExtensionState.PendingAction,
                "Rejected" => ExtensionState.Rejected,
                "Released" => ExtensionState.Released,
                _ => null,
            };
        }
    }
}