//HintName: G.Models.Status7bfEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `created` - Created<br/>
    /// * `in_progress` - In progress<br/>
    /// * `failed` - Failed<br/>
    /// * `completed` - Completed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Status7bfEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Status7bfEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status7bfEnum value)
        {
            return value switch
            {
                Status7bfEnum.Completed => "completed",
                Status7bfEnum.Created => "created",
                Status7bfEnum.Failed => "failed",
                Status7bfEnum.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status7bfEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => Status7bfEnum.Completed,
                "created" => Status7bfEnum.Created,
                "failed" => Status7bfEnum.Failed,
                "in_progress" => Status7bfEnum.InProgress,
                _ => null,
            };
        }
    }
}