//HintName: G.Models.TraceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TraceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="descendant_error")]
        DescendantError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="running")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceStatus value)
        {
            return value switch
            {
                TraceStatus.DescendantError => "descendant_error",
                TraceStatus.Error => "error",
                TraceStatus.Running => "running",
                TraceStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceStatus? ToEnum(string value)
        {
            return value switch
            {
                "descendant_error" => TraceStatus.DescendantError,
                "error" => TraceStatus.Error,
                "running" => TraceStatus.Running,
                "success" => TraceStatus.Success,
                _ => null,
            };
        }
    }
}