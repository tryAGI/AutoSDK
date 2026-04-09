//HintName: G.IApi.PublicAudioSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 语音合成<br/>
        /// {"0":{"ops":[{"insert":"将指定文本合成为音频文件。\n"},{"attributes":{"anchor":"677ab7d5","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于将指定文本内容合成为自然流畅的音频，同步返回合成的音频文件，适用于有声书合成、智能客服语音、音视频配音等场景。合成音频文件之前，可以先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/list_voices\",\"linkId\":\"ZEUd6rdOvN\"}"},"insert":"查看音色列表"},{"insert":" API，查看所有可用音色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"KCecIryVWB","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"KCecIryVWB":{"ops":[{"insert":"调用语音合成 API 会产生"},{"attributes":{"bold":"true"},"insert":"语音合成费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/coze_pro/asr_tts_fee#b7ced22d\",\"linkId\":\"CEZbHqqDri\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。\n"}],"zoneId":"KCecIryVWB","zoneType":"Z"}}
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PublicAudioSpeechResponse> PublicAudioSpeechAsync(

            global::G.PublicAudioSpeechRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 语音合成<br/>
        /// {"0":{"ops":[{"insert":"将指定文本合成为音频文件。\n"},{"attributes":{"anchor":"677ab7d5","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"此 API 用于将指定文本内容合成为自然流畅的音频，同步返回合成的音频文件，适用于有声书合成、智能客服语音、音视频配音等场景。合成音频文件之前，可以先调用"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/developer_guides/list_voices\",\"linkId\":\"ZEUd6rdOvN\"}"},"insert":"查看音色列表"},{"insert":" API，查看所有可用音色。\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"attributes":{"zoneId":"KCecIryVWB","zoneType":"Z","type":"warning","title":"注意","border":"#fed4a4","background":"#fff5eb","highlight-block-v2":"true"},"insert":" "},{"insert":"\n"}],"zoneId":"0","zoneType":"Z"},"KCecIryVWB":{"ops":[{"insert":"调用语音合成 API 会产生"},{"attributes":{"bold":"true"},"insert":"语音合成费用"},{"insert":"，具体费用详情请参考"},{"attributes":{"hyperlink":"{\"href\":\"https://www.coze.cn/open/docs/coze_pro/asr_tts_fee#b7ced22d\",\"linkId\":\"CEZbHqqDri\",\"newTab\":true}"},"insert":"音视频费用"},{"insert":"。\n"}],"zoneId":"KCecIryVWB","zoneType":"Z"}}
        /// </summary>
        /// <param name="contextTexts">
        /// 语音合成辅助信息
        /// </param>
        /// <param name="emotion">
        /// 情感，可选值 [none,happy,angry,sad,neutral]，默认 none
        /// </param>
        /// <param name="emotionScale">
        /// 情绪值，[1,5]，默认 4
        /// </param>
        /// <param name="input">
        /// 必选，合成语音的文本，长度限制 1024 字节（UTF-8编码）。
        /// </param>
        /// <param name="loudnessRate">
        /// 音量，[-50,100]，默认 0
        /// </param>
        /// <param name="responseFormat">
        /// 音频编码格式，wav / pcm / ogg_opus / mp3，默认为 mp3
        /// </param>
        /// <param name="sampleRate">
        /// 采样率，可选值 [8000,16000,22050,24000,32000,44100,48000]，默认 24000
        /// </param>
        /// <param name="speed">
        /// 语速，[0.2,3]，默认为1，通常保留一位小数即可
        /// </param>
        /// <param name="voiceId">
        /// 必选，音色id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PublicAudioSpeechResponse> PublicAudioSpeechAsync(
            string input,
            string voiceId,
            string? contextTexts = default,
            global::G.PublicAudioSpeechRequestEmotion? emotion = default,
            double? emotionScale = default,
            int? loudnessRate = default,
            global::G.PublicAudioSpeechRequestResponseFormat? responseFormat = default,
            int? sampleRate = default,
            double? speed = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}