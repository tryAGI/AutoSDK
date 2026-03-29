//HintName: G.Models.FunctionBuildCauseCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionBuildCauseCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INVALID_SESSION_CREATE_PARAMS")]
        InvalidSessionCreateParams,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANIFEST_TOO_LARGE")]
        ManifestTooLarge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO_MANIFESTS_FOUND")]
        NoManifestsFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TIMED_OUT")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOO_MANY_MANIFESTS")]
        TooManyManifests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionBuildCauseCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionBuildCauseCode value)
        {
            return value switch
            {
                FunctionBuildCauseCode.InvalidSessionCreateParams => "INVALID_SESSION_CREATE_PARAMS",
                FunctionBuildCauseCode.ManifestTooLarge => "MANIFEST_TOO_LARGE",
                FunctionBuildCauseCode.NoManifestsFound => "NO_MANIFESTS_FOUND",
                FunctionBuildCauseCode.TimedOut => "TIMED_OUT",
                FunctionBuildCauseCode.TooManyManifests => "TOO_MANY_MANIFESTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionBuildCauseCode? ToEnum(string value)
        {
            return value switch
            {
                "INVALID_SESSION_CREATE_PARAMS" => FunctionBuildCauseCode.InvalidSessionCreateParams,
                "MANIFEST_TOO_LARGE" => FunctionBuildCauseCode.ManifestTooLarge,
                "NO_MANIFESTS_FOUND" => FunctionBuildCauseCode.NoManifestsFound,
                "TIMED_OUT" => FunctionBuildCauseCode.TimedOut,
                "TOO_MANY_MANIFESTS" => FunctionBuildCauseCode.TooManyManifests,
                _ => null,
            };
        }
    }
}