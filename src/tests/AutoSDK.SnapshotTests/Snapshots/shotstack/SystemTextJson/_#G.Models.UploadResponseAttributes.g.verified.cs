//HintName: G.Models.UploadResponseAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The id and attributes of the upload file including the signed URL to send the binary file data to.
    /// </summary>
    public sealed partial class UploadResponseAttributes
    {
        /// <summary>
        /// The source id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </summary>
        /// <example>zzytey4v-32km-kq1z-aftr-3kcuqi0brad2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The signed URL to use in a PUT request to send the binary file to.<br/>
        /// Example: https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source?AWSAccessKeyId=ASIAWJV3NVDML6LI2ZVG&amp;Expires=1672819007&amp;Signature=9M76gBA%2FghV8ZYvGTp3alo5Ya%2Fk%3D&amp;x-amz-acl=public-read&amp;x-amz-security-token=IQoJb3JpZ2luX2VjEJ%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDmFwLXNvdXRoZWFzdC0yIkcwRQIhAJHrqMCRk7ACXuXmJICTkADbx11e2wUP0RZ3KRdN3%2BGwAiAYt%2FIHlM8rcplCgvsvqH%2BBtSrlCW%2BUeZstwuwgq45Y3iqbAwjo%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAMaDDQzMzExNTIxMTk5MiIMtFX%2Bb1klptd8HXQvKu8Cd0xpHti7cRWkPxQz3foEWSYu1U8In64Qsi6TFK%2BmiOhVnUkHK%2BLSIwF1yQFMK2oTzVXwrEFEsyqlf%2FPZ9j3OL9eLlB7G5AqbC16hjXXR3psipp0dE2uvCV2d%2BIDYgcf1MKmzE0FDfN4wyTez%2Bd%2F3y8nfAtWB%2FCB0wU8AtKNUI7hwNbCYMgCa8QUeAH2UOrriDaN379vKXK%2B1XVplhhuvLX3aC1D0St2U6lC5yaDtZbLGEyymQPhgpp5Mam6jVzHVXXX4%2FvkQSNWbDMuMFd13fqdut9uMPkq4vhZgCmyQsibC7AnrK21QopLY%2F0vhHvPUhSkzRDKjiQou0vDrbTnT4yJLY5RCs9G65yisi6jbyUUbJTUgrME7PPPihs7kM5L%2FGjhmKqe9rNPuzKC%2FISRcmVtAPleX7tqPI7H%2BuEIobS%2FE%2B1jV4oNUFQA549prw3546FXds%2FgCLKRU%2BvxUyi2yKS8U0QC%2FNLMg2p9c81%2BaDCCqxtSdBjqdAcxGASzQwP6hHbfzC2hlnxn%2Bnf4MddgpIPFxvpV18Sy9vUYSU52mrsZK%2FxPcxrg1AM94v0aaW%2FaRE1ESTF2hXJrAJZkDNDPEBQBmcP3ylj4Bf5MsP%2FCspFoF6TvXZPYkH1lSlWHT8OTOugLji7%2F9qb9a6bKzFJqvcS0EiT7v5LCOMOpVA%2FAg9RM0yerN4Zot%2FREHgCSzajNII9Xio%2F0%3D
        /// </summary>
        /// <example>https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source?AWSAccessKeyId=ASIAWJV3NVDML6LI2ZVG&amp;Expires=1672819007&amp;Signature=9M76gBA%2FghV8ZYvGTp3alo5Ya%2Fk%3D&amp;x-amz-acl=public-read&amp;x-amz-security-token=IQoJb3JpZ2luX2VjEJ%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDmFwLXNvdXRoZWFzdC0yIkcwRQIhAJHrqMCRk7ACXuXmJICTkADbx11e2wUP0RZ3KRdN3%2BGwAiAYt%2FIHlM8rcplCgvsvqH%2BBtSrlCW%2BUeZstwuwgq45Y3iqbAwjo%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAMaDDQzMzExNTIxMTk5MiIMtFX%2Bb1klptd8HXQvKu8Cd0xpHti7cRWkPxQz3foEWSYu1U8In64Qsi6TFK%2BmiOhVnUkHK%2BLSIwF1yQFMK2oTzVXwrEFEsyqlf%2FPZ9j3OL9eLlB7G5AqbC16hjXXR3psipp0dE2uvCV2d%2BIDYgcf1MKmzE0FDfN4wyTez%2Bd%2F3y8nfAtWB%2FCB0wU8AtKNUI7hwNbCYMgCa8QUeAH2UOrriDaN379vKXK%2B1XVplhhuvLX3aC1D0St2U6lC5yaDtZbLGEyymQPhgpp5Mam6jVzHVXXX4%2FvkQSNWbDMuMFd13fqdut9uMPkq4vhZgCmyQsibC7AnrK21QopLY%2F0vhHvPUhSkzRDKjiQou0vDrbTnT4yJLY5RCs9G65yisi6jbyUUbJTUgrME7PPPihs7kM5L%2FGjhmKqe9rNPuzKC%2FISRcmVtAPleX7tqPI7H%2BuEIobS%2FE%2B1jV4oNUFQA549prw3546FXds%2FgCLKRU%2BvxUyi2yKS8U0QC%2FNLMg2p9c81%2BaDCCqxtSdBjqdAcxGASzQwP6hHbfzC2hlnxn%2Bnf4MddgpIPFxvpV18Sy9vUYSU52mrsZK%2FxPcxrg1AM94v0aaW%2FaRE1ESTF2hXJrAJZkDNDPEBQBmcP3ylj4Bf5MsP%2FCspFoF6TvXZPYkH1lSlWHT8OTOugLji7%2F9qb9a6bKzFJqvcS0EiT7v5LCOMOpVA%2FAg9RM0yerN4Zot%2FREHgCSzajNII9Xio%2F0%3D</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The time the upload request will expire. The signed URL will expire after one hour. Upload must complete within one hour.<br/>
        /// Example: 2023-01-02T02:47:37.260Z
        /// </summary>
        /// <example>2023-01-02T02:47:37.260Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expires { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponseAttributes" /> class.
        /// </summary>
        /// <param name="id">
        /// The source id.<br/>
        /// Example: zzytey4v-32km-kq1z-aftr-3kcuqi0brad2
        /// </param>
        /// <param name="url">
        /// The signed URL to use in a PUT request to send the binary file to.<br/>
        /// Example: https://shotstack-ingest-api-v1-sources.s3.ap-southeast-2.amazonaws.com/5ca6hu7s9k/zzytey4v-32km-kq1z-aftr-3kcuqi0brad2/source?AWSAccessKeyId=ASIAWJV3NVDML6LI2ZVG&amp;Expires=1672819007&amp;Signature=9M76gBA%2FghV8ZYvGTp3alo5Ya%2Fk%3D&amp;x-amz-acl=public-read&amp;x-amz-security-token=IQoJb3JpZ2luX2VjEJ%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDmFwLXNvdXRoZWFzdC0yIkcwRQIhAJHrqMCRk7ACXuXmJICTkADbx11e2wUP0RZ3KRdN3%2BGwAiAYt%2FIHlM8rcplCgvsvqH%2BBtSrlCW%2BUeZstwuwgq45Y3iqbAwjo%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAMaDDQzMzExNTIxMTk5MiIMtFX%2Bb1klptd8HXQvKu8Cd0xpHti7cRWkPxQz3foEWSYu1U8In64Qsi6TFK%2BmiOhVnUkHK%2BLSIwF1yQFMK2oTzVXwrEFEsyqlf%2FPZ9j3OL9eLlB7G5AqbC16hjXXR3psipp0dE2uvCV2d%2BIDYgcf1MKmzE0FDfN4wyTez%2Bd%2F3y8nfAtWB%2FCB0wU8AtKNUI7hwNbCYMgCa8QUeAH2UOrriDaN379vKXK%2B1XVplhhuvLX3aC1D0St2U6lC5yaDtZbLGEyymQPhgpp5Mam6jVzHVXXX4%2FvkQSNWbDMuMFd13fqdut9uMPkq4vhZgCmyQsibC7AnrK21QopLY%2F0vhHvPUhSkzRDKjiQou0vDrbTnT4yJLY5RCs9G65yisi6jbyUUbJTUgrME7PPPihs7kM5L%2FGjhmKqe9rNPuzKC%2FISRcmVtAPleX7tqPI7H%2BuEIobS%2FE%2B1jV4oNUFQA549prw3546FXds%2FgCLKRU%2BvxUyi2yKS8U0QC%2FNLMg2p9c81%2BaDCCqxtSdBjqdAcxGASzQwP6hHbfzC2hlnxn%2Bnf4MddgpIPFxvpV18Sy9vUYSU52mrsZK%2FxPcxrg1AM94v0aaW%2FaRE1ESTF2hXJrAJZkDNDPEBQBmcP3ylj4Bf5MsP%2FCspFoF6TvXZPYkH1lSlWHT8OTOugLji7%2F9qb9a6bKzFJqvcS0EiT7v5LCOMOpVA%2FAg9RM0yerN4Zot%2FREHgCSzajNII9Xio%2F0%3D
        /// </param>
        /// <param name="expires">
        /// The time the upload request will expire. The signed URL will expire after one hour. Upload must complete within one hour.<br/>
        /// Example: 2023-01-02T02:47:37.260Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadResponseAttributes(
            string id,
            string url,
            string expires)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Expires = expires ?? throw new global::System.ArgumentNullException(nameof(expires));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadResponseAttributes" /> class.
        /// </summary>
        public UploadResponseAttributes()
        {
        }
    }
}