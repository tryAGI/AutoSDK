//HintName: G.Models.Company._TypeEnum.g.cs

#nullable enable

namespace G
{
    public sealed partial class Company
    {
        /// <summary>
        /// <br/>Example: isp
        /// </summary>
        [global::System.Runtime.Serialization.DataContract]
        public enum _TypeEnum
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