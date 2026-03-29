//HintName: G.Models.LanguageBCP47.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A class for representing languages according to the BCP-47 standard.<br/>
    /// The standard is followed very loosely, only primary language and region<br/>
    /// sub-tags are implemented right now.<br/>
    /// The display names of the languages are derived from the enum names,<br/>
    /// with the primary language name capitalized and the region name<br/>
    /// capitalized and enclosed in parentheses if present. If you need to<br/>
    /// customize the display name for a specific language, you can override<br/>
    /// the `override_display_name` method.<br/>
    /// https://www.w3.org/International/questions/qa-choosing-language-tags
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LanguageBCP47
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="af")]
        Af,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="am")]
        Am,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar")]
        Ar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-AE")]
        ArAe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-BH")]
        ArBh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-DZ")]
        ArDz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-EG")]
        ArEg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-IQ")]
        ArIq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-JO")]
        ArJo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-KW")]
        ArKw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-LY")]
        ArLy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-MA")]
        ArMa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-QA")]
        ArQa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-SA")]
        ArSa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-SY")]
        ArSy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-TN")]
        ArTn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ar-YE")]
        ArYe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="as")]
        As,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="az")]
        Az,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ba")]
        Ba,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="be")]
        Be,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bg")]
        Bg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bn")]
        Bn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bo")]
        Bo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="br")]
        Br,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bs")]
        Bs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ca")]
        Ca,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ceb")]
        Ceb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cs")]
        Cs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cy")]
        Cy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="da")]
        Da,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de")]
        De,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de-AT")]
        DeAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de-CH")]
        DeCh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="de-DE")]
        DeDe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="el")]
        El,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-AU")]
        EnAu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-CA")]
        EnCa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-GB")]
        EnGb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-HK")]
        EnHk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-IE")]
        EnIe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-IN")]
        EnIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-KE")]
        EnKe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-MX")]
        EnMx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-NG")]
        EnNg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-NZ")]
        EnNz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-PH")]
        EnPh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-SG")]
        EnSg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-TZ")]
        EnTz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-US")]
        EnUs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en-ZA")]
        EnZa,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es")]
        Es,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-AR")]
        EsAr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-BO")]
        EsBo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-CL")]
        EsCl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-CO")]
        EsCo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-CR")]
        EsCr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-CU")]
        EsCu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-DO")]
        EsDo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-EC")]
        EsEc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-ES")]
        EsEs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-GQ")]
        EsGq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-GT")]
        EsGt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-HN")]
        EsHn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-LA")]
        EsLa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-MX")]
        EsMx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-NI")]
        EsNi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-PA")]
        EsPa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-PE")]
        EsPe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-PR")]
        EsPr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-PY")]
        EsPy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-SV")]
        EsSv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-US")]
        EsUs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-UY")]
        EsUy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="es-VE")]
        EsVe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="et")]
        Et,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu")]
        Eu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fa")]
        Fa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fi")]
        Fi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fil")]
        Fil,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fo")]
        Fo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr")]
        Fr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr-BE")]
        FrBe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr-CA")]
        FrCa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr-CH")]
        FrCh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fr-FR")]
        FrFr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ga")]
        Ga,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gl")]
        Gl,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gu")]
        Gu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ha")]
        Ha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="haw")]
        Haw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="he")]
        He,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hi")]
        Hi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hr")]
        Hr,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ht")]
        Ht,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hu")]
        Hu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hy")]
        Hy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="is")]
        Is,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="it")]
        It,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ja")]
        Ja,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jw")]
        Jw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ka")]
        Ka,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kk")]
        Kk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="km")]
        Km,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kn")]
        Kn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ko")]
        Ko,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ky")]
        Ky,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="la")]
        La,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lb")]
        Lb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ln")]
        Ln,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lo")]
        Lo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lv")]
        Lv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mg")]
        Mg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mi")]
        Mi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mk")]
        Mk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ml")]
        Ml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mn")]
        Mn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mr")]
        Mr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ms")]
        Ms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mt")]
        Mt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="my")]
        My,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nb")]
        Nb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ne")]
        Ne,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl")]
        Nl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl-BE")]
        NlBe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nl-NL")]
        NlNl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nn")]
        Nn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no")]
        No,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ny")]
        Ny,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oc")]
        Oc,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or")]
        Or,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pa")]
        Pa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pl")]
        Pl,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ps")]
        Ps,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt")]
        Pt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt-BR")]
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pt-PT")]
        PtPt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ro")]
        Ro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ru")]
        Ru,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sa")]
        Sa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sd")]
        Sd,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="si")]
        Si,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sk")]
        Sk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sl")]
        Sl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sn")]
        Sn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="so")]
        So,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sq")]
        Sq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sr")]
        Sr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="su")]
        Su,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sv")]
        Sv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sw")]
        Sw,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta")]
        Ta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta-IN")]
        TaIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta-LK")]
        TaLk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ta-SG")]
        TaSg,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="te")]
        Te,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tg")]
        Tg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="th")]
        Th,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tk")]
        Tk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tl")]
        Tl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tr")]
        Tr,
        /// <summary>
        /// //www.w3.org/International/questions/qa-choosing-language-tags
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tt")]
        Tt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="und")]
        Und,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ur")]
        Ur,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uz")]
        Uz,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vi")]
        Vi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="yi")]
        Yi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="yo")]
        Yo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh")]
        Zh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh-CN")]
        ZhCn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh-HK")]
        ZhHk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zh-TW")]
        ZhTw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zu")]
        Zu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageBCP47Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageBCP47 value)
        {
            return value switch
            {
                LanguageBCP47.Af => "af",
                LanguageBCP47.Am => "am",
                LanguageBCP47.Ar => "ar",
                LanguageBCP47.ArAe => "ar-AE",
                LanguageBCP47.ArBh => "ar-BH",
                LanguageBCP47.ArDz => "ar-DZ",
                LanguageBCP47.ArEg => "ar-EG",
                LanguageBCP47.ArIq => "ar-IQ",
                LanguageBCP47.ArJo => "ar-JO",
                LanguageBCP47.ArKw => "ar-KW",
                LanguageBCP47.ArLy => "ar-LY",
                LanguageBCP47.ArMa => "ar-MA",
                LanguageBCP47.ArQa => "ar-QA",
                LanguageBCP47.ArSa => "ar-SA",
                LanguageBCP47.ArSy => "ar-SY",
                LanguageBCP47.ArTn => "ar-TN",
                LanguageBCP47.ArYe => "ar-YE",
                LanguageBCP47.As => "as",
                LanguageBCP47.Az => "az",
                LanguageBCP47.Ba => "ba",
                LanguageBCP47.Be => "be",
                LanguageBCP47.Bg => "bg",
                LanguageBCP47.Bn => "bn",
                LanguageBCP47.Bo => "bo",
                LanguageBCP47.Br => "br",
                LanguageBCP47.Bs => "bs",
                LanguageBCP47.Ca => "ca",
                LanguageBCP47.Ceb => "ceb",
                LanguageBCP47.Cs => "cs",
                LanguageBCP47.Cy => "cy",
                LanguageBCP47.Da => "da",
                LanguageBCP47.De => "de",
                LanguageBCP47.DeAt => "de-AT",
                LanguageBCP47.DeCh => "de-CH",
                LanguageBCP47.DeDe => "de-DE",
                LanguageBCP47.El => "el",
                LanguageBCP47.En => "en",
                LanguageBCP47.EnAu => "en-AU",
                LanguageBCP47.EnCa => "en-CA",
                LanguageBCP47.EnGb => "en-GB",
                LanguageBCP47.EnHk => "en-HK",
                LanguageBCP47.EnIe => "en-IE",
                LanguageBCP47.EnIn => "en-IN",
                LanguageBCP47.EnKe => "en-KE",
                LanguageBCP47.EnMx => "en-MX",
                LanguageBCP47.EnNg => "en-NG",
                LanguageBCP47.EnNz => "en-NZ",
                LanguageBCP47.EnPh => "en-PH",
                LanguageBCP47.EnSg => "en-SG",
                LanguageBCP47.EnTz => "en-TZ",
                LanguageBCP47.EnUs => "en-US",
                LanguageBCP47.EnZa => "en-ZA",
                LanguageBCP47.Es => "es",
                LanguageBCP47.EsAr => "es-AR",
                LanguageBCP47.EsBo => "es-BO",
                LanguageBCP47.EsCl => "es-CL",
                LanguageBCP47.EsCo => "es-CO",
                LanguageBCP47.EsCr => "es-CR",
                LanguageBCP47.EsCu => "es-CU",
                LanguageBCP47.EsDo => "es-DO",
                LanguageBCP47.EsEc => "es-EC",
                LanguageBCP47.EsEs => "es-ES",
                LanguageBCP47.EsGq => "es-GQ",
                LanguageBCP47.EsGt => "es-GT",
                LanguageBCP47.EsHn => "es-HN",
                LanguageBCP47.EsLa => "es-LA",
                LanguageBCP47.EsMx => "es-MX",
                LanguageBCP47.EsNi => "es-NI",
                LanguageBCP47.EsPa => "es-PA",
                LanguageBCP47.EsPe => "es-PE",
                LanguageBCP47.EsPr => "es-PR",
                LanguageBCP47.EsPy => "es-PY",
                LanguageBCP47.EsSv => "es-SV",
                LanguageBCP47.EsUs => "es-US",
                LanguageBCP47.EsUy => "es-UY",
                LanguageBCP47.EsVe => "es-VE",
                LanguageBCP47.Et => "et",
                LanguageBCP47.Eu => "eu",
                LanguageBCP47.Fa => "fa",
                LanguageBCP47.Fi => "fi",
                LanguageBCP47.Fil => "fil",
                LanguageBCP47.Fo => "fo",
                LanguageBCP47.Fr => "fr",
                LanguageBCP47.FrBe => "fr-BE",
                LanguageBCP47.FrCa => "fr-CA",
                LanguageBCP47.FrCh => "fr-CH",
                LanguageBCP47.FrFr => "fr-FR",
                LanguageBCP47.Ga => "ga",
                LanguageBCP47.Gl => "gl",
                LanguageBCP47.Gu => "gu",
                LanguageBCP47.Ha => "ha",
                LanguageBCP47.Haw => "haw",
                LanguageBCP47.He => "he",
                LanguageBCP47.Hi => "hi",
                LanguageBCP47.Hr => "hr",
                LanguageBCP47.Ht => "ht",
                LanguageBCP47.Hu => "hu",
                LanguageBCP47.Hy => "hy",
                LanguageBCP47.Id => "id",
                LanguageBCP47.Is => "is",
                LanguageBCP47.It => "it",
                LanguageBCP47.Ja => "ja",
                LanguageBCP47.Jw => "jw",
                LanguageBCP47.Ka => "ka",
                LanguageBCP47.Kk => "kk",
                LanguageBCP47.Km => "km",
                LanguageBCP47.Kn => "kn",
                LanguageBCP47.Ko => "ko",
                LanguageBCP47.Ky => "ky",
                LanguageBCP47.La => "la",
                LanguageBCP47.Lb => "lb",
                LanguageBCP47.Ln => "ln",
                LanguageBCP47.Lo => "lo",
                LanguageBCP47.Lt => "lt",
                LanguageBCP47.Lv => "lv",
                LanguageBCP47.Mg => "mg",
                LanguageBCP47.Mi => "mi",
                LanguageBCP47.Mk => "mk",
                LanguageBCP47.Ml => "ml",
                LanguageBCP47.Mn => "mn",
                LanguageBCP47.Mr => "mr",
                LanguageBCP47.Ms => "ms",
                LanguageBCP47.Mt => "mt",
                LanguageBCP47.My => "my",
                LanguageBCP47.Nb => "nb",
                LanguageBCP47.Ne => "ne",
                LanguageBCP47.Nl => "nl",
                LanguageBCP47.NlBe => "nl-BE",
                LanguageBCP47.NlNl => "nl-NL",
                LanguageBCP47.Nn => "nn",
                LanguageBCP47.No => "no",
                LanguageBCP47.Ny => "ny",
                LanguageBCP47.Oc => "oc",
                LanguageBCP47.Or => "or",
                LanguageBCP47.Pa => "pa",
                LanguageBCP47.Pl => "pl",
                LanguageBCP47.Ps => "ps",
                LanguageBCP47.Pt => "pt",
                LanguageBCP47.PtBr => "pt-BR",
                LanguageBCP47.PtPt => "pt-PT",
                LanguageBCP47.Ro => "ro",
                LanguageBCP47.Ru => "ru",
                LanguageBCP47.Sa => "sa",
                LanguageBCP47.Sd => "sd",
                LanguageBCP47.Si => "si",
                LanguageBCP47.Sk => "sk",
                LanguageBCP47.Sl => "sl",
                LanguageBCP47.Sn => "sn",
                LanguageBCP47.So => "so",
                LanguageBCP47.Sq => "sq",
                LanguageBCP47.Sr => "sr",
                LanguageBCP47.Su => "su",
                LanguageBCP47.Sv => "sv",
                LanguageBCP47.Sw => "sw",
                LanguageBCP47.Ta => "ta",
                LanguageBCP47.TaIn => "ta-IN",
                LanguageBCP47.TaLk => "ta-LK",
                LanguageBCP47.TaSg => "ta-SG",
                LanguageBCP47.Te => "te",
                LanguageBCP47.Tg => "tg",
                LanguageBCP47.Th => "th",
                LanguageBCP47.Tk => "tk",
                LanguageBCP47.Tl => "tl",
                LanguageBCP47.Tr => "tr",
                LanguageBCP47.Tt => "tt",
                LanguageBCP47.Uk => "uk",
                LanguageBCP47.Und => "und",
                LanguageBCP47.Ur => "ur",
                LanguageBCP47.Uz => "uz",
                LanguageBCP47.Vi => "vi",
                LanguageBCP47.Yi => "yi",
                LanguageBCP47.Yo => "yo",
                LanguageBCP47.Zh => "zh",
                LanguageBCP47.ZhCn => "zh-CN",
                LanguageBCP47.ZhHk => "zh-HK",
                LanguageBCP47.ZhTw => "zh-TW",
                LanguageBCP47.Zu => "zu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageBCP47? ToEnum(string value)
        {
            return value switch
            {
                "af" => LanguageBCP47.Af,
                "am" => LanguageBCP47.Am,
                "ar" => LanguageBCP47.Ar,
                "ar-AE" => LanguageBCP47.ArAe,
                "ar-BH" => LanguageBCP47.ArBh,
                "ar-DZ" => LanguageBCP47.ArDz,
                "ar-EG" => LanguageBCP47.ArEg,
                "ar-IQ" => LanguageBCP47.ArIq,
                "ar-JO" => LanguageBCP47.ArJo,
                "ar-KW" => LanguageBCP47.ArKw,
                "ar-LY" => LanguageBCP47.ArLy,
                "ar-MA" => LanguageBCP47.ArMa,
                "ar-QA" => LanguageBCP47.ArQa,
                "ar-SA" => LanguageBCP47.ArSa,
                "ar-SY" => LanguageBCP47.ArSy,
                "ar-TN" => LanguageBCP47.ArTn,
                "ar-YE" => LanguageBCP47.ArYe,
                "as" => LanguageBCP47.As,
                "az" => LanguageBCP47.Az,
                "ba" => LanguageBCP47.Ba,
                "be" => LanguageBCP47.Be,
                "bg" => LanguageBCP47.Bg,
                "bn" => LanguageBCP47.Bn,
                "bo" => LanguageBCP47.Bo,
                "br" => LanguageBCP47.Br,
                "bs" => LanguageBCP47.Bs,
                "ca" => LanguageBCP47.Ca,
                "ceb" => LanguageBCP47.Ceb,
                "cs" => LanguageBCP47.Cs,
                "cy" => LanguageBCP47.Cy,
                "da" => LanguageBCP47.Da,
                "de" => LanguageBCP47.De,
                "de-AT" => LanguageBCP47.DeAt,
                "de-CH" => LanguageBCP47.DeCh,
                "de-DE" => LanguageBCP47.DeDe,
                "el" => LanguageBCP47.El,
                "en" => LanguageBCP47.En,
                "en-AU" => LanguageBCP47.EnAu,
                "en-CA" => LanguageBCP47.EnCa,
                "en-GB" => LanguageBCP47.EnGb,
                "en-HK" => LanguageBCP47.EnHk,
                "en-IE" => LanguageBCP47.EnIe,
                "en-IN" => LanguageBCP47.EnIn,
                "en-KE" => LanguageBCP47.EnKe,
                "en-MX" => LanguageBCP47.EnMx,
                "en-NG" => LanguageBCP47.EnNg,
                "en-NZ" => LanguageBCP47.EnNz,
                "en-PH" => LanguageBCP47.EnPh,
                "en-SG" => LanguageBCP47.EnSg,
                "en-TZ" => LanguageBCP47.EnTz,
                "en-US" => LanguageBCP47.EnUs,
                "en-ZA" => LanguageBCP47.EnZa,
                "es" => LanguageBCP47.Es,
                "es-AR" => LanguageBCP47.EsAr,
                "es-BO" => LanguageBCP47.EsBo,
                "es-CL" => LanguageBCP47.EsCl,
                "es-CO" => LanguageBCP47.EsCo,
                "es-CR" => LanguageBCP47.EsCr,
                "es-CU" => LanguageBCP47.EsCu,
                "es-DO" => LanguageBCP47.EsDo,
                "es-EC" => LanguageBCP47.EsEc,
                "es-ES" => LanguageBCP47.EsEs,
                "es-GQ" => LanguageBCP47.EsGq,
                "es-GT" => LanguageBCP47.EsGt,
                "es-HN" => LanguageBCP47.EsHn,
                "es-LA" => LanguageBCP47.EsLa,
                "es-MX" => LanguageBCP47.EsMx,
                "es-NI" => LanguageBCP47.EsNi,
                "es-PA" => LanguageBCP47.EsPa,
                "es-PE" => LanguageBCP47.EsPe,
                "es-PR" => LanguageBCP47.EsPr,
                "es-PY" => LanguageBCP47.EsPy,
                "es-SV" => LanguageBCP47.EsSv,
                "es-US" => LanguageBCP47.EsUs,
                "es-UY" => LanguageBCP47.EsUy,
                "es-VE" => LanguageBCP47.EsVe,
                "et" => LanguageBCP47.Et,
                "eu" => LanguageBCP47.Eu,
                "fa" => LanguageBCP47.Fa,
                "fi" => LanguageBCP47.Fi,
                "fil" => LanguageBCP47.Fil,
                "fo" => LanguageBCP47.Fo,
                "fr" => LanguageBCP47.Fr,
                "fr-BE" => LanguageBCP47.FrBe,
                "fr-CA" => LanguageBCP47.FrCa,
                "fr-CH" => LanguageBCP47.FrCh,
                "fr-FR" => LanguageBCP47.FrFr,
                "ga" => LanguageBCP47.Ga,
                "gl" => LanguageBCP47.Gl,
                "gu" => LanguageBCP47.Gu,
                "ha" => LanguageBCP47.Ha,
                "haw" => LanguageBCP47.Haw,
                "he" => LanguageBCP47.He,
                "hi" => LanguageBCP47.Hi,
                "hr" => LanguageBCP47.Hr,
                "ht" => LanguageBCP47.Ht,
                "hu" => LanguageBCP47.Hu,
                "hy" => LanguageBCP47.Hy,
                "id" => LanguageBCP47.Id,
                "is" => LanguageBCP47.Is,
                "it" => LanguageBCP47.It,
                "ja" => LanguageBCP47.Ja,
                "jw" => LanguageBCP47.Jw,
                "ka" => LanguageBCP47.Ka,
                "kk" => LanguageBCP47.Kk,
                "km" => LanguageBCP47.Km,
                "kn" => LanguageBCP47.Kn,
                "ko" => LanguageBCP47.Ko,
                "ky" => LanguageBCP47.Ky,
                "la" => LanguageBCP47.La,
                "lb" => LanguageBCP47.Lb,
                "ln" => LanguageBCP47.Ln,
                "lo" => LanguageBCP47.Lo,
                "lt" => LanguageBCP47.Lt,
                "lv" => LanguageBCP47.Lv,
                "mg" => LanguageBCP47.Mg,
                "mi" => LanguageBCP47.Mi,
                "mk" => LanguageBCP47.Mk,
                "ml" => LanguageBCP47.Ml,
                "mn" => LanguageBCP47.Mn,
                "mr" => LanguageBCP47.Mr,
                "ms" => LanguageBCP47.Ms,
                "mt" => LanguageBCP47.Mt,
                "my" => LanguageBCP47.My,
                "nb" => LanguageBCP47.Nb,
                "ne" => LanguageBCP47.Ne,
                "nl" => LanguageBCP47.Nl,
                "nl-BE" => LanguageBCP47.NlBe,
                "nl-NL" => LanguageBCP47.NlNl,
                "nn" => LanguageBCP47.Nn,
                "no" => LanguageBCP47.No,
                "ny" => LanguageBCP47.Ny,
                "oc" => LanguageBCP47.Oc,
                "or" => LanguageBCP47.Or,
                "pa" => LanguageBCP47.Pa,
                "pl" => LanguageBCP47.Pl,
                "ps" => LanguageBCP47.Ps,
                "pt" => LanguageBCP47.Pt,
                "pt-BR" => LanguageBCP47.PtBr,
                "pt-PT" => LanguageBCP47.PtPt,
                "ro" => LanguageBCP47.Ro,
                "ru" => LanguageBCP47.Ru,
                "sa" => LanguageBCP47.Sa,
                "sd" => LanguageBCP47.Sd,
                "si" => LanguageBCP47.Si,
                "sk" => LanguageBCP47.Sk,
                "sl" => LanguageBCP47.Sl,
                "sn" => LanguageBCP47.Sn,
                "so" => LanguageBCP47.So,
                "sq" => LanguageBCP47.Sq,
                "sr" => LanguageBCP47.Sr,
                "su" => LanguageBCP47.Su,
                "sv" => LanguageBCP47.Sv,
                "sw" => LanguageBCP47.Sw,
                "ta" => LanguageBCP47.Ta,
                "ta-IN" => LanguageBCP47.TaIn,
                "ta-LK" => LanguageBCP47.TaLk,
                "ta-SG" => LanguageBCP47.TaSg,
                "te" => LanguageBCP47.Te,
                "tg" => LanguageBCP47.Tg,
                "th" => LanguageBCP47.Th,
                "tk" => LanguageBCP47.Tk,
                "tl" => LanguageBCP47.Tl,
                "tr" => LanguageBCP47.Tr,
                "tt" => LanguageBCP47.Tt,
                "uk" => LanguageBCP47.Uk,
                "und" => LanguageBCP47.Und,
                "ur" => LanguageBCP47.Ur,
                "uz" => LanguageBCP47.Uz,
                "vi" => LanguageBCP47.Vi,
                "yi" => LanguageBCP47.Yi,
                "yo" => LanguageBCP47.Yo,
                "zh" => LanguageBCP47.Zh,
                "zh-CN" => LanguageBCP47.ZhCn,
                "zh-HK" => LanguageBCP47.ZhHk,
                "zh-TW" => LanguageBCP47.ZhTw,
                "zu" => LanguageBCP47.Zu,
                _ => null,
            };
        }
    }
}