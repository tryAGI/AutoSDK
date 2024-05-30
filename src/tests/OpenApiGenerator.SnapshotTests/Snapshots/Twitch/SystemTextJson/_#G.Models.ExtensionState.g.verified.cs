//HintName: G.Models.ExtensionState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The extension’s state. Possible values are:  
    ///   
    /// * Approved
    /// * AssetsUploaded
    /// * Deleted
    /// * Deprecated
    /// * InReview
    /// * InTest
    /// * PendingAction
    /// * Rejected
    /// * Released
    /// </summary>
    public enum ExtensionState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        AssetsUploaded,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Deprecated,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        InTest,
        /// <summary>
        /// 
        /// </summary>
        PendingAction,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Released,
    }

    public static class ExtensionStateExtensions
    {
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
        public static ExtensionState ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionState ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionState.Approved,
                1 => ExtensionState.AssetsUploaded,
                2 => ExtensionState.Deleted,
                3 => ExtensionState.Deprecated,
                4 => ExtensionState.InReview,
                5 => ExtensionState.InTest,
                6 => ExtensionState.PendingAction,
                7 => ExtensionState.Rejected,
                8 => ExtensionState.Released,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}