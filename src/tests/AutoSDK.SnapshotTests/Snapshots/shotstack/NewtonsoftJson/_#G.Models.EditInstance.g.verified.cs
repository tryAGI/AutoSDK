//HintName: G.Models.EditInstance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The render instance type to use for processing the edit. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`s1` - standard instance (default)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`s2` - standard instance with more resources&lt;/li&gt;<br/>
    ///   &lt;li&gt;`a1` - accelerated instance for faster rendering&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: s1
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditInstance
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="a1")]
        A1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s1")]
        S1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s2")]
        S2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditInstanceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditInstance value)
        {
            return value switch
            {
                EditInstance.A1 => "a1",
                EditInstance.S1 => "s1",
                EditInstance.S2 => "s2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditInstance? ToEnum(string value)
        {
            return value switch
            {
                "a1" => EditInstance.A1,
                "s1" => EditInstance.S1,
                "s2" => EditInstance.S2,
                _ => null,
            };
        }
    }
}