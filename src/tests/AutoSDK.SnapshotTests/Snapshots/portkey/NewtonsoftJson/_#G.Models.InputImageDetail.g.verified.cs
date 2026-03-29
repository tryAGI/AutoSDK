//HintName: G.Models.InputImageDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The detail level of the image to be sent to the model. One of `high`,<br/>
    /// `low`, or `auto`. Defaults to `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputImageDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageDetail value)
        {
            return value switch
            {
                InputImageDetail.Auto => "auto",
                InputImageDetail.High => "high",
                InputImageDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => InputImageDetail.Auto,
                "high" => InputImageDetail.High,
                "low" => InputImageDetail.Low,
                _ => null,
            };
        }
    }
}