//HintName: G.Models.DIDTextToAvatarOptionsAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The avatar character to generate. Select from the list of available avatars: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`jack`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`lana`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`lily`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`matt`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`rian`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum DIDTextToAvatarOptionsAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        Jack,
        /// <summary>
        /// 
        /// </summary>
        Lana,
        /// <summary>
        /// 
        /// </summary>
        Lily,
        /// <summary>
        /// 
        /// </summary>
        Matt,
        /// <summary>
        /// 
        /// </summary>
        Rian,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DIDTextToAvatarOptionsAvatarExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIDTextToAvatarOptionsAvatar value)
        {
            return value switch
            {
                DIDTextToAvatarOptionsAvatar.Jack => "jack",
                DIDTextToAvatarOptionsAvatar.Lana => "lana",
                DIDTextToAvatarOptionsAvatar.Lily => "lily",
                DIDTextToAvatarOptionsAvatar.Matt => "matt",
                DIDTextToAvatarOptionsAvatar.Rian => "rian",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIDTextToAvatarOptionsAvatar? ToEnum(string value)
        {
            return value switch
            {
                "jack" => DIDTextToAvatarOptionsAvatar.Jack,
                "lana" => DIDTextToAvatarOptionsAvatar.Lana,
                "lily" => DIDTextToAvatarOptionsAvatar.Lily,
                "matt" => DIDTextToAvatarOptionsAvatar.Matt,
                "rian" => DIDTextToAvatarOptionsAvatar.Rian,
                _ => null,
            };
        }
    }
}