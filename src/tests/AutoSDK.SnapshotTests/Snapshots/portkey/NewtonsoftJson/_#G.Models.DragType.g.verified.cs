//HintName: G.Models.DragType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a drag action, this property is <br/>
    /// always set to `drag`.<br/>
    /// Default Value: drag
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DragType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drag")]
        Drag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DragTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DragType value)
        {
            return value switch
            {
                DragType.Drag => "drag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DragType? ToEnum(string value)
        {
            return value switch
            {
                "drag" => DragType.Drag,
                _ => null,
            };
        }
    }
}