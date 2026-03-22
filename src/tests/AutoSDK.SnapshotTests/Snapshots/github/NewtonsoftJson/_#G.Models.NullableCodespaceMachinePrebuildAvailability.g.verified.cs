//HintName: G.Models.NullableCodespaceMachinePrebuildAvailability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.<br/>
    /// Example: ready
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableCodespaceMachinePrebuildAvailability
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableCodespaceMachinePrebuildAvailabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableCodespaceMachinePrebuildAvailability value)
        {
            return value switch
            {
                NullableCodespaceMachinePrebuildAvailability.InProgress => "in_progress",
                NullableCodespaceMachinePrebuildAvailability.None => "none",
                NullableCodespaceMachinePrebuildAvailability.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableCodespaceMachinePrebuildAvailability? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => NullableCodespaceMachinePrebuildAvailability.InProgress,
                "none" => NullableCodespaceMachinePrebuildAvailability.None,
                "ready" => NullableCodespaceMachinePrebuildAvailability.Ready,
                _ => null,
            };
        }
    }
}