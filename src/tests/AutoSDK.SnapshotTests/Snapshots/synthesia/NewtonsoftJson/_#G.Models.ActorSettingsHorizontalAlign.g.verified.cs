//HintName: G.Models.ActorSettingsHorizontalAlign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// At the moment `verticalAlign` field is not exposed via API and is fixed to `bottom`, however together with `horizontalAlign` they define a reference point from where we scale the rectangular style avatar. For example, `horizontal alignment: left`, would mean that avatar is called from the bottom-left corner towards the top-right corner.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActorSettingsHorizontalAlign
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// left`, would mean that avatar is called from the bottom-left corner towards the top-right corner.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="left")]
        Left,
        /// <summary>
        /// left`, would mean that avatar is called from the bottom-left corner towards the top-right corner.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="right")]
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActorSettingsHorizontalAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorSettingsHorizontalAlign value)
        {
            return value switch
            {
                ActorSettingsHorizontalAlign.Center => "center",
                ActorSettingsHorizontalAlign.Left => "left",
                ActorSettingsHorizontalAlign.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorSettingsHorizontalAlign? ToEnum(string value)
        {
            return value switch
            {
                "center" => ActorSettingsHorizontalAlign.Center,
                "left" => ActorSettingsHorizontalAlign.Left,
                "right" => ActorSettingsHorizontalAlign.Right,
                _ => null,
            };
        }
    }
}