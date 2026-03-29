//HintName: G.Models.UploadFileOpenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFileOpenRequest
    {
        /// <summary>
        /// 需要上传的文件<br/>
        /// 支持上传的文件格式：文档：DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV<br/>
        /// 图片：JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF<br/>
        /// 音频：WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI<br/>
        /// 视频：MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV<br/>
        /// 文本文件：CPP、PY、JAVA、C<br/>
        /// 压缩包：RAR、ZIP、7Z、GZ、GZIP、BZ2<br/>
        /// 文件上传大小限制：每个文件最大 512 MB。<br/>
        /// 上传到扣子的文件仅限本账号查看或使用。<br/>
        /// 通过此接口上传的文件有效期为 3 个月。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// 需要上传的文件<br/>
        /// 支持上传的文件格式：文档：DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV<br/>
        /// 图片：JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF<br/>
        /// 音频：WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI<br/>
        /// 视频：MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV<br/>
        /// 文本文件：CPP、PY、JAVA、C<br/>
        /// 压缩包：RAR、ZIP、7Z、GZ、GZIP、BZ2<br/>
        /// 文件上传大小限制：每个文件最大 512 MB。<br/>
        /// 上传到扣子的文件仅限本账号查看或使用。<br/>
        /// 通过此接口上传的文件有效期为 3 个月。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileOpenRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// 需要上传的文件<br/>
        /// 支持上传的文件格式：文档：DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV<br/>
        /// 图片：JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF<br/>
        /// 音频：WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI<br/>
        /// 视频：MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV<br/>
        /// 文本文件：CPP、PY、JAVA、C<br/>
        /// 压缩包：RAR、ZIP、7Z、GZ、GZIP、BZ2<br/>
        /// 文件上传大小限制：每个文件最大 512 MB。<br/>
        /// 上传到扣子的文件仅限本账号查看或使用。<br/>
        /// 通过此接口上传的文件有效期为 3 个月。
        /// </param>
        /// <param name="filename">
        /// 需要上传的文件<br/>
        /// 支持上传的文件格式：文档：DOC、DOCX、XLS、XLSX、PPT、PPTX、PDF、Numbers、CSV<br/>
        /// 图片：JPG、JPG2、PNG、GIF、WEBP、HEIC、HEIF、BMP、PCD、TIFF<br/>
        /// 音频：WAV、MP3、FLAC、M4A、AAC、OGG、WMA、MIDI<br/>
        /// 视频：MP4、AVI、MOV、3GP、3GPP、FLV、WEBM、WMV、RMVB、M4V、MKV<br/>
        /// 文本文件：CPP、PY、JAVA、C<br/>
        /// 压缩包：RAR、ZIP、7Z、GZ、GZIP、BZ2<br/>
        /// 文件上传大小限制：每个文件最大 512 MB。<br/>
        /// 上传到扣子的文件仅限本账号查看或使用。<br/>
        /// 通过此接口上传的文件有效期为 3 个月。
        /// </param>
        public UploadFileOpenRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileOpenRequest" /> class.
        /// </summary>
        public UploadFileOpenRequest()
        {
        }
    }
}