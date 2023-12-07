//HintName: G.Models.AsnResponse.TypeEnum.g.cs

#nullable enable

namespace G
{
    public sealed partial class AsnResponse
    {
        /// <summary>
        /// <br/>Example: isp
        /// </summary>
        [global::System.Runtime.Serialization.DataContract]
        public enum TypeEnum
        {
            /// <summary>
            /// 
            /// </summary>
            [global::System.Runtime.Serialization.EnumMember(Value="isp")]
            Isp,
            /// <summary>
            /// 
            /// </summary>
            [global::System.Runtime.Serialization.EnumMember(Value="business")]
            Business,
            /// <summary>
            /// 
            /// </summary>
            [global::System.Runtime.Serialization.EnumMember(Value="education")]
            Education,
            /// <summary>
            /// 
            /// </summary>
            [global::System.Runtime.Serialization.EnumMember(Value="hosting")]
            Hosting,
        }
    }
}