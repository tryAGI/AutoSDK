//HintName: G.Models.ModelRunStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Pending` - Pending<br/>
    /// * `InProgress` - InProgress<br/>
    /// * `Completed` - Completed<br/>
    /// * `Failed` - Failed<br/>
    /// * `Canceled` - Canceled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelRunStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Canceled")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="InProgress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelRunStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelRunStatusEnum value)
        {
            return value switch
            {
                ModelRunStatusEnum.Canceled => "Canceled",
                ModelRunStatusEnum.Completed => "Completed",
                ModelRunStatusEnum.Failed => "Failed",
                ModelRunStatusEnum.InProgress => "InProgress",
                ModelRunStatusEnum.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelRunStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "Canceled" => ModelRunStatusEnum.Canceled,
                "Completed" => ModelRunStatusEnum.Completed,
                "Failed" => ModelRunStatusEnum.Failed,
                "InProgress" => ModelRunStatusEnum.InProgress,
                "Pending" => ModelRunStatusEnum.Pending,
                _ => null,
            };
        }
    }
}