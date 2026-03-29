//HintName: G.Models.HeyGenTextToAvatarOptionsAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The avatar character to generate. Select from the list of available avatars: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`Angela`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Bill`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Daisy`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Derek`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Eva`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Jake`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Jeff`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Jerome`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Joon`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Kayla`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Kent`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Luna`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Mark`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Matthew`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Monica`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Peter`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Selina`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Tanya`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Thomas`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Tina`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Tyler`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Vanessa`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Vera`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Wilson`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`Zoey`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum HeyGenTextToAvatarOptionsAvatar
    {
        /// <summary>
        /// 
        /// </summary>
        Angela,
        /// <summary>
        /// 
        /// </summary>
        Bill,
        /// <summary>
        /// 
        /// </summary>
        Daisy,
        /// <summary>
        /// 
        /// </summary>
        Derek,
        /// <summary>
        /// 
        /// </summary>
        Eva,
        /// <summary>
        /// 
        /// </summary>
        Jake,
        /// <summary>
        /// 
        /// </summary>
        Jeff,
        /// <summary>
        /// 
        /// </summary>
        Jerome,
        /// <summary>
        /// 
        /// </summary>
        Joon,
        /// <summary>
        /// 
        /// </summary>
        Kayla,
        /// <summary>
        /// 
        /// </summary>
        Kent,
        /// <summary>
        /// 
        /// </summary>
        Luna,
        /// <summary>
        /// 
        /// </summary>
        Mark,
        /// <summary>
        /// 
        /// </summary>
        Matthew,
        /// <summary>
        /// 
        /// </summary>
        Monica,
        /// <summary>
        /// 
        /// </summary>
        Peter,
        /// <summary>
        /// 
        /// </summary>
        Selina,
        /// <summary>
        /// 
        /// </summary>
        Tanya,
        /// <summary>
        /// 
        /// </summary>
        Thomas,
        /// <summary>
        /// 
        /// </summary>
        Tina,
        /// <summary>
        /// 
        /// </summary>
        Tyler,
        /// <summary>
        /// 
        /// </summary>
        Vanessa,
        /// <summary>
        /// 
        /// </summary>
        Vera,
        /// <summary>
        /// 
        /// </summary>
        Wilson,
        /// <summary>
        /// 
        /// </summary>
        Zoey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HeyGenTextToAvatarOptionsAvatarExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeyGenTextToAvatarOptionsAvatar value)
        {
            return value switch
            {
                HeyGenTextToAvatarOptionsAvatar.Angela => "Angela",
                HeyGenTextToAvatarOptionsAvatar.Bill => "Bill",
                HeyGenTextToAvatarOptionsAvatar.Daisy => "Daisy",
                HeyGenTextToAvatarOptionsAvatar.Derek => "Derek",
                HeyGenTextToAvatarOptionsAvatar.Eva => "Eva",
                HeyGenTextToAvatarOptionsAvatar.Jake => "Jake",
                HeyGenTextToAvatarOptionsAvatar.Jeff => "Jeff",
                HeyGenTextToAvatarOptionsAvatar.Jerome => "Jerome",
                HeyGenTextToAvatarOptionsAvatar.Joon => "Joon",
                HeyGenTextToAvatarOptionsAvatar.Kayla => "Kayla",
                HeyGenTextToAvatarOptionsAvatar.Kent => "Kent",
                HeyGenTextToAvatarOptionsAvatar.Luna => "Luna",
                HeyGenTextToAvatarOptionsAvatar.Mark => "Mark",
                HeyGenTextToAvatarOptionsAvatar.Matthew => "Matthew",
                HeyGenTextToAvatarOptionsAvatar.Monica => "Monica",
                HeyGenTextToAvatarOptionsAvatar.Peter => "Peter",
                HeyGenTextToAvatarOptionsAvatar.Selina => "Selina",
                HeyGenTextToAvatarOptionsAvatar.Tanya => "Tanya",
                HeyGenTextToAvatarOptionsAvatar.Thomas => "Thomas",
                HeyGenTextToAvatarOptionsAvatar.Tina => "Tina",
                HeyGenTextToAvatarOptionsAvatar.Tyler => "Tyler",
                HeyGenTextToAvatarOptionsAvatar.Vanessa => "Vanessa",
                HeyGenTextToAvatarOptionsAvatar.Vera => "Vera",
                HeyGenTextToAvatarOptionsAvatar.Wilson => "Wilson",
                HeyGenTextToAvatarOptionsAvatar.Zoey => "Zoey",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeyGenTextToAvatarOptionsAvatar? ToEnum(string value)
        {
            return value switch
            {
                "Angela" => HeyGenTextToAvatarOptionsAvatar.Angela,
                "Bill" => HeyGenTextToAvatarOptionsAvatar.Bill,
                "Daisy" => HeyGenTextToAvatarOptionsAvatar.Daisy,
                "Derek" => HeyGenTextToAvatarOptionsAvatar.Derek,
                "Eva" => HeyGenTextToAvatarOptionsAvatar.Eva,
                "Jake" => HeyGenTextToAvatarOptionsAvatar.Jake,
                "Jeff" => HeyGenTextToAvatarOptionsAvatar.Jeff,
                "Jerome" => HeyGenTextToAvatarOptionsAvatar.Jerome,
                "Joon" => HeyGenTextToAvatarOptionsAvatar.Joon,
                "Kayla" => HeyGenTextToAvatarOptionsAvatar.Kayla,
                "Kent" => HeyGenTextToAvatarOptionsAvatar.Kent,
                "Luna" => HeyGenTextToAvatarOptionsAvatar.Luna,
                "Mark" => HeyGenTextToAvatarOptionsAvatar.Mark,
                "Matthew" => HeyGenTextToAvatarOptionsAvatar.Matthew,
                "Monica" => HeyGenTextToAvatarOptionsAvatar.Monica,
                "Peter" => HeyGenTextToAvatarOptionsAvatar.Peter,
                "Selina" => HeyGenTextToAvatarOptionsAvatar.Selina,
                "Tanya" => HeyGenTextToAvatarOptionsAvatar.Tanya,
                "Thomas" => HeyGenTextToAvatarOptionsAvatar.Thomas,
                "Tina" => HeyGenTextToAvatarOptionsAvatar.Tina,
                "Tyler" => HeyGenTextToAvatarOptionsAvatar.Tyler,
                "Vanessa" => HeyGenTextToAvatarOptionsAvatar.Vanessa,
                "Vera" => HeyGenTextToAvatarOptionsAvatar.Vera,
                "Wilson" => HeyGenTextToAvatarOptionsAvatar.Wilson,
                "Zoey" => HeyGenTextToAvatarOptionsAvatar.Zoey,
                _ => null,
            };
        }
    }
}