//HintName: G.Models.AgentSuccessResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates successful completion<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentSuccessResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSuccessResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSuccessResultStatus value)
        {
            return value switch
            {
                AgentSuccessResultStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSuccessResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => AgentSuccessResultStatus.Success,
                _ => null,
            };
        }
    }
}