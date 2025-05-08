//HintName: G.Models.InputImageContentDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputImageContentDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageContentDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageContentDetail value)
        {
            return value switch
            {
                InputImageContentDetail.Low => "low",
                InputImageContentDetail.High => "high",
                InputImageContentDetail.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageContentDetail? ToEnum(string value)
        {
            return value switch
            {
                "low" => InputImageContentDetail.Low,
                "high" => InputImageContentDetail.High,
                "auto" => InputImageContentDetail.Auto,
                _ => null,
            };
        }
    }
}