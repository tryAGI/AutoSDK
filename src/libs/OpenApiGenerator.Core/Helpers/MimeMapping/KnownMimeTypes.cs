// MIT: https://github.com/zone117x/MimeMapping

#pragma warning disable CA1707
#pragma warning disable CA1034

using System;

namespace MimeMapping
{
    ///<summary>
    /// MIME type constants. Last updated on 2024-02-09T08:54:35Z. 
    /// Generated from the <a href="https://raw.githubusercontent.com/jshttp/mime-db/v1.52.0/db.json">mime-db</a> source
    ///</summary>
    public static class KnownMimeTypes
    {

        // Dupe for asc: using application/pgp-keys vs application/pgp-signature 
        // Dupe for mpp: using application/dash-patch+xml vs application/vnd.ms-project 
        // Dupe for ac: using application/pkix-attr-cert vs application/vnd.nokia.n-gage.ac+xml 
        // Dupe for dmg: using application/octet-stream vs application/x-apple-diskimage 
        // Dupe for bdoc: using application/bdoc vs application/x-bdoc 
        // Dupe for deb: using application/octet-stream vs application/x-debian-package 
        // Dupe for iso: using application/octet-stream vs application/x-iso9660-image 
        // Dupe for key: using application/vnd.apple.keynote vs application/x-iwork-keynote-sffkey 
        // Dupe for numbers: using application/vnd.apple.numbers vs application/x-iwork-numbers-sffnumbers 
        // Dupe for pages: using application/vnd.apple.pages vs application/x-iwork-pages-sffpages 
        // Dupe for exe: using application/octet-stream vs application/x-msdos-program 
        // Dupe for exe: using application/octet-stream vs application/x-msdownload 
        // Dupe for dll: using application/octet-stream vs application/x-msdownload 
        // Dupe for msi: using application/octet-stream vs application/x-msdownload 
        // Dupe for wmz: using application/x-ms-wmz vs application/x-msmetafile 
        // Dupe for prc: using application/x-mobipocket-ebook vs application/x-pilot 
        // Dupe for pdb: using application/vnd.palm vs application/x-pilot 
        // Dupe for rar: using application/vnd.rar vs application/x-rar-compressed 
        // Dupe for xlf: using application/x-xliff+xml vs application/xliff+xml 
        // Dupe for xsl: using application/xml vs application/xslt+xml 
        // Dupe for mp3: using audio/mp3 vs audio/mpeg 
        // Dupe for wav: using audio/wav vs audio/wave 
        // Dupe for m4a: using audio/mp4 vs audio/x-m4a 
        // Dupe for ra: using audio/x-pn-realaudio vs audio/x-realaudio 
        // Dupe for wav: using audio/wav vs audio/x-wav 
        // Dupe for emf: using application/x-msmetafile vs image/emf 
        // Dupe for wmf: using application/x-msmetafile vs image/wmf 
        // Dupe for ico: using image/vnd.microsoft.icon vs image/x-icon 
        // Dupe for bmp: using image/bmp vs image/x-ms-bmp 
        // Dupe for pcx: using image/vnd.zbrush.pcx vs image/x-pcx 
        // Dupe for obj: using application/x-tgif vs model/obj 
        // Dupe for stl: using application/vnd.ms-pki.stl vs model/stl 
        // Dupe for x3db: using model/x3d+binary vs model/x3d+fastinfoset 
        // Dupe for x3dv: using model/x3d+vrml vs model/x3d-vrml 
        // Dupe for rtf: using application/rtf vs text/rtf 
        // Dupe for sub: using image/vnd.dvb.subtitle vs text/vnd.dvb.subtitle 
        // Dupe for org: using application/vnd.lotus-organizer vs text/x-org 
        // Dupe for xml: using application/xml vs text/xml 
        // Dupe for 3gpp: using audio/3gpp vs video/3gpp 
        // Dupe for jpm: using image/jpm vs video/jpm 

        // Generated 937 unique mime type values
        // Generated 1180 type key pairs

        ///<summary>ez</summary>
        public const string Ez = "application/andrew-inset";
        ///<summary>aw</summary>
        public const string Aw = "application/applixware";
        ///<summary>atom</summary>
        public const string Atom = "application/atom+xml";
        ///<summary>atomcat</summary>
        public const string Atomcat = "application/atomcat+xml";
        ///<summary>atomdeleted</summary>
        public const string Atomdeleted = "application/atomdeleted+xml";
        ///<summary>atomsvc</summary>
        public const string Atomsvc = "application/atomsvc+xml";
        ///<summary>dwd</summary>
        public const string Dwd = "application/atsc-dwd+xml";
        ///<summary>held</summary>
        public const string Held = "application/atsc-held+xml";
        ///<summary>rsat</summary>
        public const string Rsat = "application/atsc-rsat+xml";
        ///<summary>bdoc</summary>
        public const string Bdoc = "application/bdoc";
        ///<summary>xcs</summary>
        public const string Xcs = "application/calendar+xml";
        ///<summary>ccxml</summary>
        public const string Ccxml = "application/ccxml+xml";
        ///<summary>cdfx</summary>
        public const string Cdfx = "application/cdfx+xml";
        ///<summary>cdmia</summary>
        public const string Cdmia = "application/cdmi-capability";
        ///<summary>cdmic</summary>
        public const string Cdmic = "application/cdmi-container";
        ///<summary>cdmid</summary>
        public const string Cdmid = "application/cdmi-domain";
        ///<summary>cdmio</summary>
        public const string Cdmio = "application/cdmi-object";
        ///<summary>cdmiq</summary>
        public const string Cdmiq = "application/cdmi-queue";
        ///<summary>cpl</summary>
        public const string Cpl = "application/cpl+xml";
        ///<summary>cu</summary>
        public const string Cu = "application/cu-seeme";
        ///<summary>mpd</summary>
        public const string Mpd = "application/dash+xml";
        ///<summary>mpp</summary>
        public const string Mpp = "application/dash-patch+xml";
        ///<summary>davmount</summary>
        public const string Davmount = "application/davmount+xml";
        ///<summary>dbk</summary>
        public const string Dbk = "application/docbook+xml";
        ///<summary>dssc</summary>
        public const string Dssc = "application/dssc+der";
        ///<summary>xdssc</summary>
        public const string Xdssc = "application/dssc+xml";
        ///<summary>es</summary>
        public const string Es = "application/ecmascript";
        ///<summary>ecma</summary>
        public const string Ecma = "application/ecmascript";
        ///<summary>emma</summary>
        public const string Emma = "application/emma+xml";
        ///<summary>emotionml</summary>
        public const string Emotionml = "application/emotionml+xml";
        ///<summary>epub</summary>
        public const string Epub = "application/epub+zip";
        ///<summary>exi</summary>
        public const string Exi = "application/exi";
        ///<summary>exp</summary>
        public const string Exp = "application/express";
        ///<summary>fdt</summary>
        public const string Fdt = "application/fdt+xml";
        ///<summary>pfr</summary>
        public const string Pfr = "application/font-tdpfr";
        ///<summary>geojson</summary>
        public const string Geojson = "application/geo+json";
        ///<summary>gml</summary>
        public const string Gml = "application/gml+xml";
        ///<summary>gpx</summary>
        public const string Gpx = "application/gpx+xml";
        ///<summary>gxf</summary>
        public const string Gxf = "application/gxf";
        ///<summary>gz</summary>
        public const string Gz = "application/gzip";
        ///<summary>hjson</summary>
        public const string Hjson = "application/hjson";
        ///<summary>stk</summary>
        public const string Stk = "application/hyperstudio";
        ///<summary>ink</summary>
        public const string Ink = "application/inkml+xml";
        ///<summary>inkml</summary>
        public const string Inkml = "application/inkml+xml";
        ///<summary>ipfix</summary>
        public const string Ipfix = "application/ipfix";
        ///<summary>its</summary>
        public const string Its = "application/its+xml";
        ///<summary>jar</summary>
        public const string Jar = "application/java-archive";
        ///<summary>war</summary>
        public const string War = "application/java-archive";
        ///<summary>ear</summary>
        public const string Ear = "application/java-archive";
        ///<summary>ser</summary>
        public const string Ser = "application/java-serialized-object";
        ///<summary>class</summary>
        public const string Class = "application/java-vm";
        ///<summary>js</summary>
        public const string Js = "application/javascript";
        ///<summary>mjs</summary>
        public const string Mjs = "application/javascript";
        ///<summary>json</summary>
        public const string Json = "application/json";
        ///<summary>map</summary>
        public const string Map = "application/json";
        ///<summary>json5</summary>
        public const string Json5 = "application/json5";
        ///<summary>jsonml</summary>
        public const string Jsonml = "application/jsonml+json";
        ///<summary>jsonld</summary>
        public const string Jsonld = "application/ld+json";
        ///<summary>lgr</summary>
        public const string Lgr = "application/lgr+xml";
        ///<summary>lostxml</summary>
        public const string Lostxml = "application/lost+xml";
        ///<summary>hqx</summary>
        public const string Hqx = "application/mac-binhex40";
        ///<summary>cpt</summary>
        public const string Cpt = "application/mac-compactpro";
        ///<summary>mads</summary>
        public const string Mads = "application/mads+xml";
        ///<summary>webmanifest</summary>
        public const string Webmanifest = "application/manifest+json";
        ///<summary>mrc</summary>
        public const string Mrc = "application/marc";
        ///<summary>mrcx</summary>
        public const string Mrcx = "application/marcxml+xml";
        ///<summary>ma</summary>
        public const string Ma = "application/mathematica";
        ///<summary>nb</summary>
        public const string Nb = "application/mathematica";
        ///<summary>mb</summary>
        public const string Mb = "application/mathematica";
        ///<summary>mathml</summary>
        public const string Mathml = "application/mathml+xml";
        ///<summary>mbox</summary>
        public const string Mbox = "application/mbox";
        ///<summary>mpf</summary>
        public const string Mpf = "application/media-policy-dataset+xml";
        ///<summary>mscml</summary>
        public const string Mscml = "application/mediaservercontrol+xml";
        ///<summary>metalink</summary>
        public const string Metalink = "application/metalink+xml";
        ///<summary>meta4</summary>
        public const string Meta4 = "application/metalink4+xml";
        ///<summary>mets</summary>
        public const string Mets = "application/mets+xml";
        ///<summary>maei</summary>
        public const string Maei = "application/mmt-aei+xml";
        ///<summary>musd</summary>
        public const string Musd = "application/mmt-usd+xml";
        ///<summary>mods</summary>
        public const string Mods = "application/mods+xml";
        ///<summary>m21</summary>
        public const string M21 = "application/mp21";
        ///<summary>mp21</summary>
        public const string Mp21 = "application/mp21";
        ///<summary>mp4s</summary>
        public const string Mp4s = "application/mp4";
        ///<summary>m4p</summary>
        public const string M4p = "application/mp4";
        ///<summary>doc</summary>
        public const string Doc = "application/msword";
        ///<summary>dot</summary>
        public const string Dot = "application/msword";
        ///<summary>mxf</summary>
        public const string Mxf = "application/mxf";
        ///<summary>nq</summary>
        public const string Nq = "application/n-quads";
        ///<summary>nt</summary>
        public const string Nt = "application/n-triples";
        ///<summary>cjs</summary>
        public const string Cjs = "application/node";
        ///<summary>bin</summary>
        public const string Bin = "application/octet-stream";
        ///<summary>dms</summary>
        public const string Dms = "application/octet-stream";
        ///<summary>lrf</summary>
        public const string Lrf = "application/octet-stream";
        ///<summary>mar</summary>
        public const string Mar = "application/octet-stream";
        ///<summary>so</summary>
        public const string So = "application/octet-stream";
        ///<summary>dist</summary>
        public const string Dist = "application/octet-stream";
        ///<summary>distz</summary>
        public const string Distz = "application/octet-stream";
        ///<summary>pkg</summary>
        public const string Pkg = "application/octet-stream";
        ///<summary>bpk</summary>
        public const string Bpk = "application/octet-stream";
        ///<summary>dump</summary>
        public const string Dump = "application/octet-stream";
        ///<summary>elc</summary>
        public const string Elc = "application/octet-stream";
        ///<summary>deploy</summary>
        public const string Deploy = "application/octet-stream";
        ///<summary>exe</summary>
        public const string Exe = "application/octet-stream";
        ///<summary>dll</summary>
        public const string Dll = "application/octet-stream";
        ///<summary>deb</summary>
        public const string Deb = "application/octet-stream";
        ///<summary>dmg</summary>
        public const string Dmg = "application/octet-stream";
        ///<summary>iso</summary>
        public const string Iso = "application/octet-stream";
        ///<summary>img</summary>
        public const string Img = "application/octet-stream";
        ///<summary>msi</summary>
        public const string Msi = "application/octet-stream";
        ///<summary>msp</summary>
        public const string Msp = "application/octet-stream";
        ///<summary>msm</summary>
        public const string Msm = "application/octet-stream";
        ///<summary>buffer</summary>
        public const string Buffer = "application/octet-stream";
        ///<summary>oda</summary>
        public const string Oda = "application/oda";
        ///<summary>opf</summary>
        public const string Opf = "application/oebps-package+xml";
        ///<summary>ogx</summary>
        public const string Ogx = "application/ogg";
        ///<summary>omdoc</summary>
        public const string Omdoc = "application/omdoc+xml";
        ///<summary>onetoc</summary>
        public const string Onetoc = "application/onenote";
        ///<summary>onetoc2</summary>
        public const string Onetoc2 = "application/onenote";
        ///<summary>onetmp</summary>
        public const string Onetmp = "application/onenote";
        ///<summary>onepkg</summary>
        public const string Onepkg = "application/onenote";
        ///<summary>oxps</summary>
        public const string Oxps = "application/oxps";
        ///<summary>relo</summary>
        public const string Relo = "application/p2p-overlay+xml";
        ///<summary>xer</summary>
        public const string Xer = "application/patch-ops-error+xml";
        ///<summary>pdf</summary>
        public const string Pdf = "application/pdf";
        ///<summary>pgp</summary>
        public const string Pgp = "application/pgp-encrypted";
        ///<summary>asc</summary>
        public const string Asc = "application/pgp-keys";
        ///<summary>sig</summary>
        public const string Sig = "application/pgp-signature";
        ///<summary>prf</summary>
        public const string Prf = "application/pics-rules";
        ///<summary>p10</summary>
        public const string P10 = "application/pkcs10";
        ///<summary>p7m</summary>
        public const string P7m = "application/pkcs7-mime";
        ///<summary>p7c</summary>
        public const string P7c = "application/pkcs7-mime";
        ///<summary>p7s</summary>
        public const string P7s = "application/pkcs7-signature";
        ///<summary>p8</summary>
        public const string P8 = "application/pkcs8";
        ///<summary>ac</summary>
        public const string Ac = "application/pkix-attr-cert";
        ///<summary>cer</summary>
        public const string Cer = "application/pkix-cert";
        ///<summary>crl</summary>
        public const string Crl = "application/pkix-crl";
        ///<summary>pkipath</summary>
        public const string Pkipath = "application/pkix-pkipath";
        ///<summary>pki</summary>
        public const string Pki = "application/pkixcmp";
        ///<summary>pls</summary>
        public const string Pls = "application/pls+xml";
        ///<summary>ai</summary>
        public const string Ai = "application/postscript";
        ///<summary>eps</summary>
        public const string Eps = "application/postscript";
        ///<summary>ps</summary>
        public const string Ps = "application/postscript";
        ///<summary>provx</summary>
        public const string Provx = "application/provenance+xml";
        ///<summary>cww</summary>
        public const string Cww = "application/prs.cww";
        ///<summary>pskcxml</summary>
        public const string Pskcxml = "application/pskc+xml";
        ///<summary>raml</summary>
        public const string Raml = "application/raml+yaml";
        ///<summary>rdf</summary>
        public const string Rdf = "application/rdf+xml";
        ///<summary>owl</summary>
        public const string Owl = "application/rdf+xml";
        ///<summary>rif</summary>
        public const string Rif = "application/reginfo+xml";
        ///<summary>rnc</summary>
        public const string Rnc = "application/relax-ng-compact-syntax";
        ///<summary>rl</summary>
        public const string Rl = "application/resource-lists+xml";
        ///<summary>rld</summary>
        public const string Rld = "application/resource-lists-diff+xml";
        ///<summary>rs</summary>
        public const string Rs = "application/rls-services+xml";
        ///<summary>rapd</summary>
        public const string Rapd = "application/route-apd+xml";
        ///<summary>sls</summary>
        public const string Sls = "application/route-s-tsid+xml";
        ///<summary>rusd</summary>
        public const string Rusd = "application/route-usd+xml";
        ///<summary>gbr</summary>
        public const string Gbr = "application/rpki-ghostbusters";
        ///<summary>mft</summary>
        public const string Mft = "application/rpki-manifest";
        ///<summary>roa</summary>
        public const string Roa = "application/rpki-roa";
        ///<summary>rsd</summary>
        public const string Rsd = "application/rsd+xml";
        ///<summary>rss</summary>
        public const string Rss = "application/rss+xml";
        ///<summary>rtf</summary>
        public const string Rtf = "application/rtf";
        ///<summary>sbml</summary>
        public const string Sbml = "application/sbml+xml";
        ///<summary>scq</summary>
        public const string Scq = "application/scvp-cv-request";
        ///<summary>scs</summary>
        public const string Scs = "application/scvp-cv-response";
        ///<summary>spq</summary>
        public const string Spq = "application/scvp-vp-request";
        ///<summary>spp</summary>
        public const string Spp = "application/scvp-vp-response";
        ///<summary>sdp</summary>
        public const string Sdp = "application/sdp";
        ///<summary>senmlx</summary>
        public const string Senmlx = "application/senml+xml";
        ///<summary>sensmlx</summary>
        public const string Sensmlx = "application/sensml+xml";
        ///<summary>setpay</summary>
        public const string Setpay = "application/set-payment-initiation";
        ///<summary>setreg</summary>
        public const string Setreg = "application/set-registration-initiation";
        ///<summary>shf</summary>
        public const string Shf = "application/shf+xml";
        ///<summary>siv</summary>
        public const string Siv = "application/sieve";
        ///<summary>sieve</summary>
        public const string Sieve = "application/sieve";
        ///<summary>smi</summary>
        public const string Smi = "application/smil+xml";
        ///<summary>smil</summary>
        public const string Smil = "application/smil+xml";
        ///<summary>rq</summary>
        public const string Rq = "application/sparql-query";
        ///<summary>srx</summary>
        public const string Srx = "application/sparql-results+xml";
        ///<summary>gram</summary>
        public const string Gram = "application/srgs";
        ///<summary>grxml</summary>
        public const string Grxml = "application/srgs+xml";
        ///<summary>sru</summary>
        public const string Sru = "application/sru+xml";
        ///<summary>ssdl</summary>
        public const string Ssdl = "application/ssdl+xml";
        ///<summary>ssml</summary>
        public const string Ssml = "application/ssml+xml";
        ///<summary>swidtag</summary>
        public const string Swidtag = "application/swid+xml";
        ///<summary>tei</summary>
        public const string Tei = "application/tei+xml";
        ///<summary>teicorpus</summary>
        public const string Teicorpus = "application/tei+xml";
        ///<summary>tfi</summary>
        public const string Tfi = "application/thraud+xml";
        ///<summary>tsd</summary>
        public const string Tsd = "application/timestamped-data";
        ///<summary>toml</summary>
        public const string Toml = "application/toml";
        ///<summary>trig</summary>
        public const string Trig = "application/trig";
        ///<summary>ttml</summary>
        public const string Ttml = "application/ttml+xml";
        ///<summary>ubj</summary>
        public const string Ubj = "application/ubjson";
        ///<summary>rsheet</summary>
        public const string Rsheet = "application/urc-ressheet+xml";
        ///<summary>td</summary>
        public const string Td = "application/urc-targetdesc+xml";
        ///<summary>1km</summary>
        public const string _1km = "application/vnd.1000minds.decision-model+xml";
        ///<summary>plb</summary>
        public const string Plb = "application/vnd.3gpp.pic-bw-large";
        ///<summary>psb</summary>
        public const string Psb = "application/vnd.3gpp.pic-bw-small";
        ///<summary>pvb</summary>
        public const string Pvb = "application/vnd.3gpp.pic-bw-var";
        ///<summary>tcap</summary>
        public const string Tcap = "application/vnd.3gpp2.tcap";
        ///<summary>pwn</summary>
        public const string Pwn = "application/vnd.3m.post-it-notes";
        ///<summary>aso</summary>
        public const string Aso = "application/vnd.accpac.simply.aso";
        ///<summary>imp</summary>
        public const string Imp = "application/vnd.accpac.simply.imp";
        ///<summary>acu</summary>
        public const string Acu = "application/vnd.acucobol";
        ///<summary>atc</summary>
        public const string Atc = "application/vnd.acucorp";
        ///<summary>acutc</summary>
        public const string Acutc = "application/vnd.acucorp";
        ///<summary>air</summary>
        public const string Air = "application/vnd.adobe.air-application-installer-package+zip";
        ///<summary>fcdt</summary>
        public const string Fcdt = "application/vnd.adobe.formscentral.fcdt";
        ///<summary>fxp</summary>
        public const string Fxp = "application/vnd.adobe.fxp";
        ///<summary>fxpl</summary>
        public const string Fxpl = "application/vnd.adobe.fxp";
        ///<summary>xdp</summary>
        public const string Xdp = "application/vnd.adobe.xdp+xml";
        ///<summary>xfdf</summary>
        public const string Xfdf = "application/vnd.adobe.xfdf";
        ///<summary>age</summary>
        public const string Age = "application/vnd.age";
        ///<summary>ahead</summary>
        public const string Ahead = "application/vnd.ahead.space";
        ///<summary>azf</summary>
        public const string Azf = "application/vnd.airzip.filesecure.azf";
        ///<summary>azs</summary>
        public const string Azs = "application/vnd.airzip.filesecure.azs";
        ///<summary>azw</summary>
        public const string Azw = "application/vnd.amazon.ebook";
        ///<summary>acc</summary>
        public const string Acc = "application/vnd.americandynamics.acc";
        ///<summary>ami</summary>
        public const string Ami = "application/vnd.amiga.ami";
        ///<summary>apk</summary>
        public const string Apk = "application/vnd.android.package-archive";
        ///<summary>cii</summary>
        public const string Cii = "application/vnd.anser-web-certificate-issue-initiation";
        ///<summary>fti</summary>
        public const string Fti = "application/vnd.anser-web-funds-transfer-initiation";
        ///<summary>atx</summary>
        public const string Atx = "application/vnd.antix.game-component";
        ///<summary>mpkg</summary>
        public const string Mpkg = "application/vnd.apple.installer+xml";
        ///<summary>key</summary>
        public const string Key = "application/vnd.apple.keynote";
        ///<summary>m3u8</summary>
        public const string M3u8 = "application/vnd.apple.mpegurl";
        ///<summary>numbers</summary>
        public const string Numbers = "application/vnd.apple.numbers";
        ///<summary>pages</summary>
        public const string Pages = "application/vnd.apple.pages";
        ///<summary>pkpass</summary>
        public const string Pkpass = "application/vnd.apple.pkpass";
        ///<summary>swi</summary>
        public const string Swi = "application/vnd.aristanetworks.swi";
        ///<summary>iota</summary>
        public const string Iota = "application/vnd.astraea-software.iota";
        ///<summary>aep</summary>
        public const string Aep = "application/vnd.audiograph";
        ///<summary>bmml</summary>
        public const string Bmml = "application/vnd.balsamiq.bmml+xml";
        ///<summary>mpm</summary>
        public const string Mpm = "application/vnd.blueice.multipass";
        ///<summary>bmi</summary>
        public const string Bmi = "application/vnd.bmi";
        ///<summary>rep</summary>
        public const string Rep = "application/vnd.businessobjects";
        ///<summary>cdxml</summary>
        public const string Cdxml = "application/vnd.chemdraw+xml";
        ///<summary>mmd</summary>
        public const string Mmd = "application/vnd.chipnuts.karaoke-mmd";
        ///<summary>cdy</summary>
        public const string Cdy = "application/vnd.cinderella";
        ///<summary>csl</summary>
        public const string Csl = "application/vnd.citationstyles.style+xml";
        ///<summary>cla</summary>
        public const string Cla = "application/vnd.claymore";
        ///<summary>rp9</summary>
        public const string Rp9 = "application/vnd.cloanto.rp9";
        ///<summary>c4g</summary>
        public const string C4g = "application/vnd.clonk.c4group";
        ///<summary>c4d</summary>
        public const string C4d = "application/vnd.clonk.c4group";
        ///<summary>c4f</summary>
        public const string C4f = "application/vnd.clonk.c4group";
        ///<summary>c4p</summary>
        public const string C4p = "application/vnd.clonk.c4group";
        ///<summary>c4u</summary>
        public const string C4u = "application/vnd.clonk.c4group";
        ///<summary>c11amc</summary>
        public const string C11amc = "application/vnd.cluetrust.cartomobile-config";
        ///<summary>c11amz</summary>
        public const string C11amz = "application/vnd.cluetrust.cartomobile-config-pkg";
        ///<summary>csp</summary>
        public const string Csp = "application/vnd.commonspace";
        ///<summary>cdbcmsg</summary>
        public const string Cdbcmsg = "application/vnd.contact.cmsg";
        ///<summary>cmc</summary>
        public const string Cmc = "application/vnd.cosmocaller";
        ///<summary>clkx</summary>
        public const string Clkx = "application/vnd.crick.clicker";
        ///<summary>clkk</summary>
        public const string Clkk = "application/vnd.crick.clicker.keyboard";
        ///<summary>clkp</summary>
        public const string Clkp = "application/vnd.crick.clicker.palette";
        ///<summary>clkt</summary>
        public const string Clkt = "application/vnd.crick.clicker.template";
        ///<summary>clkw</summary>
        public const string Clkw = "application/vnd.crick.clicker.wordbank";
        ///<summary>wbs</summary>
        public const string Wbs = "application/vnd.criticaltools.wbs+xml";
        ///<summary>pml</summary>
        public const string Pml = "application/vnd.ctc-posml";
        ///<summary>ppd</summary>
        public const string Ppd = "application/vnd.cups-ppd";
        ///<summary>car</summary>
        public const string Car = "application/vnd.curl.car";
        ///<summary>pcurl</summary>
        public const string Pcurl = "application/vnd.curl.pcurl";
        ///<summary>dart</summary>
        public const string Dart = "application/vnd.dart";
        ///<summary>rdz</summary>
        public const string Rdz = "application/vnd.data-vision.rdz";
        ///<summary>dbf</summary>
        public const string Dbf = "application/vnd.dbf";
        ///<summary>uvf</summary>
        public const string Uvf = "application/vnd.dece.data";
        ///<summary>uvvf</summary>
        public const string Uvvf = "application/vnd.dece.data";
        ///<summary>uvd</summary>
        public const string Uvd = "application/vnd.dece.data";
        ///<summary>uvvd</summary>
        public const string Uvvd = "application/vnd.dece.data";
        ///<summary>uvt</summary>
        public const string Uvt = "application/vnd.dece.ttml+xml";
        ///<summary>uvvt</summary>
        public const string Uvvt = "application/vnd.dece.ttml+xml";
        ///<summary>uvx</summary>
        public const string Uvx = "application/vnd.dece.unspecified";
        ///<summary>uvvx</summary>
        public const string Uvvx = "application/vnd.dece.unspecified";
        ///<summary>uvz</summary>
        public const string Uvz = "application/vnd.dece.zip";
        ///<summary>uvvz</summary>
        public const string Uvvz = "application/vnd.dece.zip";
        ///<summary>fe_launch</summary>
        public const string Felaunch = "application/vnd.denovo.fcselayout-link";
        ///<summary>dna</summary>
        public const string Dna = "application/vnd.dna";
        ///<summary>mlp</summary>
        public const string Mlp = "application/vnd.dolby.mlp";
        ///<summary>dpg</summary>
        public const string Dpg = "application/vnd.dpgraph";
        ///<summary>dfac</summary>
        public const string Dfac = "application/vnd.dreamfactory";
        ///<summary>kpxx</summary>
        public const string Kpxx = "application/vnd.ds-keypoint";
        ///<summary>ait</summary>
        public const string Ait = "application/vnd.dvb.ait";
        ///<summary>svc</summary>
        public const string Svc = "application/vnd.dvb.service";
        ///<summary>geo</summary>
        public const string Geo = "application/vnd.dynageo";
        ///<summary>mag</summary>
        public const string Mag = "application/vnd.ecowin.chart";
        ///<summary>nml</summary>
        public const string Nml = "application/vnd.enliven";
        ///<summary>esf</summary>
        public const string Esf = "application/vnd.epson.esf";
        ///<summary>msf</summary>
        public const string Msf = "application/vnd.epson.msf";
        ///<summary>qam</summary>
        public const string Qam = "application/vnd.epson.quickanime";
        ///<summary>slt</summary>
        public const string Slt = "application/vnd.epson.salt";
        ///<summary>ssf</summary>
        public const string Ssf = "application/vnd.epson.ssf";
        ///<summary>es3</summary>
        public const string Es3 = "application/vnd.eszigno3+xml";
        ///<summary>et3</summary>
        public const string Et3 = "application/vnd.eszigno3+xml";
        ///<summary>ez2</summary>
        public const string Ez2 = "application/vnd.ezpix-album";
        ///<summary>ez3</summary>
        public const string Ez3 = "application/vnd.ezpix-package";
        ///<summary>fdf</summary>
        public const string Fdf = "application/vnd.fdf";
        ///<summary>mseed</summary>
        public const string Mseed = "application/vnd.fdsn.mseed";
        ///<summary>seed</summary>
        public const string Seed = "application/vnd.fdsn.seed";
        ///<summary>dataless</summary>
        public const string Dataless = "application/vnd.fdsn.seed";
        ///<summary>gph</summary>
        public const string Gph = "application/vnd.flographit";
        ///<summary>ftc</summary>
        public const string Ftc = "application/vnd.fluxtime.clip";
        ///<summary>fm</summary>
        public const string Fm = "application/vnd.framemaker";
        ///<summary>frame</summary>
        public const string Frame = "application/vnd.framemaker";
        ///<summary>maker</summary>
        public const string Maker = "application/vnd.framemaker";
        ///<summary>book</summary>
        public const string Book = "application/vnd.framemaker";
        ///<summary>fnc</summary>
        public const string Fnc = "application/vnd.frogans.fnc";
        ///<summary>ltf</summary>
        public const string Ltf = "application/vnd.frogans.ltf";
        ///<summary>fsc</summary>
        public const string Fsc = "application/vnd.fsc.weblaunch";
        ///<summary>oas</summary>
        public const string Oas = "application/vnd.fujitsu.oasys";
        ///<summary>oa2</summary>
        public const string Oa2 = "application/vnd.fujitsu.oasys2";
        ///<summary>oa3</summary>
        public const string Oa3 = "application/vnd.fujitsu.oasys3";
        ///<summary>fg5</summary>
        public const string Fg5 = "application/vnd.fujitsu.oasysgp";
        ///<summary>bh2</summary>
        public const string Bh2 = "application/vnd.fujitsu.oasysprs";
        ///<summary>ddd</summary>
        public const string Ddd = "application/vnd.fujixerox.ddd";
        ///<summary>xdw</summary>
        public const string Xdw = "application/vnd.fujixerox.docuworks";
        ///<summary>xbd</summary>
        public const string Xbd = "application/vnd.fujixerox.docuworks.binder";
        ///<summary>fzs</summary>
        public const string Fzs = "application/vnd.fuzzysheet";
        ///<summary>txd</summary>
        public const string Txd = "application/vnd.genomatix.tuxedo";
        ///<summary>ggb</summary>
        public const string Ggb = "application/vnd.geogebra.file";
        ///<summary>ggt</summary>
        public const string Ggt = "application/vnd.geogebra.tool";
        ///<summary>gex</summary>
        public const string Gex = "application/vnd.geometry-explorer";
        ///<summary>gre</summary>
        public const string Gre = "application/vnd.geometry-explorer";
        ///<summary>gxt</summary>
        public const string Gxt = "application/vnd.geonext";
        ///<summary>g2w</summary>
        public const string G2w = "application/vnd.geoplan";
        ///<summary>g3w</summary>
        public const string G3w = "application/vnd.geospace";
        ///<summary>gmx</summary>
        public const string Gmx = "application/vnd.gmx";
        ///<summary>gdoc</summary>
        public const string Gdoc = "application/vnd.google-apps.document";
        ///<summary>gslides</summary>
        public const string Gslides = "application/vnd.google-apps.presentation";
        ///<summary>gsheet</summary>
        public const string Gsheet = "application/vnd.google-apps.spreadsheet";
        ///<summary>kml</summary>
        public const string Kml = "application/vnd.google-earth.kml+xml";
        ///<summary>kmz</summary>
        public const string Kmz = "application/vnd.google-earth.kmz";
        ///<summary>gqf</summary>
        public const string Gqf = "application/vnd.grafeq";
        ///<summary>gqs</summary>
        public const string Gqs = "application/vnd.grafeq";
        ///<summary>gac</summary>
        public const string Gac = "application/vnd.groove-account";
        ///<summary>ghf</summary>
        public const string Ghf = "application/vnd.groove-help";
        ///<summary>gim</summary>
        public const string Gim = "application/vnd.groove-identity-message";
        ///<summary>grv</summary>
        public const string Grv = "application/vnd.groove-injector";
        ///<summary>gtm</summary>
        public const string Gtm = "application/vnd.groove-tool-message";
        ///<summary>tpl</summary>
        public const string Tpl = "application/vnd.groove-tool-template";
        ///<summary>vcg</summary>
        public const string Vcg = "application/vnd.groove-vcard";
        ///<summary>hal</summary>
        public const string Hal = "application/vnd.hal+xml";
        ///<summary>zmm</summary>
        public const string Zmm = "application/vnd.handheld-entertainment+xml";
        ///<summary>hbci</summary>
        public const string Hbci = "application/vnd.hbci";
        ///<summary>les</summary>
        public const string Les = "application/vnd.hhe.lesson-player";
        ///<summary>hpgl</summary>
        public const string Hpgl = "application/vnd.hp-hpgl";
        ///<summary>hpid</summary>
        public const string Hpid = "application/vnd.hp-hpid";
        ///<summary>hps</summary>
        public const string Hps = "application/vnd.hp-hps";
        ///<summary>jlt</summary>
        public const string Jlt = "application/vnd.hp-jlyt";
        ///<summary>pcl</summary>
        public const string Pcl = "application/vnd.hp-pcl";
        ///<summary>pclxl</summary>
        public const string Pclxl = "application/vnd.hp-pclxl";
        ///<summary>sfd-hdstx</summary>
        public const string Sfdhdstx = "application/vnd.hydrostatix.sof-data";
        ///<summary>mpy</summary>
        public const string Mpy = "application/vnd.ibm.minipay";
        ///<summary>afp</summary>
        public const string Afp = "application/vnd.ibm.modcap";
        ///<summary>listafp</summary>
        public const string Listafp = "application/vnd.ibm.modcap";
        ///<summary>list3820</summary>
        public const string List3820 = "application/vnd.ibm.modcap";
        ///<summary>irm</summary>
        public const string Irm = "application/vnd.ibm.rights-management";
        ///<summary>sc</summary>
        public const string Sc = "application/vnd.ibm.secure-container";
        ///<summary>icc</summary>
        public const string Icc = "application/vnd.iccprofile";
        ///<summary>icm</summary>
        public const string Icm = "application/vnd.iccprofile";
        ///<summary>igl</summary>
        public const string Igl = "application/vnd.igloader";
        ///<summary>ivp</summary>
        public const string Ivp = "application/vnd.immervision-ivp";
        ///<summary>ivu</summary>
        public const string Ivu = "application/vnd.immervision-ivu";
        ///<summary>igm</summary>
        public const string Igm = "application/vnd.insors.igm";
        ///<summary>xpw</summary>
        public const string Xpw = "application/vnd.intercon.formnet";
        ///<summary>xpx</summary>
        public const string Xpx = "application/vnd.intercon.formnet";
        ///<summary>i2g</summary>
        public const string I2g = "application/vnd.intergeo";
        ///<summary>qbo</summary>
        public const string Qbo = "application/vnd.intu.qbo";
        ///<summary>qfx</summary>
        public const string Qfx = "application/vnd.intu.qfx";
        ///<summary>rcprofile</summary>
        public const string Rcprofile = "application/vnd.ipunplugged.rcprofile";
        ///<summary>irp</summary>
        public const string Irp = "application/vnd.irepository.package+xml";
        ///<summary>xpr</summary>
        public const string Xpr = "application/vnd.is-xpr";
        ///<summary>fcs</summary>
        public const string Fcs = "application/vnd.isac.fcs";
        ///<summary>jam</summary>
        public const string Jam = "application/vnd.jam";
        ///<summary>rms</summary>
        public const string Rms = "application/vnd.jcp.javame.midlet-rms";
        ///<summary>jisp</summary>
        public const string Jisp = "application/vnd.jisp";
        ///<summary>joda</summary>
        public const string Joda = "application/vnd.joost.joda-archive";
        ///<summary>ktz</summary>
        public const string Ktz = "application/vnd.kahootz";
        ///<summary>ktr</summary>
        public const string Ktr = "application/vnd.kahootz";
        ///<summary>karbon</summary>
        public const string Karbon = "application/vnd.kde.karbon";
        ///<summary>chrt</summary>
        public const string Chrt = "application/vnd.kde.kchart";
        ///<summary>kfo</summary>
        public const string Kfo = "application/vnd.kde.kformula";
        ///<summary>flw</summary>
        public const string Flw = "application/vnd.kde.kivio";
        ///<summary>kon</summary>
        public const string Kon = "application/vnd.kde.kontour";
        ///<summary>kpr</summary>
        public const string Kpr = "application/vnd.kde.kpresenter";
        ///<summary>kpt</summary>
        public const string Kpt = "application/vnd.kde.kpresenter";
        ///<summary>ksp</summary>
        public const string Ksp = "application/vnd.kde.kspread";
        ///<summary>kwd</summary>
        public const string Kwd = "application/vnd.kde.kword";
        ///<summary>kwt</summary>
        public const string Kwt = "application/vnd.kde.kword";
        ///<summary>htke</summary>
        public const string Htke = "application/vnd.kenameaapp";
        ///<summary>kia</summary>
        public const string Kia = "application/vnd.kidspiration";
        ///<summary>kne</summary>
        public const string Kne = "application/vnd.kinar";
        ///<summary>knp</summary>
        public const string Knp = "application/vnd.kinar";
        ///<summary>skp</summary>
        public const string Skp = "application/vnd.koan";
        ///<summary>skd</summary>
        public const string Skd = "application/vnd.koan";
        ///<summary>skt</summary>
        public const string Skt = "application/vnd.koan";
        ///<summary>skm</summary>
        public const string Skm = "application/vnd.koan";
        ///<summary>sse</summary>
        public const string Sse = "application/vnd.kodak-descriptor";
        ///<summary>lasxml</summary>
        public const string Lasxml = "application/vnd.las.las+xml";
        ///<summary>lbd</summary>
        public const string Lbd = "application/vnd.llamagraphics.life-balance.desktop";
        ///<summary>lbe</summary>
        public const string Lbe = "application/vnd.llamagraphics.life-balance.exchange+xml";
        ///<summary>123</summary>
        public const string _123 = "application/vnd.lotus-1-2-3";
        ///<summary>apr</summary>
        public const string Apr = "application/vnd.lotus-approach";
        ///<summary>pre</summary>
        public const string Pre = "application/vnd.lotus-freelance";
        ///<summary>nsf</summary>
        public const string Nsf = "application/vnd.lotus-notes";
        ///<summary>org</summary>
        public const string Org = "application/vnd.lotus-organizer";
        ///<summary>scm</summary>
        public const string Scm = "application/vnd.lotus-screencam";
        ///<summary>lwp</summary>
        public const string Lwp = "application/vnd.lotus-wordpro";
        ///<summary>portpkg</summary>
        public const string Portpkg = "application/vnd.macports.portpkg";
        ///<summary>mvt</summary>
        public const string Mvt = "application/vnd.mapbox-vector-tile";
        ///<summary>mcd</summary>
        public const string Mcd = "application/vnd.mcd";
        ///<summary>mc1</summary>
        public const string Mc1 = "application/vnd.medcalcdata";
        ///<summary>cdkey</summary>
        public const string Cdkey = "application/vnd.mediastation.cdkey";
        ///<summary>mwf</summary>
        public const string Mwf = "application/vnd.mfer";
        ///<summary>mfm</summary>
        public const string Mfm = "application/vnd.mfmp";
        ///<summary>flo</summary>
        public const string Flo = "application/vnd.micrografx.flo";
        ///<summary>igx</summary>
        public const string Igx = "application/vnd.micrografx.igx";
        ///<summary>mif</summary>
        public const string Mif = "application/vnd.mif";
        ///<summary>daf</summary>
        public const string Daf = "application/vnd.mobius.daf";
        ///<summary>dis</summary>
        public const string Dis = "application/vnd.mobius.dis";
        ///<summary>mbk</summary>
        public const string Mbk = "application/vnd.mobius.mbk";
        ///<summary>mqy</summary>
        public const string Mqy = "application/vnd.mobius.mqy";
        ///<summary>msl</summary>
        public const string Msl = "application/vnd.mobius.msl";
        ///<summary>plc</summary>
        public const string Plc = "application/vnd.mobius.plc";
        ///<summary>txf</summary>
        public const string Txf = "application/vnd.mobius.txf";
        ///<summary>mpn</summary>
        public const string Mpn = "application/vnd.mophun.application";
        ///<summary>mpc</summary>
        public const string Mpc = "application/vnd.mophun.certificate";
        ///<summary>xul</summary>
        public const string Xul = "application/vnd.mozilla.xul+xml";
        ///<summary>cil</summary>
        public const string Cil = "application/vnd.ms-artgalry";
        ///<summary>cab</summary>
        public const string Cab = "application/vnd.ms-cab-compressed";
        ///<summary>xls</summary>
        public const string Xls = "application/vnd.ms-excel";
        ///<summary>xlm</summary>
        public const string Xlm = "application/vnd.ms-excel";
        ///<summary>xla</summary>
        public const string Xla = "application/vnd.ms-excel";
        ///<summary>xlc</summary>
        public const string Xlc = "application/vnd.ms-excel";
        ///<summary>xlt</summary>
        public const string Xlt = "application/vnd.ms-excel";
        ///<summary>xlw</summary>
        public const string Xlw = "application/vnd.ms-excel";
        ///<summary>xlam</summary>
        public const string Xlam = "application/vnd.ms-excel.addin.macroenabled.12";
        ///<summary>xlsb</summary>
        public const string Xlsb = "application/vnd.ms-excel.sheet.binary.macroenabled.12";
        ///<summary>xlsm</summary>
        public const string Xlsm = "application/vnd.ms-excel.sheet.macroenabled.12";
        ///<summary>xltm</summary>
        public const string Xltm = "application/vnd.ms-excel.template.macroenabled.12";
        ///<summary>eot</summary>
        public const string Eot = "application/vnd.ms-fontobject";
        ///<summary>chm</summary>
        public const string Chm = "application/vnd.ms-htmlhelp";
        ///<summary>ims</summary>
        public const string Ims = "application/vnd.ms-ims";
        ///<summary>lrm</summary>
        public const string Lrm = "application/vnd.ms-lrm";
        ///<summary>thmx</summary>
        public const string Thmx = "application/vnd.ms-officetheme";
        ///<summary>msg</summary>
        public const string Msg = "application/vnd.ms-outlook";
        ///<summary>cat</summary>
        public const string Cat = "application/vnd.ms-pki.seccat";
        ///<summary>stl</summary>
        public const string Stl = "application/vnd.ms-pki.stl";
        ///<summary>ppt</summary>
        public const string Ppt = "application/vnd.ms-powerpoint";
        ///<summary>pps</summary>
        public const string Pps = "application/vnd.ms-powerpoint";
        ///<summary>pot</summary>
        public const string Pot = "application/vnd.ms-powerpoint";
        ///<summary>ppam</summary>
        public const string Ppam = "application/vnd.ms-powerpoint.addin.macroenabled.12";
        ///<summary>pptm</summary>
        public const string Pptm = "application/vnd.ms-powerpoint.presentation.macroenabled.12";
        ///<summary>sldm</summary>
        public const string Sldm = "application/vnd.ms-powerpoint.slide.macroenabled.12";
        ///<summary>ppsm</summary>
        public const string Ppsm = "application/vnd.ms-powerpoint.slideshow.macroenabled.12";
        ///<summary>potm</summary>
        public const string Potm = "application/vnd.ms-powerpoint.template.macroenabled.12";
        ///<summary>mpt</summary>
        public const string Mpt = "application/vnd.ms-project";
        ///<summary>docm</summary>
        public const string Docm = "application/vnd.ms-word.document.macroenabled.12";
        ///<summary>dotm</summary>
        public const string Dotm = "application/vnd.ms-word.template.macroenabled.12";
        ///<summary>wps</summary>
        public const string Wps = "application/vnd.ms-works";
        ///<summary>wks</summary>
        public const string Wks = "application/vnd.ms-works";
        ///<summary>wcm</summary>
        public const string Wcm = "application/vnd.ms-works";
        ///<summary>wdb</summary>
        public const string Wdb = "application/vnd.ms-works";
        ///<summary>wpl</summary>
        public const string Wpl = "application/vnd.ms-wpl";
        ///<summary>xps</summary>
        public const string Xps = "application/vnd.ms-xpsdocument";
        ///<summary>mseq</summary>
        public const string Mseq = "application/vnd.mseq";
        ///<summary>mus</summary>
        public const string Mus = "application/vnd.musician";
        ///<summary>msty</summary>
        public const string Msty = "application/vnd.muvee.style";
        ///<summary>taglet</summary>
        public const string Taglet = "application/vnd.mynfc";
        ///<summary>nlu</summary>
        public const string Nlu = "application/vnd.neurolanguage.nlu";
        ///<summary>ntf</summary>
        public const string Ntf = "application/vnd.nitf";
        ///<summary>nitf</summary>
        public const string Nitf = "application/vnd.nitf";
        ///<summary>nnd</summary>
        public const string Nnd = "application/vnd.noblenet-directory";
        ///<summary>nns</summary>
        public const string Nns = "application/vnd.noblenet-sealer";
        ///<summary>nnw</summary>
        public const string Nnw = "application/vnd.noblenet-web";
        ///<summary>ngdat</summary>
        public const string Ngdat = "application/vnd.nokia.n-gage.data";
        ///<summary>n-gage</summary>
        public const string Ngage = "application/vnd.nokia.n-gage.symbian.install";
        ///<summary>rpst</summary>
        public const string Rpst = "application/vnd.nokia.radio-preset";
        ///<summary>rpss</summary>
        public const string Rpss = "application/vnd.nokia.radio-presets";
        ///<summary>edm</summary>
        public const string Edm = "application/vnd.novadigm.edm";
        ///<summary>edx</summary>
        public const string Edx = "application/vnd.novadigm.edx";
        ///<summary>ext</summary>
        public const string Ext = "application/vnd.novadigm.ext";
        ///<summary>odc</summary>
        public const string Odc = "application/vnd.oasis.opendocument.chart";
        ///<summary>otc</summary>
        public const string Otc = "application/vnd.oasis.opendocument.chart-template";
        ///<summary>odb</summary>
        public const string Odb = "application/vnd.oasis.opendocument.database";
        ///<summary>odf</summary>
        public const string Odf = "application/vnd.oasis.opendocument.formula";
        ///<summary>odft</summary>
        public const string Odft = "application/vnd.oasis.opendocument.formula-template";
        ///<summary>odg</summary>
        public const string Odg = "application/vnd.oasis.opendocument.graphics";
        ///<summary>otg</summary>
        public const string Otg = "application/vnd.oasis.opendocument.graphics-template";
        ///<summary>odi</summary>
        public const string Odi = "application/vnd.oasis.opendocument.image";
        ///<summary>oti</summary>
        public const string Oti = "application/vnd.oasis.opendocument.image-template";
        ///<summary>odp</summary>
        public const string Odp = "application/vnd.oasis.opendocument.presentation";
        ///<summary>otp</summary>
        public const string Otp = "application/vnd.oasis.opendocument.presentation-template";
        ///<summary>ods</summary>
        public const string Ods = "application/vnd.oasis.opendocument.spreadsheet";
        ///<summary>ots</summary>
        public const string Ots = "application/vnd.oasis.opendocument.spreadsheet-template";
        ///<summary>odt</summary>
        public const string Odt = "application/vnd.oasis.opendocument.text";
        ///<summary>odm</summary>
        public const string Odm = "application/vnd.oasis.opendocument.text-master";
        ///<summary>ott</summary>
        public const string Ott = "application/vnd.oasis.opendocument.text-template";
        ///<summary>oth</summary>
        public const string Oth = "application/vnd.oasis.opendocument.text-web";
        ///<summary>xo</summary>
        public const string Xo = "application/vnd.olpc-sugar";
        ///<summary>dd2</summary>
        public const string Dd2 = "application/vnd.oma.dd2+xml";
        ///<summary>obgx</summary>
        public const string Obgx = "application/vnd.openblox.game+xml";
        ///<summary>oxt</summary>
        public const string Oxt = "application/vnd.openofficeorg.extension";
        ///<summary>osm</summary>
        public const string Osm = "application/vnd.openstreetmap.data+xml";
        ///<summary>pptx</summary>
        public const string Pptx = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
        ///<summary>sldx</summary>
        public const string Sldx = "application/vnd.openxmlformats-officedocument.presentationml.slide";
        ///<summary>ppsx</summary>
        public const string Ppsx = "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
        ///<summary>potx</summary>
        public const string Potx = "application/vnd.openxmlformats-officedocument.presentationml.template";
        ///<summary>xlsx</summary>
        public const string Xlsx = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        ///<summary>xltx</summary>
        public const string Xltx = "application/vnd.openxmlformats-officedocument.spreadsheetml.template";
        ///<summary>docx</summary>
        public const string Docx = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        ///<summary>dotx</summary>
        public const string Dotx = "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
        ///<summary>mgp</summary>
        public const string Mgp = "application/vnd.osgeo.mapguide.package";
        ///<summary>dp</summary>
        public const string Dp = "application/vnd.osgi.dp";
        ///<summary>esa</summary>
        public const string Esa = "application/vnd.osgi.subsystem";
        ///<summary>pdb</summary>
        public const string Pdb = "application/vnd.palm";
        ///<summary>pqa</summary>
        public const string Pqa = "application/vnd.palm";
        ///<summary>oprc</summary>
        public const string Oprc = "application/vnd.palm";
        ///<summary>paw</summary>
        public const string Paw = "application/vnd.pawaafile";
        ///<summary>str</summary>
        public const string Str = "application/vnd.pg.format";
        ///<summary>ei6</summary>
        public const string Ei6 = "application/vnd.pg.osasli";
        ///<summary>efif</summary>
        public const string Efif = "application/vnd.picsel";
        ///<summary>wg</summary>
        public const string Wg = "application/vnd.pmi.widget";
        ///<summary>plf</summary>
        public const string Plf = "application/vnd.pocketlearn";
        ///<summary>pbd</summary>
        public const string Pbd = "application/vnd.powerbuilder6";
        ///<summary>box</summary>
        public const string Box = "application/vnd.previewsystems.box";
        ///<summary>mgz</summary>
        public const string Mgz = "application/vnd.proteus.magazine";
        ///<summary>qps</summary>
        public const string Qps = "application/vnd.publishare-delta-tree";
        ///<summary>ptid</summary>
        public const string Ptid = "application/vnd.pvi.ptid1";
        ///<summary>qxd</summary>
        public const string Qxd = "application/vnd.quark.quarkxpress";
        ///<summary>qxt</summary>
        public const string Qxt = "application/vnd.quark.quarkxpress";
        ///<summary>qwd</summary>
        public const string Qwd = "application/vnd.quark.quarkxpress";
        ///<summary>qwt</summary>
        public const string Qwt = "application/vnd.quark.quarkxpress";
        ///<summary>qxl</summary>
        public const string Qxl = "application/vnd.quark.quarkxpress";
        ///<summary>qxb</summary>
        public const string Qxb = "application/vnd.quark.quarkxpress";
        ///<summary>rar</summary>
        public const string Rar = "application/vnd.rar";
        ///<summary>bed</summary>
        public const string Bed = "application/vnd.realvnc.bed";
        ///<summary>mxl</summary>
        public const string Mxl = "application/vnd.recordare.musicxml";
        ///<summary>musicxml</summary>
        public const string Musicxml = "application/vnd.recordare.musicxml+xml";
        ///<summary>cryptonote</summary>
        public const string Cryptonote = "application/vnd.rig.cryptonote";
        ///<summary>cod</summary>
        public const string Cod = "application/vnd.rim.cod";
        ///<summary>rm</summary>
        public const string Rm = "application/vnd.rn-realmedia";
        ///<summary>rmvb</summary>
        public const string Rmvb = "application/vnd.rn-realmedia-vbr";
        ///<summary>link66</summary>
        public const string Link66 = "application/vnd.route66.link66+xml";
        ///<summary>st</summary>
        public const string St = "application/vnd.sailingtracker.track";
        ///<summary>see</summary>
        public const string See = "application/vnd.seemail";
        ///<summary>sema</summary>
        public const string Sema = "application/vnd.sema";
        ///<summary>semd</summary>
        public const string Semd = "application/vnd.semd";
        ///<summary>semf</summary>
        public const string Semf = "application/vnd.semf";
        ///<summary>ifm</summary>
        public const string Ifm = "application/vnd.shana.informed.formdata";
        ///<summary>itp</summary>
        public const string Itp = "application/vnd.shana.informed.formtemplate";
        ///<summary>iif</summary>
        public const string Iif = "application/vnd.shana.informed.interchange";
        ///<summary>ipk</summary>
        public const string Ipk = "application/vnd.shana.informed.package";
        ///<summary>twd</summary>
        public const string Twd = "application/vnd.simtech-mindmapper";
        ///<summary>twds</summary>
        public const string Twds = "application/vnd.simtech-mindmapper";
        ///<summary>mmf</summary>
        public const string Mmf = "application/vnd.smaf";
        ///<summary>teacher</summary>
        public const string Teacher = "application/vnd.smart.teacher";
        ///<summary>fo</summary>
        public const string Fo = "application/vnd.software602.filler.form+xml";
        ///<summary>sdkm</summary>
        public const string Sdkm = "application/vnd.solent.sdkm+xml";
        ///<summary>sdkd</summary>
        public const string Sdkd = "application/vnd.solent.sdkm+xml";
        ///<summary>dxp</summary>
        public const string Dxp = "application/vnd.spotfire.dxp";
        ///<summary>sfs</summary>
        public const string Sfs = "application/vnd.spotfire.sfs";
        ///<summary>sdc</summary>
        public const string Sdc = "application/vnd.stardivision.calc";
        ///<summary>sda</summary>
        public const string Sda = "application/vnd.stardivision.draw";
        ///<summary>sdd</summary>
        public const string Sdd = "application/vnd.stardivision.impress";
        ///<summary>smf</summary>
        public const string Smf = "application/vnd.stardivision.math";
        ///<summary>sdw</summary>
        public const string Sdw = "application/vnd.stardivision.writer";
        ///<summary>vor</summary>
        public const string Vor = "application/vnd.stardivision.writer";
        ///<summary>sgl</summary>
        public const string Sgl = "application/vnd.stardivision.writer-global";
        ///<summary>smzip</summary>
        public const string Smzip = "application/vnd.stepmania.package";
        ///<summary>sm</summary>
        public const string Sm = "application/vnd.stepmania.stepchart";
        ///<summary>wadl</summary>
        public const string Wadl = "application/vnd.sun.wadl+xml";
        ///<summary>sxc</summary>
        public const string Sxc = "application/vnd.sun.xml.calc";
        ///<summary>stc</summary>
        public const string Stc = "application/vnd.sun.xml.calc.template";
        ///<summary>sxd</summary>
        public const string Sxd = "application/vnd.sun.xml.draw";
        ///<summary>std</summary>
        public const string Std = "application/vnd.sun.xml.draw.template";
        ///<summary>sxi</summary>
        public const string Sxi = "application/vnd.sun.xml.impress";
        ///<summary>sti</summary>
        public const string Sti = "application/vnd.sun.xml.impress.template";
        ///<summary>sxm</summary>
        public const string Sxm = "application/vnd.sun.xml.math";
        ///<summary>sxw</summary>
        public const string Sxw = "application/vnd.sun.xml.writer";
        ///<summary>sxg</summary>
        public const string Sxg = "application/vnd.sun.xml.writer.global";
        ///<summary>stw</summary>
        public const string Stw = "application/vnd.sun.xml.writer.template";
        ///<summary>sus</summary>
        public const string Sus = "application/vnd.sus-calendar";
        ///<summary>susp</summary>
        public const string Susp = "application/vnd.sus-calendar";
        ///<summary>svd</summary>
        public const string Svd = "application/vnd.svd";
        ///<summary>sis</summary>
        public const string Sis = "application/vnd.symbian.install";
        ///<summary>sisx</summary>
        public const string Sisx = "application/vnd.symbian.install";
        ///<summary>xsm</summary>
        public const string Xsm = "application/vnd.syncml+xml";
        ///<summary>bdm</summary>
        public const string Bdm = "application/vnd.syncml.dm+wbxml";
        ///<summary>xdm</summary>
        public const string Xdm = "application/vnd.syncml.dm+xml";
        ///<summary>ddf</summary>
        public const string Ddf = "application/vnd.syncml.dmddf+xml";
        ///<summary>tao</summary>
        public const string Tao = "application/vnd.tao.intent-module-archive";
        ///<summary>pcap</summary>
        public const string Pcap = "application/vnd.tcpdump.pcap";
        ///<summary>cap</summary>
        public const string Cap = "application/vnd.tcpdump.pcap";
        ///<summary>dmp</summary>
        public const string Dmp = "application/vnd.tcpdump.pcap";
        ///<summary>tmo</summary>
        public const string Tmo = "application/vnd.tmobile-livetv";
        ///<summary>tpt</summary>
        public const string Tpt = "application/vnd.trid.tpt";
        ///<summary>mxs</summary>
        public const string Mxs = "application/vnd.triscape.mxs";
        ///<summary>tra</summary>
        public const string Tra = "application/vnd.trueapp";
        ///<summary>ufd</summary>
        public const string Ufd = "application/vnd.ufdl";
        ///<summary>ufdl</summary>
        public const string Ufdl = "application/vnd.ufdl";
        ///<summary>utz</summary>
        public const string Utz = "application/vnd.uiq.theme";
        ///<summary>umj</summary>
        public const string Umj = "application/vnd.umajin";
        ///<summary>unityweb</summary>
        public const string Unityweb = "application/vnd.unity";
        ///<summary>uoml</summary>
        public const string Uoml = "application/vnd.uoml+xml";
        ///<summary>vcx</summary>
        public const string Vcx = "application/vnd.vcx";
        ///<summary>vsd</summary>
        public const string Vsd = "application/vnd.visio";
        ///<summary>vst</summary>
        public const string Vst = "application/vnd.visio";
        ///<summary>vss</summary>
        public const string Vss = "application/vnd.visio";
        ///<summary>vsw</summary>
        public const string Vsw = "application/vnd.visio";
        ///<summary>vis</summary>
        public const string Vis = "application/vnd.visionary";
        ///<summary>vsf</summary>
        public const string Vsf = "application/vnd.vsf";
        ///<summary>wbxml</summary>
        public const string Wbxml = "application/vnd.wap.wbxml";
        ///<summary>wmlc</summary>
        public const string Wmlc = "application/vnd.wap.wmlc";
        ///<summary>wmlsc</summary>
        public const string Wmlsc = "application/vnd.wap.wmlscriptc";
        ///<summary>wtb</summary>
        public const string Wtb = "application/vnd.webturbo";
        ///<summary>nbp</summary>
        public const string Nbp = "application/vnd.wolfram.player";
        ///<summary>wpd</summary>
        public const string Wpd = "application/vnd.wordperfect";
        ///<summary>wqd</summary>
        public const string Wqd = "application/vnd.wqd";
        ///<summary>stf</summary>
        public const string Stf = "application/vnd.wt.stf";
        ///<summary>xar</summary>
        public const string Xar = "application/vnd.xara";
        ///<summary>xfdl</summary>
        public const string Xfdl = "application/vnd.xfdl";
        ///<summary>hvd</summary>
        public const string Hvd = "application/vnd.yamaha.hv-dic";
        ///<summary>hvs</summary>
        public const string Hvs = "application/vnd.yamaha.hv-script";
        ///<summary>hvp</summary>
        public const string Hvp = "application/vnd.yamaha.hv-voice";
        ///<summary>osf</summary>
        public const string Osf = "application/vnd.yamaha.openscoreformat";
        ///<summary>osfpvg</summary>
        public const string Osfpvg = "application/vnd.yamaha.openscoreformat.osfpvg+xml";
        ///<summary>saf</summary>
        public const string Saf = "application/vnd.yamaha.smaf-audio";
        ///<summary>spf</summary>
        public const string Spf = "application/vnd.yamaha.smaf-phrase";
        ///<summary>cmp</summary>
        public const string Cmp = "application/vnd.yellowriver-custom-menu";
        ///<summary>zir</summary>
        public const string Zir = "application/vnd.zul";
        ///<summary>zirz</summary>
        public const string Zirz = "application/vnd.zul";
        ///<summary>zaz</summary>
        public const string Zaz = "application/vnd.zzazz.deck+xml";
        ///<summary>vxml</summary>
        public const string Vxml = "application/voicexml+xml";
        ///<summary>wasm</summary>
        public const string Wasm = "application/wasm";
        ///<summary>wif</summary>
        public const string Wif = "application/watcherinfo+xml";
        ///<summary>wgt</summary>
        public const string Wgt = "application/widget";
        ///<summary>hlp</summary>
        public const string Hlp = "application/winhlp";
        ///<summary>wsdl</summary>
        public const string Wsdl = "application/wsdl+xml";
        ///<summary>wspolicy</summary>
        public const string Wspolicy = "application/wspolicy+xml";
        ///<summary>7z</summary>
        public const string _7z = "application/x-7z-compressed";
        ///<summary>abw</summary>
        public const string Abw = "application/x-abiword";
        ///<summary>ace</summary>
        public const string Ace = "application/x-ace-compressed";
        ///<summary>arj</summary>
        public const string Arj = "application/x-arj";
        ///<summary>aab</summary>
        public const string Aab = "application/x-authorware-bin";
        ///<summary>x32</summary>
        public const string X32 = "application/x-authorware-bin";
        ///<summary>u32</summary>
        public const string U32 = "application/x-authorware-bin";
        ///<summary>vox</summary>
        public const string Vox = "application/x-authorware-bin";
        ///<summary>aam</summary>
        public const string Aam = "application/x-authorware-map";
        ///<summary>aas</summary>
        public const string Aas = "application/x-authorware-seg";
        ///<summary>bcpio</summary>
        public const string Bcpio = "application/x-bcpio";
        ///<summary>torrent</summary>
        public const string Torrent = "application/x-bittorrent";
        ///<summary>blb</summary>
        public const string Blb = "application/x-blorb";
        ///<summary>blorb</summary>
        public const string Blorb = "application/x-blorb";
        ///<summary>bz</summary>
        public const string Bz = "application/x-bzip";
        ///<summary>bz2</summary>
        public const string Bz2 = "application/x-bzip2";
        ///<summary>boz</summary>
        public const string Boz = "application/x-bzip2";
        ///<summary>cbr</summary>
        public const string Cbr = "application/x-cbr";
        ///<summary>cba</summary>
        public const string Cba = "application/x-cbr";
        ///<summary>cbt</summary>
        public const string Cbt = "application/x-cbr";
        ///<summary>cbz</summary>
        public const string Cbz = "application/x-cbr";
        ///<summary>cb7</summary>
        public const string Cb7 = "application/x-cbr";
        ///<summary>vcd</summary>
        public const string Vcd = "application/x-cdlink";
        ///<summary>cfs</summary>
        public const string Cfs = "application/x-cfs-compressed";
        ///<summary>chat</summary>
        public const string Chat = "application/x-chat";
        ///<summary>pgn</summary>
        public const string Pgn = "application/x-chess-pgn";
        ///<summary>crx</summary>
        public const string Crx = "application/x-chrome-extension";
        ///<summary>cco</summary>
        public const string Cco = "application/x-cocoa";
        ///<summary>nsc</summary>
        public const string Nsc = "application/x-conference";
        ///<summary>cpio</summary>
        public const string Cpio = "application/x-cpio";
        ///<summary>csh</summary>
        public const string Csh = "application/x-csh";
        ///<summary>udeb</summary>
        public const string Udeb = "application/x-debian-package";
        ///<summary>dgc</summary>
        public const string Dgc = "application/x-dgc-compressed";
        ///<summary>dir</summary>
        public const string Dir = "application/x-director";
        ///<summary>dcr</summary>
        public const string Dcr = "application/x-director";
        ///<summary>dxr</summary>
        public const string Dxr = "application/x-director";
        ///<summary>cst</summary>
        public const string Cst = "application/x-director";
        ///<summary>cct</summary>
        public const string Cct = "application/x-director";
        ///<summary>cxt</summary>
        public const string Cxt = "application/x-director";
        ///<summary>w3d</summary>
        public const string W3d = "application/x-director";
        ///<summary>fgd</summary>
        public const string Fgd = "application/x-director";
        ///<summary>swa</summary>
        public const string Swa = "application/x-director";
        ///<summary>wad</summary>
        public const string Wad = "application/x-doom";
        ///<summary>ncx</summary>
        public const string Ncx = "application/x-dtbncx+xml";
        ///<summary>dtb</summary>
        public const string Dtb = "application/x-dtbook+xml";
        ///<summary>res</summary>
        public const string Res = "application/x-dtbresource+xml";
        ///<summary>dvi</summary>
        public const string Dvi = "application/x-dvi";
        ///<summary>evy</summary>
        public const string Evy = "application/x-envoy";
        ///<summary>eva</summary>
        public const string Eva = "application/x-eva";
        ///<summary>bdf</summary>
        public const string Bdf = "application/x-font-bdf";
        ///<summary>gsf</summary>
        public const string Gsf = "application/x-font-ghostscript";
        ///<summary>psf</summary>
        public const string Psf = "application/x-font-linux-psf";
        ///<summary>pcf</summary>
        public const string Pcf = "application/x-font-pcf";
        ///<summary>snf</summary>
        public const string Snf = "application/x-font-snf";
        ///<summary>pfa</summary>
        public const string Pfa = "application/x-font-type1";
        ///<summary>pfb</summary>
        public const string Pfb = "application/x-font-type1";
        ///<summary>pfm</summary>
        public const string Pfm = "application/x-font-type1";
        ///<summary>afm</summary>
        public const string Afm = "application/x-font-type1";
        ///<summary>arc</summary>
        public const string Arc = "application/x-freearc";
        ///<summary>spl</summary>
        public const string Spl = "application/x-futuresplash";
        ///<summary>gca</summary>
        public const string Gca = "application/x-gca-compressed";
        ///<summary>ulx</summary>
        public const string Ulx = "application/x-glulx";
        ///<summary>gnumeric</summary>
        public const string Gnumeric = "application/x-gnumeric";
        ///<summary>gramps</summary>
        public const string Gramps = "application/x-gramps-xml";
        ///<summary>gtar</summary>
        public const string Gtar = "application/x-gtar";
        ///<summary>hdf</summary>
        public const string Hdf = "application/x-hdf";
        ///<summary>php</summary>
        public const string Php = "application/x-httpd-php";
        ///<summary>install</summary>
        public const string Install = "application/x-install-instructions";
        ///<summary>jardiff</summary>
        public const string Jardiff = "application/x-java-archive-diff";
        ///<summary>jnlp</summary>
        public const string Jnlp = "application/x-java-jnlp-file";
        ///<summary>kdbx</summary>
        public const string Kdbx = "application/x-keepass2";
        ///<summary>latex</summary>
        public const string Latex = "application/x-latex";
        ///<summary>luac</summary>
        public const string Luac = "application/x-lua-bytecode";
        ///<summary>lzh</summary>
        public const string Lzh = "application/x-lzh-compressed";
        ///<summary>lha</summary>
        public const string Lha = "application/x-lzh-compressed";
        ///<summary>run</summary>
        public const string Run = "application/x-makeself";
        ///<summary>mie</summary>
        public const string Mie = "application/x-mie";
        ///<summary>prc</summary>
        public const string Prc = "application/x-mobipocket-ebook";
        ///<summary>mobi</summary>
        public const string Mobi = "application/x-mobipocket-ebook";
        ///<summary>application</summary>
        public const string Application = "application/x-ms-application";
        ///<summary>lnk</summary>
        public const string Lnk = "application/x-ms-shortcut";
        ///<summary>wmd</summary>
        public const string Wmd = "application/x-ms-wmd";
        ///<summary>wmz</summary>
        public const string Wmz = "application/x-ms-wmz";
        ///<summary>xbap</summary>
        public const string Xbap = "application/x-ms-xbap";
        ///<summary>mdb</summary>
        public const string Mdb = "application/x-msaccess";
        ///<summary>obd</summary>
        public const string Obd = "application/x-msbinder";
        ///<summary>crd</summary>
        public const string Crd = "application/x-mscardfile";
        ///<summary>clp</summary>
        public const string Clp = "application/x-msclip";
        ///<summary>com</summary>
        public const string Com = "application/x-msdownload";
        ///<summary>bat</summary>
        public const string Bat = "application/x-msdownload";
        ///<summary>mvb</summary>
        public const string Mvb = "application/x-msmediaview";
        ///<summary>m13</summary>
        public const string M13 = "application/x-msmediaview";
        ///<summary>m14</summary>
        public const string M14 = "application/x-msmediaview";
        ///<summary>wmf</summary>
        public const string Wmf = "application/x-msmetafile";
        ///<summary>emf</summary>
        public const string Emf = "application/x-msmetafile";
        ///<summary>emz</summary>
        public const string Emz = "application/x-msmetafile";
        ///<summary>mny</summary>
        public const string Mny = "application/x-msmoney";
        ///<summary>pub</summary>
        public const string Pub = "application/x-mspublisher";
        ///<summary>scd</summary>
        public const string Scd = "application/x-msschedule";
        ///<summary>trm</summary>
        public const string Trm = "application/x-msterminal";
        ///<summary>wri</summary>
        public const string Wri = "application/x-mswrite";
        ///<summary>nc</summary>
        public const string Nc = "application/x-netcdf";
        ///<summary>cdf</summary>
        public const string Cdf = "application/x-netcdf";
        ///<summary>pac</summary>
        public const string Pac = "application/x-ns-proxy-autoconfig";
        ///<summary>nzb</summary>
        public const string Nzb = "application/x-nzb";
        ///<summary>pl</summary>
        public const string Pl = "application/x-perl";
        ///<summary>pm</summary>
        public const string Pm = "application/x-perl";
        ///<summary>p12</summary>
        public const string P12 = "application/x-pkcs12";
        ///<summary>pfx</summary>
        public const string Pfx = "application/x-pkcs12";
        ///<summary>p7b</summary>
        public const string P7b = "application/x-pkcs7-certificates";
        ///<summary>spc</summary>
        public const string Spc = "application/x-pkcs7-certificates";
        ///<summary>p7r</summary>
        public const string P7r = "application/x-pkcs7-certreqresp";
        ///<summary>rpm</summary>
        public const string Rpm = "application/x-redhat-package-manager";
        ///<summary>ris</summary>
        public const string Ris = "application/x-research-info-systems";
        ///<summary>sea</summary>
        public const string Sea = "application/x-sea";
        ///<summary>sh</summary>
        public const string Sh = "application/x-sh";
        ///<summary>shar</summary>
        public const string Shar = "application/x-shar";
        ///<summary>swf</summary>
        public const string Swf = "application/x-shockwave-flash";
        ///<summary>xap</summary>
        public const string Xap = "application/x-silverlight-app";
        ///<summary>sql</summary>
        public const string Sql = "application/x-sql";
        ///<summary>sit</summary>
        public const string Sit = "application/x-stuffit";
        ///<summary>sitx</summary>
        public const string Sitx = "application/x-stuffitx";
        ///<summary>srt</summary>
        public const string Srt = "application/x-subrip";
        ///<summary>sv4cpio</summary>
        public const string Sv4cpio = "application/x-sv4cpio";
        ///<summary>sv4crc</summary>
        public const string Sv4crc = "application/x-sv4crc";
        ///<summary>t3</summary>
        public const string T3 = "application/x-t3vm-image";
        ///<summary>gam</summary>
        public const string Gam = "application/x-tads";
        ///<summary>tar</summary>
        public const string Tar = "application/x-tar";
        ///<summary>tcl</summary>
        public const string Tcl = "application/x-tcl";
        ///<summary>tk</summary>
        public const string Tk = "application/x-tcl";
        ///<summary>tex</summary>
        public const string Tex = "application/x-tex";
        ///<summary>tfm</summary>
        public const string Tfm = "application/x-tex-tfm";
        ///<summary>texinfo</summary>
        public const string Texinfo = "application/x-texinfo";
        ///<summary>texi</summary>
        public const string Texi = "application/x-texinfo";
        ///<summary>obj</summary>
        public const string Obj = "application/x-tgif";
        ///<summary>ustar</summary>
        public const string Ustar = "application/x-ustar";
        ///<summary>hdd</summary>
        public const string Hdd = "application/x-virtualbox-hdd";
        ///<summary>ova</summary>
        public const string Ova = "application/x-virtualbox-ova";
        ///<summary>ovf</summary>
        public const string Ovf = "application/x-virtualbox-ovf";
        ///<summary>vbox</summary>
        public const string Vbox = "application/x-virtualbox-vbox";
        ///<summary>vbox-extpack</summary>
        public const string Vboxextpack = "application/x-virtualbox-vbox-extpack";
        ///<summary>vdi</summary>
        public const string Vdi = "application/x-virtualbox-vdi";
        ///<summary>vhd</summary>
        public const string Vhd = "application/x-virtualbox-vhd";
        ///<summary>vmdk</summary>
        public const string Vmdk = "application/x-virtualbox-vmdk";
        ///<summary>src</summary>
        public const string Src = "application/x-wais-source";
        ///<summary>webapp</summary>
        public const string Webapp = "application/x-web-app-manifest+json";
        ///<summary>der</summary>
        public const string Der = "application/x-x509-ca-cert";
        ///<summary>crt</summary>
        public const string Crt = "application/x-x509-ca-cert";
        ///<summary>pem</summary>
        public const string Pem = "application/x-x509-ca-cert";
        ///<summary>fig</summary>
        public const string Fig = "application/x-xfig";
        ///<summary>xlf</summary>
        public const string Xlf = "application/x-xliff+xml";
        ///<summary>xpi</summary>
        public const string Xpi = "application/x-xpinstall";
        ///<summary>xz</summary>
        public const string Xz = "application/x-xz";
        ///<summary>z1</summary>
        public const string Z1 = "application/x-zmachine";
        ///<summary>z2</summary>
        public const string Z2 = "application/x-zmachine";
        ///<summary>z3</summary>
        public const string Z3 = "application/x-zmachine";
        ///<summary>z4</summary>
        public const string Z4 = "application/x-zmachine";
        ///<summary>z5</summary>
        public const string Z5 = "application/x-zmachine";
        ///<summary>z6</summary>
        public const string Z6 = "application/x-zmachine";
        ///<summary>z7</summary>
        public const string Z7 = "application/x-zmachine";
        ///<summary>z8</summary>
        public const string Z8 = "application/x-zmachine";
        ///<summary>xaml</summary>
        public const string Xaml = "application/xaml+xml";
        ///<summary>xav</summary>
        public const string Xav = "application/xcap-att+xml";
        ///<summary>xca</summary>
        public const string Xca = "application/xcap-caps+xml";
        ///<summary>xdf</summary>
        public const string Xdf = "application/xcap-diff+xml";
        ///<summary>xel</summary>
        public const string Xel = "application/xcap-el+xml";
        ///<summary>xns</summary>
        public const string Xns = "application/xcap-ns+xml";
        ///<summary>xenc</summary>
        public const string Xenc = "application/xenc+xml";
        ///<summary>xhtml</summary>
        public const string Xhtml = "application/xhtml+xml";
        ///<summary>xht</summary>
        public const string Xht = "application/xhtml+xml";
        ///<summary>xml</summary>
        public const string Xml = "application/xml";
        ///<summary>xsl</summary>
        public const string Xsl = "application/xml";
        ///<summary>xsd</summary>
        public const string Xsd = "application/xml";
        ///<summary>rng</summary>
        public const string Rng = "application/xml";
        ///<summary>dtd</summary>
        public const string Dtd = "application/xml-dtd";
        ///<summary>xop</summary>
        public const string Xop = "application/xop+xml";
        ///<summary>xpl</summary>
        public const string Xpl = "application/xproc+xml";
        ///<summary>xslt</summary>
        public const string Xslt = "application/xslt+xml";
        ///<summary>xspf</summary>
        public const string Xspf = "application/xspf+xml";
        ///<summary>mxml</summary>
        public const string Mxml = "application/xv+xml";
        ///<summary>xhvml</summary>
        public const string Xhvml = "application/xv+xml";
        ///<summary>xvml</summary>
        public const string Xvml = "application/xv+xml";
        ///<summary>xvm</summary>
        public const string Xvm = "application/xv+xml";
        ///<summary>yang</summary>
        public const string Yang = "application/yang";
        ///<summary>yin</summary>
        public const string Yin = "application/yin+xml";
        ///<summary>zip</summary>
        public const string Zip = "application/zip";
        ///<summary>3gpp</summary>
        public const string _3gpp = "audio/3gpp";
        ///<summary>adp</summary>
        public const string Adp = "audio/adpcm";
        ///<summary>amr</summary>
        public const string Amr = "audio/amr";
        ///<summary>au</summary>
        public const string Au = "audio/basic";
        ///<summary>snd</summary>
        public const string Snd = "audio/basic";
        ///<summary>mid</summary>
        public const string Mid = "audio/midi";
        ///<summary>midi</summary>
        public const string Midi = "audio/midi";
        ///<summary>kar</summary>
        public const string Kar = "audio/midi";
        ///<summary>rmi</summary>
        public const string Rmi = "audio/midi";
        ///<summary>mxmf</summary>
        public const string Mxmf = "audio/mobile-xmf";
        ///<summary>mp3</summary>
        public const string Mp3 = "audio/mp3";
        ///<summary>m4a</summary>
        public const string M4a = "audio/mp4";
        ///<summary>mp4a</summary>
        public const string Mp4a = "audio/mp4";
        ///<summary>mpga</summary>
        public const string Mpga = "audio/mpeg";
        ///<summary>mp2</summary>
        public const string Mp2 = "audio/mpeg";
        ///<summary>mp2a</summary>
        public const string Mp2a = "audio/mpeg";
        ///<summary>m2a</summary>
        public const string M2a = "audio/mpeg";
        ///<summary>m3a</summary>
        public const string M3a = "audio/mpeg";
        ///<summary>oga</summary>
        public const string Oga = "audio/ogg";
        ///<summary>ogg</summary>
        public const string Ogg = "audio/ogg";
        ///<summary>spx</summary>
        public const string Spx = "audio/ogg";
        ///<summary>opus</summary>
        public const string Opus = "audio/ogg";
        ///<summary>s3m</summary>
        public const string S3m = "audio/s3m";
        ///<summary>sil</summary>
        public const string Sil = "audio/silk";
        ///<summary>uva</summary>
        public const string Uva = "audio/vnd.dece.audio";
        ///<summary>uvva</summary>
        public const string Uvva = "audio/vnd.dece.audio";
        ///<summary>eol</summary>
        public const string Eol = "audio/vnd.digital-winds";
        ///<summary>dra</summary>
        public const string Dra = "audio/vnd.dra";
        ///<summary>dts</summary>
        public const string Dts = "audio/vnd.dts";
        ///<summary>dtshd</summary>
        public const string Dtshd = "audio/vnd.dts.hd";
        ///<summary>lvp</summary>
        public const string Lvp = "audio/vnd.lucent.voice";
        ///<summary>pya</summary>
        public const string Pya = "audio/vnd.ms-playready.media.pya";
        ///<summary>ecelp4800</summary>
        public const string Ecelp4800 = "audio/vnd.nuera.ecelp4800";
        ///<summary>ecelp7470</summary>
        public const string Ecelp7470 = "audio/vnd.nuera.ecelp7470";
        ///<summary>ecelp9600</summary>
        public const string Ecelp9600 = "audio/vnd.nuera.ecelp9600";
        ///<summary>rip</summary>
        public const string Rip = "audio/vnd.rip";
        ///<summary>wav</summary>
        public const string Wav = "audio/wav";
        ///<summary>weba</summary>
        public const string Weba = "audio/webm";
        ///<summary>aac</summary>
        public const string Aac = "audio/x-aac";
        ///<summary>aif</summary>
        public const string Aif = "audio/x-aiff";
        ///<summary>aiff</summary>
        public const string Aiff = "audio/x-aiff";
        ///<summary>aifc</summary>
        public const string Aifc = "audio/x-aiff";
        ///<summary>caf</summary>
        public const string Caf = "audio/x-caf";
        ///<summary>flac</summary>
        public const string Flac = "audio/x-flac";
        ///<summary>mka</summary>
        public const string Mka = "audio/x-matroska";
        ///<summary>m3u</summary>
        public const string M3u = "audio/x-mpegurl";
        ///<summary>wax</summary>
        public const string Wax = "audio/x-ms-wax";
        ///<summary>wma</summary>
        public const string Wma = "audio/x-ms-wma";
        ///<summary>ram</summary>
        public const string Ram = "audio/x-pn-realaudio";
        ///<summary>ra</summary>
        public const string Ra = "audio/x-pn-realaudio";
        ///<summary>rmp</summary>
        public const string Rmp = "audio/x-pn-realaudio-plugin";
        ///<summary>xm</summary>
        public const string Xm = "audio/xm";
        ///<summary>cdx</summary>
        public const string Cdx = "chemical/x-cdx";
        ///<summary>cif</summary>
        public const string Cif = "chemical/x-cif";
        ///<summary>cmdf</summary>
        public const string Cmdf = "chemical/x-cmdf";
        ///<summary>cml</summary>
        public const string Cml = "chemical/x-cml";
        ///<summary>csml</summary>
        public const string Csml = "chemical/x-csml";
        ///<summary>xyz</summary>
        public const string Xyz = "chemical/x-xyz";
        ///<summary>ttc</summary>
        public const string Ttc = "font/collection";
        ///<summary>otf</summary>
        public const string Otf = "font/otf";
        ///<summary>ttf</summary>
        public const string Ttf = "font/ttf";
        ///<summary>woff</summary>
        public const string Woff = "font/woff";
        ///<summary>woff2</summary>
        public const string Woff2 = "font/woff2";
        ///<summary>exr</summary>
        public const string Exr = "image/aces";
        ///<summary>apng</summary>
        public const string Apng = "image/apng";
        ///<summary>avci</summary>
        public const string Avci = "image/avci";
        ///<summary>avcs</summary>
        public const string Avcs = "image/avcs";
        ///<summary>avif</summary>
        public const string Avif = "image/avif";
        ///<summary>bmp</summary>
        public const string Bmp = "image/bmp";
        ///<summary>cgm</summary>
        public const string Cgm = "image/cgm";
        ///<summary>drle</summary>
        public const string Drle = "image/dicom-rle";
        ///<summary>fits</summary>
        public const string Fits = "image/fits";
        ///<summary>g3</summary>
        public const string G3 = "image/g3fax";
        ///<summary>gif</summary>
        public const string Gif = "image/gif";
        ///<summary>heic</summary>
        public const string Heic = "image/heic";
        ///<summary>heics</summary>
        public const string Heics = "image/heic-sequence";
        ///<summary>heif</summary>
        public const string Heif = "image/heif";
        ///<summary>heifs</summary>
        public const string Heifs = "image/heif-sequence";
        ///<summary>hej2</summary>
        public const string Hej2 = "image/hej2k";
        ///<summary>hsj2</summary>
        public const string Hsj2 = "image/hsj2";
        ///<summary>ief</summary>
        public const string Ief = "image/ief";
        ///<summary>jls</summary>
        public const string Jls = "image/jls";
        ///<summary>jp2</summary>
        public const string Jp2 = "image/jp2";
        ///<summary>jpg2</summary>
        public const string Jpg2 = "image/jp2";
        ///<summary>jpeg</summary>
        public const string Jpeg = "image/jpeg";
        ///<summary>jpg</summary>
        public const string Jpg = "image/jpeg";
        ///<summary>jpe</summary>
        public const string Jpe = "image/jpeg";
        ///<summary>jph</summary>
        public const string Jph = "image/jph";
        ///<summary>jhc</summary>
        public const string Jhc = "image/jphc";
        ///<summary>jpm</summary>
        public const string Jpm = "image/jpm";
        ///<summary>jpx</summary>
        public const string Jpx = "image/jpx";
        ///<summary>jpf</summary>
        public const string Jpf = "image/jpx";
        ///<summary>jxr</summary>
        public const string Jxr = "image/jxr";
        ///<summary>jxra</summary>
        public const string Jxra = "image/jxra";
        ///<summary>jxrs</summary>
        public const string Jxrs = "image/jxrs";
        ///<summary>jxs</summary>
        public const string Jxs = "image/jxs";
        ///<summary>jxsc</summary>
        public const string Jxsc = "image/jxsc";
        ///<summary>jxsi</summary>
        public const string Jxsi = "image/jxsi";
        ///<summary>jxss</summary>
        public const string Jxss = "image/jxss";
        ///<summary>ktx</summary>
        public const string Ktx = "image/ktx";
        ///<summary>ktx2</summary>
        public const string Ktx2 = "image/ktx2";
        ///<summary>png</summary>
        public const string Png = "image/png";
        ///<summary>btif</summary>
        public const string Btif = "image/prs.btif";
        ///<summary>pti</summary>
        public const string Pti = "image/prs.pti";
        ///<summary>sgi</summary>
        public const string Sgi = "image/sgi";
        ///<summary>svg</summary>
        public const string Svg = "image/svg+xml";
        ///<summary>svgz</summary>
        public const string Svgz = "image/svg+xml";
        ///<summary>t38</summary>
        public const string T38 = "image/t38";
        ///<summary>tif</summary>
        public const string Tif = "image/tiff";
        ///<summary>tiff</summary>
        public const string Tiff = "image/tiff";
        ///<summary>tfx</summary>
        public const string Tfx = "image/tiff-fx";
        ///<summary>psd</summary>
        public const string Psd = "image/vnd.adobe.photoshop";
        ///<summary>azv</summary>
        public const string Azv = "image/vnd.airzip.accelerator.azv";
        ///<summary>uvi</summary>
        public const string Uvi = "image/vnd.dece.graphic";
        ///<summary>uvvi</summary>
        public const string Uvvi = "image/vnd.dece.graphic";
        ///<summary>uvg</summary>
        public const string Uvg = "image/vnd.dece.graphic";
        ///<summary>uvvg</summary>
        public const string Uvvg = "image/vnd.dece.graphic";
        ///<summary>djvu</summary>
        public const string Djvu = "image/vnd.djvu";
        ///<summary>djv</summary>
        public const string Djv = "image/vnd.djvu";
        ///<summary>sub</summary>
        public const string Sub = "image/vnd.dvb.subtitle";
        ///<summary>dwg</summary>
        public const string Dwg = "image/vnd.dwg";
        ///<summary>dxf</summary>
        public const string Dxf = "image/vnd.dxf";
        ///<summary>fbs</summary>
        public const string Fbs = "image/vnd.fastbidsheet";
        ///<summary>fpx</summary>
        public const string Fpx = "image/vnd.fpx";
        ///<summary>fst</summary>
        public const string Fst = "image/vnd.fst";
        ///<summary>mmr</summary>
        public const string Mmr = "image/vnd.fujixerox.edmics-mmr";
        ///<summary>rlc</summary>
        public const string Rlc = "image/vnd.fujixerox.edmics-rlc";
        ///<summary>ico</summary>
        public const string Ico = "image/vnd.microsoft.icon";
        ///<summary>dds</summary>
        public const string Dds = "image/vnd.ms-dds";
        ///<summary>mdi</summary>
        public const string Mdi = "image/vnd.ms-modi";
        ///<summary>wdp</summary>
        public const string Wdp = "image/vnd.ms-photo";
        ///<summary>npx</summary>
        public const string Npx = "image/vnd.net-fpx";
        ///<summary>b16</summary>
        public const string B16 = "image/vnd.pco.b16";
        ///<summary>tap</summary>
        public const string Tap = "image/vnd.tencent.tap";
        ///<summary>vtf</summary>
        public const string Vtf = "image/vnd.valve.source.texture";
        ///<summary>wbmp</summary>
        public const string Wbmp = "image/vnd.wap.wbmp";
        ///<summary>xif</summary>
        public const string Xif = "image/vnd.xiff";
        ///<summary>pcx</summary>
        public const string Pcx = "image/vnd.zbrush.pcx";
        ///<summary>webp</summary>
        public const string Webp = "image/webp";
        ///<summary>3ds</summary>
        public const string _3ds = "image/x-3ds";
        ///<summary>ras</summary>
        public const string Ras = "image/x-cmu-raster";
        ///<summary>cmx</summary>
        public const string Cmx = "image/x-cmx";
        ///<summary>fh</summary>
        public const string Fh = "image/x-freehand";
        ///<summary>fhc</summary>
        public const string Fhc = "image/x-freehand";
        ///<summary>fh4</summary>
        public const string Fh4 = "image/x-freehand";
        ///<summary>fh5</summary>
        public const string Fh5 = "image/x-freehand";
        ///<summary>fh7</summary>
        public const string Fh7 = "image/x-freehand";
        ///<summary>jng</summary>
        public const string Jng = "image/x-jng";
        ///<summary>sid</summary>
        public const string Sid = "image/x-mrsid-image";
        ///<summary>pic</summary>
        public const string Pic = "image/x-pict";
        ///<summary>pct</summary>
        public const string Pct = "image/x-pict";
        ///<summary>pnm</summary>
        public const string Pnm = "image/x-portable-anymap";
        ///<summary>pbm</summary>
        public const string Pbm = "image/x-portable-bitmap";
        ///<summary>pgm</summary>
        public const string Pgm = "image/x-portable-graymap";
        ///<summary>ppm</summary>
        public const string Ppm = "image/x-portable-pixmap";
        ///<summary>rgb</summary>
        public const string Rgb = "image/x-rgb";
        ///<summary>tga</summary>
        public const string Tga = "image/x-tga";
        ///<summary>xbm</summary>
        public const string Xbm = "image/x-xbitmap";
        ///<summary>xpm</summary>
        public const string Xpm = "image/x-xpixmap";
        ///<summary>xwd</summary>
        public const string Xwd = "image/x-xwindowdump";
        ///<summary>disposition-notification</summary>
        public const string Dispositionnotification = "message/disposition-notification";
        ///<summary>u8msg</summary>
        public const string U8msg = "message/global";
        ///<summary>u8dsn</summary>
        public const string U8dsn = "message/global-delivery-status";
        ///<summary>u8mdn</summary>
        public const string U8mdn = "message/global-disposition-notification";
        ///<summary>u8hdr</summary>
        public const string U8hdr = "message/global-headers";
        ///<summary>eml</summary>
        public const string Eml = "message/rfc822";
        ///<summary>mime</summary>
        public const string Mime = "message/rfc822";
        ///<summary>wsc</summary>
        public const string Wsc = "message/vnd.wfa.wsc";
        ///<summary>3mf</summary>
        public const string _3mf = "model/3mf";
        ///<summary>gltf</summary>
        public const string Gltf = "model/gltf+json";
        ///<summary>glb</summary>
        public const string Glb = "model/gltf-binary";
        ///<summary>igs</summary>
        public const string Igs = "model/iges";
        ///<summary>iges</summary>
        public const string Iges = "model/iges";
        ///<summary>msh</summary>
        public const string Msh = "model/mesh";
        ///<summary>mesh</summary>
        public const string Mesh = "model/mesh";
        ///<summary>silo</summary>
        public const string Silo = "model/mesh";
        ///<summary>mtl</summary>
        public const string Mtl = "model/mtl";
        ///<summary>stpx</summary>
        public const string Stpx = "model/step+xml";
        ///<summary>stpz</summary>
        public const string Stpz = "model/step+zip";
        ///<summary>stpxz</summary>
        public const string Stpxz = "model/step-xml+zip";
        ///<summary>dae</summary>
        public const string Dae = "model/vnd.collada+xml";
        ///<summary>dwf</summary>
        public const string Dwf = "model/vnd.dwf";
        ///<summary>gdl</summary>
        public const string Gdl = "model/vnd.gdl";
        ///<summary>gtw</summary>
        public const string Gtw = "model/vnd.gtw";
        ///<summary>mts</summary>
        public const string Mts = "model/vnd.mts";
        ///<summary>ogex</summary>
        public const string Ogex = "model/vnd.opengex";
        ///<summary>x_b</summary>
        public const string Xb = "model/vnd.parasolid.transmit.binary";
        ///<summary>x_t</summary>
        public const string Xt = "model/vnd.parasolid.transmit.text";
        ///<summary>vds</summary>
        public const string Vds = "model/vnd.sap.vds";
        ///<summary>usdz</summary>
        public const string Usdz = "model/vnd.usdz+zip";
        ///<summary>bsp</summary>
        public const string Bsp = "model/vnd.valve.source.compiled-map";
        ///<summary>vtu</summary>
        public const string Vtu = "model/vnd.vtu";
        ///<summary>wrl</summary>
        public const string Wrl = "model/vrml";
        ///<summary>vrml</summary>
        public const string Vrml = "model/vrml";
        ///<summary>x3db</summary>
        public const string X3db = "model/x3d+binary";
        ///<summary>x3dbz</summary>
        public const string X3dbz = "model/x3d+binary";
        ///<summary>x3dv</summary>
        public const string X3dv = "model/x3d+vrml";
        ///<summary>x3dvz</summary>
        public const string X3dvz = "model/x3d+vrml";
        ///<summary>x3d</summary>
        public const string X3d = "model/x3d+xml";
        ///<summary>x3dz</summary>
        public const string X3dz = "model/x3d+xml";
        ///<summary>appcache</summary>
        public const string Appcache = "text/cache-manifest";
        ///<summary>manifest</summary>
        public const string Manifest = "text/cache-manifest";
        ///<summary>ics</summary>
        public const string Ics = "text/calendar";
        ///<summary>ifb</summary>
        public const string Ifb = "text/calendar";
        ///<summary>coffee</summary>
        public const string Coffee = "text/coffeescript";
        ///<summary>litcoffee</summary>
        public const string Litcoffee = "text/coffeescript";
        ///<summary>css</summary>
        public const string Css = "text/css";
        ///<summary>csv</summary>
        public const string Csv = "text/csv";
        ///<summary>html</summary>
        public const string Html = "text/html";
        ///<summary>htm</summary>
        public const string Htm = "text/html";
        ///<summary>shtml</summary>
        public const string Shtml = "text/html";
        ///<summary>jade</summary>
        public const string Jade = "text/jade";
        ///<summary>jsx</summary>
        public const string Jsx = "text/jsx";
        ///<summary>less</summary>
        public const string Less = "text/less";
        ///<summary>markdown</summary>
        public const string Markdown = "text/markdown";
        ///<summary>md</summary>
        public const string Md = "text/markdown";
        ///<summary>mml</summary>
        public const string Mml = "text/mathml";
        ///<summary>mdx</summary>
        public const string Mdx = "text/mdx";
        ///<summary>n3</summary>
        public const string N3 = "text/n3";
        ///<summary>txt</summary>
        public const string Txt = "text/plain";
        ///<summary>text</summary>
        public const string Text = "text/plain";
        ///<summary>conf</summary>
        public const string Conf = "text/plain";
        ///<summary>def</summary>
        public const string Def = "text/plain";
        ///<summary>list</summary>
        public const string List = "text/plain";
        ///<summary>log</summary>
        public const string Log = "text/plain";
        ///<summary>in</summary>
        public const string In = "text/plain";
        ///<summary>ini</summary>
        public const string Ini = "text/plain";
        ///<summary>dsc</summary>
        public const string Dsc = "text/prs.lines.tag";
        ///<summary>rtx</summary>
        public const string Rtx = "text/richtext";
        ///<summary>sgml</summary>
        public const string Sgml = "text/sgml";
        ///<summary>sgm</summary>
        public const string Sgm = "text/sgml";
        ///<summary>shex</summary>
        public const string Shex = "text/shex";
        ///<summary>slim</summary>
        public const string Slim = "text/slim";
        ///<summary>slm</summary>
        public const string Slm = "text/slim";
        ///<summary>spdx</summary>
        public const string Spdx = "text/spdx";
        ///<summary>stylus</summary>
        public const string Stylus = "text/stylus";
        ///<summary>styl</summary>
        public const string Styl = "text/stylus";
        ///<summary>tsv</summary>
        public const string Tsv = "text/tab-separated-values";
        ///<summary>t</summary>
        public const string T = "text/troff";
        ///<summary>tr</summary>
        public const string Tr = "text/troff";
        ///<summary>roff</summary>
        public const string Roff = "text/troff";
        ///<summary>man</summary>
        public const string Man = "text/troff";
        ///<summary>me</summary>
        public const string Me = "text/troff";
        ///<summary>ms</summary>
        public const string Ms = "text/troff";
        ///<summary>ttl</summary>
        public const string Ttl = "text/turtle";
        ///<summary>uri</summary>
        public const string Uri = "text/uri-list";
        ///<summary>uris</summary>
        public const string Uris = "text/uri-list";
        ///<summary>urls</summary>
        public const string Urls = "text/uri-list";
        ///<summary>vcard</summary>
        public const string Vcard = "text/vcard";
        ///<summary>curl</summary>
        public const string Curl = "text/vnd.curl";
        ///<summary>dcurl</summary>
        public const string Dcurl = "text/vnd.curl.dcurl";
        ///<summary>mcurl</summary>
        public const string Mcurl = "text/vnd.curl.mcurl";
        ///<summary>scurl</summary>
        public const string Scurl = "text/vnd.curl.scurl";
        ///<summary>ged</summary>
        public const string Ged = "text/vnd.familysearch.gedcom";
        ///<summary>fly</summary>
        public const string Fly = "text/vnd.fly";
        ///<summary>flx</summary>
        public const string Flx = "text/vnd.fmi.flexstor";
        ///<summary>gv</summary>
        public const string Gv = "text/vnd.graphviz";
        ///<summary>3dml</summary>
        public const string _3dml = "text/vnd.in3d.3dml";
        ///<summary>spot</summary>
        public const string Spot = "text/vnd.in3d.spot";
        ///<summary>jad</summary>
        public const string Jad = "text/vnd.sun.j2me.app-descriptor";
        ///<summary>wml</summary>
        public const string Wml = "text/vnd.wap.wml";
        ///<summary>wmls</summary>
        public const string Wmls = "text/vnd.wap.wmlscript";
        ///<summary>vtt</summary>
        public const string Vtt = "text/vtt";
        ///<summary>s</summary>
        public const string S = "text/x-asm";
        ///<summary>asm</summary>
        public const string Asm = "text/x-asm";
        ///<summary>c</summary>
        public const string C = "text/x-c";
        ///<summary>cc</summary>
        public const string Cc = "text/x-c";
        ///<summary>cxx</summary>
        public const string Cxx = "text/x-c";
        ///<summary>cpp</summary>
        public const string Cpp = "text/x-c";
        ///<summary>h</summary>
        public const string H = "text/x-c";
        ///<summary>hh</summary>
        public const string Hh = "text/x-c";
        ///<summary>dic</summary>
        public const string Dic = "text/x-c";
        ///<summary>htc</summary>
        public const string Htc = "text/x-component";
        ///<summary>f</summary>
        public const string F = "text/x-fortran";
        ///<summary>for</summary>
        public const string For = "text/x-fortran";
        ///<summary>f77</summary>
        public const string F77 = "text/x-fortran";
        ///<summary>f90</summary>
        public const string F90 = "text/x-fortran";
        ///<summary>hbs</summary>
        public const string Hbs = "text/x-handlebars-template";
        ///<summary>java</summary>
        public const string Java = "text/x-java-source";
        ///<summary>lua</summary>
        public const string Lua = "text/x-lua";
        ///<summary>mkd</summary>
        public const string Mkd = "text/x-markdown";
        ///<summary>nfo</summary>
        public const string Nfo = "text/x-nfo";
        ///<summary>opml</summary>
        public const string Opml = "text/x-opml";
        ///<summary>p</summary>
        public const string P = "text/x-pascal";
        ///<summary>pas</summary>
        public const string Pas = "text/x-pascal";
        ///<summary>pde</summary>
        public const string Pde = "text/x-processing";
        ///<summary>sass</summary>
        public const string Sass = "text/x-sass";
        ///<summary>scss</summary>
        public const string Scss = "text/x-scss";
        ///<summary>etx</summary>
        public const string Etx = "text/x-setext";
        ///<summary>sfv</summary>
        public const string Sfv = "text/x-sfv";
        ///<summary>ymp</summary>
        public const string Ymp = "text/x-suse-ymp";
        ///<summary>uu</summary>
        public const string Uu = "text/x-uuencode";
        ///<summary>vcs</summary>
        public const string Vcs = "text/x-vcalendar";
        ///<summary>vcf</summary>
        public const string Vcf = "text/x-vcard";
        ///<summary>yaml</summary>
        public const string Yaml = "text/yaml";
        ///<summary>yml</summary>
        public const string Yml = "text/yaml";
        ///<summary>3gp</summary>
        public const string _3gp = "video/3gpp";
        ///<summary>3g2</summary>
        public const string _3g2 = "video/3gpp2";
        ///<summary>h261</summary>
        public const string H261 = "video/h261";
        ///<summary>h263</summary>
        public const string H263 = "video/h263";
        ///<summary>h264</summary>
        public const string H264 = "video/h264";
        ///<summary>m4s</summary>
        public const string M4s = "video/iso.segment";
        ///<summary>jpgv</summary>
        public const string Jpgv = "video/jpeg";
        ///<summary>jpgm</summary>
        public const string Jpgm = "video/jpm";
        ///<summary>mj2</summary>
        public const string Mj2 = "video/mj2";
        ///<summary>mjp2</summary>
        public const string Mjp2 = "video/mj2";
        ///<summary>ts</summary>
        public const string Ts = "video/mp2t";
        ///<summary>mp4</summary>
        public const string Mp4 = "video/mp4";
        ///<summary>mp4v</summary>
        public const string Mp4v = "video/mp4";
        ///<summary>mpg4</summary>
        public const string Mpg4 = "video/mp4";
        ///<summary>mpeg</summary>
        public const string Mpeg = "video/mpeg";
        ///<summary>mpg</summary>
        public const string Mpg = "video/mpeg";
        ///<summary>mpe</summary>
        public const string Mpe = "video/mpeg";
        ///<summary>m1v</summary>
        public const string M1v = "video/mpeg";
        ///<summary>m2v</summary>
        public const string M2v = "video/mpeg";
        ///<summary>ogv</summary>
        public const string Ogv = "video/ogg";
        ///<summary>qt</summary>
        public const string Qt = "video/quicktime";
        ///<summary>mov</summary>
        public const string Mov = "video/quicktime";
        ///<summary>uvh</summary>
        public const string Uvh = "video/vnd.dece.hd";
        ///<summary>uvvh</summary>
        public const string Uvvh = "video/vnd.dece.hd";
        ///<summary>uvm</summary>
        public const string Uvm = "video/vnd.dece.mobile";
        ///<summary>uvvm</summary>
        public const string Uvvm = "video/vnd.dece.mobile";
        ///<summary>uvp</summary>
        public const string Uvp = "video/vnd.dece.pd";
        ///<summary>uvvp</summary>
        public const string Uvvp = "video/vnd.dece.pd";
        ///<summary>uvs</summary>
        public const string Uvs = "video/vnd.dece.sd";
        ///<summary>uvvs</summary>
        public const string Uvvs = "video/vnd.dece.sd";
        ///<summary>uvv</summary>
        public const string Uvv = "video/vnd.dece.video";
        ///<summary>uvvv</summary>
        public const string Uvvv = "video/vnd.dece.video";
        ///<summary>dvb</summary>
        public const string Dvb = "video/vnd.dvb.file";
        ///<summary>fvt</summary>
        public const string Fvt = "video/vnd.fvt";
        ///<summary>mxu</summary>
        public const string Mxu = "video/vnd.mpegurl";
        ///<summary>m4u</summary>
        public const string M4u = "video/vnd.mpegurl";
        ///<summary>pyv</summary>
        public const string Pyv = "video/vnd.ms-playready.media.pyv";
        ///<summary>uvu</summary>
        public const string Uvu = "video/vnd.uvvu.mp4";
        ///<summary>uvvu</summary>
        public const string Uvvu = "video/vnd.uvvu.mp4";
        ///<summary>viv</summary>
        public const string Viv = "video/vnd.vivo";
        ///<summary>webm</summary>
        public const string Webm = "video/webm";
        ///<summary>f4v</summary>
        public const string F4v = "video/x-f4v";
        ///<summary>fli</summary>
        public const string Fli = "video/x-fli";
        ///<summary>flv</summary>
        public const string Flv = "video/x-flv";
        ///<summary>m4v</summary>
        public const string M4v = "video/x-m4v";
        ///<summary>mkv</summary>
        public const string Mkv = "video/x-matroska";
        ///<summary>mk3d</summary>
        public const string Mk3d = "video/x-matroska";
        ///<summary>mks</summary>
        public const string Mks = "video/x-matroska";
        ///<summary>mng</summary>
        public const string Mng = "video/x-mng";
        ///<summary>asf</summary>
        public const string Asf = "video/x-ms-asf";
        ///<summary>asx</summary>
        public const string Asx = "video/x-ms-asf";
        ///<summary>vob</summary>
        public const string Vob = "video/x-ms-vob";
        ///<summary>wm</summary>
        public const string Wm = "video/x-ms-wm";
        ///<summary>wmv</summary>
        public const string Wmv = "video/x-ms-wmv";
        ///<summary>wmx</summary>
        public const string Wmx = "video/x-ms-wmx";
        ///<summary>wvx</summary>
        public const string Wvx = "video/x-ms-wvx";
        ///<summary>avi</summary>
        public const string Avi = "video/x-msvideo";
        ///<summary>movie</summary>
        public const string Movie = "video/x-sgi-movie";
        ///<summary>smv</summary>
        public const string Smv = "video/x-smv";
        ///<summary>ice</summary>
        public const string Ice = "x-conference/x-cooltalk";
        // List of all available mimetypes, used to build the dictionary
        internal static readonly Lazy<string[]> ALL_MIMETYPES = new Lazy<string[]>(() => new [] {
            Ez,
            Aw,
            Atom,
            Atomcat,
            Atomdeleted,
            Atomsvc,
            Dwd,
            Held,
            Rsat,
            Bdoc,
            Xcs,
            Ccxml,
            Cdfx,
            Cdmia,
            Cdmic,
            Cdmid,
            Cdmio,
            Cdmiq,
            Cpl,
            Cu,
            Mpd,
            Mpp,
            Davmount,
            Dbk,
            Dssc,
            Xdssc,
            Es,
            Ecma,
            Emma,
            Emotionml,
            Epub,
            Exi,
            Exp,
            Fdt,
            Pfr,
            Geojson,
            Gml,
            Gpx,
            Gxf,
            Gz,
            Hjson,
            Stk,
            Ink,
            Inkml,
            Ipfix,
            Its,
            Jar,
            War,
            Ear,
            Ser,
            Class,
            Js,
            Mjs,
            Json,
            Map,
            Json5,
            Jsonml,
            Jsonld,
            Lgr,
            Lostxml,
            Hqx,
            Cpt,
            Mads,
            Webmanifest,
            Mrc,
            Mrcx,
            Ma,
            Nb,
            Mb,
            Mathml,
            Mbox,
            Mpf,
            Mscml,
            Metalink,
            Meta4,
            Mets,
            Maei,
            Musd,
            Mods,
            M21,
            Mp21,
            Mp4s,
            M4p,
            Doc,
            Dot,
            Mxf,
            Nq,
            Nt,
            Cjs,
            Bin,
            Dms,
            Lrf,
            Mar,
            So,
            Dist,
            Distz,
            Pkg,
            Bpk,
            Dump,
            Elc,
            Deploy,
            Exe,
            Dll,
            Deb,
            Dmg,
            Iso,
            Img,
            Msi,
            Msp,
            Msm,
            Buffer,
            Oda,
            Opf,
            Ogx,
            Omdoc,
            Onetoc,
            Onetoc2,
            Onetmp,
            Onepkg,
            Oxps,
            Relo,
            Xer,
            Pdf,
            Pgp,
            Asc,
            Sig,
            Prf,
            P10,
            P7m,
            P7c,
            P7s,
            P8,
            Ac,
            Cer,
            Crl,
            Pkipath,
            Pki,
            Pls,
            Ai,
            Eps,
            Ps,
            Provx,
            Cww,
            Pskcxml,
            Raml,
            Rdf,
            Owl,
            Rif,
            Rnc,
            Rl,
            Rld,
            Rs,
            Rapd,
            Sls,
            Rusd,
            Gbr,
            Mft,
            Roa,
            Rsd,
            Rss,
            Rtf,
            Sbml,
            Scq,
            Scs,
            Spq,
            Spp,
            Sdp,
            Senmlx,
            Sensmlx,
            Setpay,
            Setreg,
            Shf,
            Siv,
            Sieve,
            Smi,
            Smil,
            Rq,
            Srx,
            Gram,
            Grxml,
            Sru,
            Ssdl,
            Ssml,
            Swidtag,
            Tei,
            Teicorpus,
            Tfi,
            Tsd,
            Toml,
            Trig,
            Ttml,
            Ubj,
            Rsheet,
            Td,
            _1km,
            Plb,
            Psb,
            Pvb,
            Tcap,
            Pwn,
            Aso,
            Imp,
            Acu,
            Atc,
            Acutc,
            Air,
            Fcdt,
            Fxp,
            Fxpl,
            Xdp,
            Xfdf,
            Age,
            Ahead,
            Azf,
            Azs,
            Azw,
            Acc,
            Ami,
            Apk,
            Cii,
            Fti,
            Atx,
            Mpkg,
            Key,
            M3u8,
            Numbers,
            Pages,
            Pkpass,
            Swi,
            Iota,
            Aep,
            Bmml,
            Mpm,
            Bmi,
            Rep,
            Cdxml,
            Mmd,
            Cdy,
            Csl,
            Cla,
            Rp9,
            C4g,
            C4d,
            C4f,
            C4p,
            C4u,
            C11amc,
            C11amz,
            Csp,
            Cdbcmsg,
            Cmc,
            Clkx,
            Clkk,
            Clkp,
            Clkt,
            Clkw,
            Wbs,
            Pml,
            Ppd,
            Car,
            Pcurl,
            Dart,
            Rdz,
            Dbf,
            Uvf,
            Uvvf,
            Uvd,
            Uvvd,
            Uvt,
            Uvvt,
            Uvx,
            Uvvx,
            Uvz,
            Uvvz,
            Felaunch,
            Dna,
            Mlp,
            Dpg,
            Dfac,
            Kpxx,
            Ait,
            Svc,
            Geo,
            Mag,
            Nml,
            Esf,
            Msf,
            Qam,
            Slt,
            Ssf,
            Es3,
            Et3,
            Ez2,
            Ez3,
            Fdf,
            Mseed,
            Seed,
            Dataless,
            Gph,
            Ftc,
            Fm,
            Frame,
            Maker,
            Book,
            Fnc,
            Ltf,
            Fsc,
            Oas,
            Oa2,
            Oa3,
            Fg5,
            Bh2,
            Ddd,
            Xdw,
            Xbd,
            Fzs,
            Txd,
            Ggb,
            Ggt,
            Gex,
            Gre,
            Gxt,
            G2w,
            G3w,
            Gmx,
            Gdoc,
            Gslides,
            Gsheet,
            Kml,
            Kmz,
            Gqf,
            Gqs,
            Gac,
            Ghf,
            Gim,
            Grv,
            Gtm,
            Tpl,
            Vcg,
            Hal,
            Zmm,
            Hbci,
            Les,
            Hpgl,
            Hpid,
            Hps,
            Jlt,
            Pcl,
            Pclxl,
            Sfdhdstx,
            Mpy,
            Afp,
            Listafp,
            List3820,
            Irm,
            Sc,
            Icc,
            Icm,
            Igl,
            Ivp,
            Ivu,
            Igm,
            Xpw,
            Xpx,
            I2g,
            Qbo,
            Qfx,
            Rcprofile,
            Irp,
            Xpr,
            Fcs,
            Jam,
            Rms,
            Jisp,
            Joda,
            Ktz,
            Ktr,
            Karbon,
            Chrt,
            Kfo,
            Flw,
            Kon,
            Kpr,
            Kpt,
            Ksp,
            Kwd,
            Kwt,
            Htke,
            Kia,
            Kne,
            Knp,
            Skp,
            Skd,
            Skt,
            Skm,
            Sse,
            Lasxml,
            Lbd,
            Lbe,
            _123,
            Apr,
            Pre,
            Nsf,
            Org,
            Scm,
            Lwp,
            Portpkg,
            Mvt,
            Mcd,
            Mc1,
            Cdkey,
            Mwf,
            Mfm,
            Flo,
            Igx,
            Mif,
            Daf,
            Dis,
            Mbk,
            Mqy,
            Msl,
            Plc,
            Txf,
            Mpn,
            Mpc,
            Xul,
            Cil,
            Cab,
            Xls,
            Xlm,
            Xla,
            Xlc,
            Xlt,
            Xlw,
            Xlam,
            Xlsb,
            Xlsm,
            Xltm,
            Eot,
            Chm,
            Ims,
            Lrm,
            Thmx,
            Msg,
            Cat,
            Stl,
            Ppt,
            Pps,
            Pot,
            Ppam,
            Pptm,
            Sldm,
            Ppsm,
            Potm,
            Mpt,
            Docm,
            Dotm,
            Wps,
            Wks,
            Wcm,
            Wdb,
            Wpl,
            Xps,
            Mseq,
            Mus,
            Msty,
            Taglet,
            Nlu,
            Ntf,
            Nitf,
            Nnd,
            Nns,
            Nnw,
            Ngdat,
            Ngage,
            Rpst,
            Rpss,
            Edm,
            Edx,
            Ext,
            Odc,
            Otc,
            Odb,
            Odf,
            Odft,
            Odg,
            Otg,
            Odi,
            Oti,
            Odp,
            Otp,
            Ods,
            Ots,
            Odt,
            Odm,
            Ott,
            Oth,
            Xo,
            Dd2,
            Obgx,
            Oxt,
            Osm,
            Pptx,
            Sldx,
            Ppsx,
            Potx,
            Xlsx,
            Xltx,
            Docx,
            Dotx,
            Mgp,
            Dp,
            Esa,
            Pdb,
            Pqa,
            Oprc,
            Paw,
            Str,
            Ei6,
            Efif,
            Wg,
            Plf,
            Pbd,
            Box,
            Mgz,
            Qps,
            Ptid,
            Qxd,
            Qxt,
            Qwd,
            Qwt,
            Qxl,
            Qxb,
            Rar,
            Bed,
            Mxl,
            Musicxml,
            Cryptonote,
            Cod,
            Rm,
            Rmvb,
            Link66,
            St,
            See,
            Sema,
            Semd,
            Semf,
            Ifm,
            Itp,
            Iif,
            Ipk,
            Twd,
            Twds,
            Mmf,
            Teacher,
            Fo,
            Sdkm,
            Sdkd,
            Dxp,
            Sfs,
            Sdc,
            Sda,
            Sdd,
            Smf,
            Sdw,
            Vor,
            Sgl,
            Smzip,
            Sm,
            Wadl,
            Sxc,
            Stc,
            Sxd,
            Std,
            Sxi,
            Sti,
            Sxm,
            Sxw,
            Sxg,
            Stw,
            Sus,
            Susp,
            Svd,
            Sis,
            Sisx,
            Xsm,
            Bdm,
            Xdm,
            Ddf,
            Tao,
            Pcap,
            Cap,
            Dmp,
            Tmo,
            Tpt,
            Mxs,
            Tra,
            Ufd,
            Ufdl,
            Utz,
            Umj,
            Unityweb,
            Uoml,
            Vcx,
            Vsd,
            Vst,
            Vss,
            Vsw,
            Vis,
            Vsf,
            Wbxml,
            Wmlc,
            Wmlsc,
            Wtb,
            Nbp,
            Wpd,
            Wqd,
            Stf,
            Xar,
            Xfdl,
            Hvd,
            Hvs,
            Hvp,
            Osf,
            Osfpvg,
            Saf,
            Spf,
            Cmp,
            Zir,
            Zirz,
            Zaz,
            Vxml,
            Wasm,
            Wif,
            Wgt,
            Hlp,
            Wsdl,
            Wspolicy,
            _7z,
            Abw,
            Ace,
            Arj,
            Aab,
            X32,
            U32,
            Vox,
            Aam,
            Aas,
            Bcpio,
            Torrent,
            Blb,
            Blorb,
            Bz,
            Bz2,
            Boz,
            Cbr,
            Cba,
            Cbt,
            Cbz,
            Cb7,
            Vcd,
            Cfs,
            Chat,
            Pgn,
            Crx,
            Cco,
            Nsc,
            Cpio,
            Csh,
            Udeb,
            Dgc,
            Dir,
            Dcr,
            Dxr,
            Cst,
            Cct,
            Cxt,
            W3d,
            Fgd,
            Swa,
            Wad,
            Ncx,
            Dtb,
            Res,
            Dvi,
            Evy,
            Eva,
            Bdf,
            Gsf,
            Psf,
            Pcf,
            Snf,
            Pfa,
            Pfb,
            Pfm,
            Afm,
            Arc,
            Spl,
            Gca,
            Ulx,
            Gnumeric,
            Gramps,
            Gtar,
            Hdf,
            Php,
            Install,
            Jardiff,
            Jnlp,
            Kdbx,
            Latex,
            Luac,
            Lzh,
            Lha,
            Run,
            Mie,
            Prc,
            Mobi,
            Application,
            Lnk,
            Wmd,
            Wmz,
            Xbap,
            Mdb,
            Obd,
            Crd,
            Clp,
            Com,
            Bat,
            Mvb,
            M13,
            M14,
            Wmf,
            Emf,
            Emz,
            Mny,
            Pub,
            Scd,
            Trm,
            Wri,
            Nc,
            Cdf,
            Pac,
            Nzb,
            Pl,
            Pm,
            P12,
            Pfx,
            P7b,
            Spc,
            P7r,
            Rpm,
            Ris,
            Sea,
            Sh,
            Shar,
            Swf,
            Xap,
            Sql,
            Sit,
            Sitx,
            Srt,
            Sv4cpio,
            Sv4crc,
            T3,
            Gam,
            Tar,
            Tcl,
            Tk,
            Tex,
            Tfm,
            Texinfo,
            Texi,
            Obj,
            Ustar,
            Hdd,
            Ova,
            Ovf,
            Vbox,
            Vboxextpack,
            Vdi,
            Vhd,
            Vmdk,
            Src,
            Webapp,
            Der,
            Crt,
            Pem,
            Fig,
            Xlf,
            Xpi,
            Xz,
            Z1,
            Z2,
            Z3,
            Z4,
            Z5,
            Z6,
            Z7,
            Z8,
            Xaml,
            Xav,
            Xca,
            Xdf,
            Xel,
            Xns,
            Xenc,
            Xhtml,
            Xht,
            Xml,
            Xsl,
            Xsd,
            Rng,
            Dtd,
            Xop,
            Xpl,
            Xslt,
            Xspf,
            Mxml,
            Xhvml,
            Xvml,
            Xvm,
            Yang,
            Yin,
            Zip,
            _3gpp,
            Adp,
            Amr,
            Au,
            Snd,
            Mid,
            Midi,
            Kar,
            Rmi,
            Mxmf,
            Mp3,
            M4a,
            Mp4a,
            Mpga,
            Mp2,
            Mp2a,
            M2a,
            M3a,
            Oga,
            Ogg,
            Spx,
            Opus,
            S3m,
            Sil,
            Uva,
            Uvva,
            Eol,
            Dra,
            Dts,
            Dtshd,
            Lvp,
            Pya,
            Ecelp4800,
            Ecelp7470,
            Ecelp9600,
            Rip,
            Wav,
            Weba,
            Aac,
            Aif,
            Aiff,
            Aifc,
            Caf,
            Flac,
            Mka,
            M3u,
            Wax,
            Wma,
            Ram,
            Ra,
            Rmp,
            Xm,
            Cdx,
            Cif,
            Cmdf,
            Cml,
            Csml,
            Xyz,
            Ttc,
            Otf,
            Ttf,
            Woff,
            Woff2,
            Exr,
            Apng,
            Avci,
            Avcs,
            Avif,
            Bmp,
            Cgm,
            Drle,
            Fits,
            G3,
            Gif,
            Heic,
            Heics,
            Heif,
            Heifs,
            Hej2,
            Hsj2,
            Ief,
            Jls,
            Jp2,
            Jpg2,
            Jpeg,
            Jpg,
            Jpe,
            Jph,
            Jhc,
            Jpm,
            Jpx,
            Jpf,
            Jxr,
            Jxra,
            Jxrs,
            Jxs,
            Jxsc,
            Jxsi,
            Jxss,
            Ktx,
            Ktx2,
            Png,
            Btif,
            Pti,
            Sgi,
            Svg,
            Svgz,
            T38,
            Tif,
            Tiff,
            Tfx,
            Psd,
            Azv,
            Uvi,
            Uvvi,
            Uvg,
            Uvvg,
            Djvu,
            Djv,
            Sub,
            Dwg,
            Dxf,
            Fbs,
            Fpx,
            Fst,
            Mmr,
            Rlc,
            Ico,
            Dds,
            Mdi,
            Wdp,
            Npx,
            B16,
            Tap,
            Vtf,
            Wbmp,
            Xif,
            Pcx,
            Webp,
            _3ds,
            Ras,
            Cmx,
            Fh,
            Fhc,
            Fh4,
            Fh5,
            Fh7,
            Jng,
            Sid,
            Pic,
            Pct,
            Pnm,
            Pbm,
            Pgm,
            Ppm,
            Rgb,
            Tga,
            Xbm,
            Xpm,
            Xwd,
            Dispositionnotification,
            U8msg,
            U8dsn,
            U8mdn,
            U8hdr,
            Eml,
            Mime,
            Wsc,
            _3mf,
            Gltf,
            Glb,
            Igs,
            Iges,
            Msh,
            Mesh,
            Silo,
            Mtl,
            Stpx,
            Stpz,
            Stpxz,
            Dae,
            Dwf,
            Gdl,
            Gtw,
            Mts,
            Ogex,
            Xb,
            Xt,
            Vds,
            Usdz,
            Bsp,
            Vtu,
            Wrl,
            Vrml,
            X3db,
            X3dbz,
            X3dv,
            X3dvz,
            X3d,
            X3dz,
            Appcache,
            Manifest,
            Ics,
            Ifb,
            Coffee,
            Litcoffee,
            Css,
            Csv,
            Html,
            Htm,
            Shtml,
            Jade,
            Jsx,
            Less,
            Markdown,
            Md,
            Mml,
            Mdx,
            N3,
            Txt,
            Text,
            Conf,
            Def,
            List,
            Log,
            In,
            Ini,
            Dsc,
            Rtx,
            Sgml,
            Sgm,
            Shex,
            Slim,
            Slm,
            Spdx,
            Stylus,
            Styl,
            Tsv,
            T,
            Tr,
            Roff,
            Man,
            Me,
            Ms,
            Ttl,
            Uri,
            Uris,
            Urls,
            Vcard,
            Curl,
            Dcurl,
            Mcurl,
            Scurl,
            Ged,
            Fly,
            Flx,
            Gv,
            _3dml,
            Spot,
            Jad,
            Wml,
            Wmls,
            Vtt,
            S,
            Asm,
            C,
            Cc,
            Cxx,
            Cpp,
            H,
            Hh,
            Dic,
            Htc,
            F,
            For,
            F77,
            F90,
            Hbs,
            Java,
            Lua,
            Mkd,
            Nfo,
            Opml,
            P,
            Pas,
            Pde,
            Sass,
            Scss,
            Etx,
            Sfv,
            Ymp,
            Uu,
            Vcs,
            Vcf,
            Yaml,
            Yml,
            _3gp,
            _3g2,
            H261,
            H263,
            H264,
            M4s,
            Jpgv,
            Jpgm,
            Mj2,
            Mjp2,
            Ts,
            Mp4,
            Mp4v,
            Mpg4,
            Mpeg,
            Mpg,
            Mpe,
            M1v,
            M2v,
            Ogv,
            Qt,
            Mov,
            Uvh,
            Uvvh,
            Uvm,
            Uvvm,
            Uvp,
            Uvvp,
            Uvs,
            Uvvs,
            Uvv,
            Uvvv,
            Dvb,
            Fvt,
            Mxu,
            M4u,
            Pyv,
            Uvu,
            Uvvu,
            Viv,
            Webm,
            F4v,
            Fli,
            Flv,
            M4v,
            Mkv,
            Mk3d,
            Mks,
            Mng,
            Asf,
            Asx,
            Vob,
            Wm,
            Wmv,
            Wmx,
            Wvx,
            Avi,
            Movie,
            Smv,
            Ice,
        });


        ///<summary>File extensions</summary>
        public static class FileExtensions
        {
            ///<summary>ez</summary>
            public const string Ez = "ez";
            ///<summary>aw</summary>
            public const string Aw = "aw";
            ///<summary>atom</summary>
            public const string Atom = "atom";
            ///<summary>atomcat</summary>
            public const string Atomcat = "atomcat";
            ///<summary>atomdeleted</summary>
            public const string Atomdeleted = "atomdeleted";
            ///<summary>atomsvc</summary>
            public const string Atomsvc = "atomsvc";
            ///<summary>dwd</summary>
            public const string Dwd = "dwd";
            ///<summary>held</summary>
            public const string Held = "held";
            ///<summary>rsat</summary>
            public const string Rsat = "rsat";
            ///<summary>bdoc</summary>
            public const string Bdoc = "bdoc";
            ///<summary>xcs</summary>
            public const string Xcs = "xcs";
            ///<summary>ccxml</summary>
            public const string Ccxml = "ccxml";
            ///<summary>cdfx</summary>
            public const string Cdfx = "cdfx";
            ///<summary>cdmia</summary>
            public const string Cdmia = "cdmia";
            ///<summary>cdmic</summary>
            public const string Cdmic = "cdmic";
            ///<summary>cdmid</summary>
            public const string Cdmid = "cdmid";
            ///<summary>cdmio</summary>
            public const string Cdmio = "cdmio";
            ///<summary>cdmiq</summary>
            public const string Cdmiq = "cdmiq";
            ///<summary>cpl</summary>
            public const string Cpl = "cpl";
            ///<summary>cu</summary>
            public const string Cu = "cu";
            ///<summary>mpd</summary>
            public const string Mpd = "mpd";
            ///<summary>mpp</summary>
            public const string Mpp = "mpp";
            ///<summary>davmount</summary>
            public const string Davmount = "davmount";
            ///<summary>dbk</summary>
            public const string Dbk = "dbk";
            ///<summary>dssc</summary>
            public const string Dssc = "dssc";
            ///<summary>xdssc</summary>
            public const string Xdssc = "xdssc";
            ///<summary>es</summary>
            public const string Es = "es";
            ///<summary>ecma</summary>
            public const string Ecma = "ecma";
            ///<summary>emma</summary>
            public const string Emma = "emma";
            ///<summary>emotionml</summary>
            public const string Emotionml = "emotionml";
            ///<summary>epub</summary>
            public const string Epub = "epub";
            ///<summary>exi</summary>
            public const string Exi = "exi";
            ///<summary>exp</summary>
            public const string Exp = "exp";
            ///<summary>fdt</summary>
            public const string Fdt = "fdt";
            ///<summary>pfr</summary>
            public const string Pfr = "pfr";
            ///<summary>geojson</summary>
            public const string Geojson = "geojson";
            ///<summary>gml</summary>
            public const string Gml = "gml";
            ///<summary>gpx</summary>
            public const string Gpx = "gpx";
            ///<summary>gxf</summary>
            public const string Gxf = "gxf";
            ///<summary>gz</summary>
            public const string Gz = "gz";
            ///<summary>hjson</summary>
            public const string Hjson = "hjson";
            ///<summary>stk</summary>
            public const string Stk = "stk";
            ///<summary>ink</summary>
            public const string Ink = "ink";
            ///<summary>inkml</summary>
            public const string Inkml = "inkml";
            ///<summary>ipfix</summary>
            public const string Ipfix = "ipfix";
            ///<summary>its</summary>
            public const string Its = "its";
            ///<summary>jar</summary>
            public const string Jar = "jar";
            ///<summary>war</summary>
            public const string War = "war";
            ///<summary>ear</summary>
            public const string Ear = "ear";
            ///<summary>ser</summary>
            public const string Ser = "ser";
            ///<summary>class</summary>
            public const string Class = "class";
            ///<summary>js</summary>
            public const string Js = "js";
            ///<summary>mjs</summary>
            public const string Mjs = "mjs";
            ///<summary>json</summary>
            public const string Json = "json";
            ///<summary>map</summary>
            public const string Map = "map";
            ///<summary>json5</summary>
            public const string Json5 = "json5";
            ///<summary>jsonml</summary>
            public const string Jsonml = "jsonml";
            ///<summary>jsonld</summary>
            public const string Jsonld = "jsonld";
            ///<summary>lgr</summary>
            public const string Lgr = "lgr";
            ///<summary>lostxml</summary>
            public const string Lostxml = "lostxml";
            ///<summary>hqx</summary>
            public const string Hqx = "hqx";
            ///<summary>cpt</summary>
            public const string Cpt = "cpt";
            ///<summary>mads</summary>
            public const string Mads = "mads";
            ///<summary>webmanifest</summary>
            public const string Webmanifest = "webmanifest";
            ///<summary>mrc</summary>
            public const string Mrc = "mrc";
            ///<summary>mrcx</summary>
            public const string Mrcx = "mrcx";
            ///<summary>ma</summary>
            public const string Ma = "ma";
            ///<summary>nb</summary>
            public const string Nb = "nb";
            ///<summary>mb</summary>
            public const string Mb = "mb";
            ///<summary>mathml</summary>
            public const string Mathml = "mathml";
            ///<summary>mbox</summary>
            public const string Mbox = "mbox";
            ///<summary>mpf</summary>
            public const string Mpf = "mpf";
            ///<summary>mscml</summary>
            public const string Mscml = "mscml";
            ///<summary>metalink</summary>
            public const string Metalink = "metalink";
            ///<summary>meta4</summary>
            public const string Meta4 = "meta4";
            ///<summary>mets</summary>
            public const string Mets = "mets";
            ///<summary>maei</summary>
            public const string Maei = "maei";
            ///<summary>musd</summary>
            public const string Musd = "musd";
            ///<summary>mods</summary>
            public const string Mods = "mods";
            ///<summary>m21</summary>
            public const string M21 = "m21";
            ///<summary>mp21</summary>
            public const string Mp21 = "mp21";
            ///<summary>mp4s</summary>
            public const string Mp4s = "mp4s";
            ///<summary>m4p</summary>
            public const string M4p = "m4p";
            ///<summary>doc</summary>
            public const string Doc = "doc";
            ///<summary>dot</summary>
            public const string Dot = "dot";
            ///<summary>mxf</summary>
            public const string Mxf = "mxf";
            ///<summary>nq</summary>
            public const string Nq = "nq";
            ///<summary>nt</summary>
            public const string Nt = "nt";
            ///<summary>cjs</summary>
            public const string Cjs = "cjs";
            ///<summary>bin</summary>
            public const string Bin = "bin";
            ///<summary>dms</summary>
            public const string Dms = "dms";
            ///<summary>lrf</summary>
            public const string Lrf = "lrf";
            ///<summary>mar</summary>
            public const string Mar = "mar";
            ///<summary>so</summary>
            public const string So = "so";
            ///<summary>dist</summary>
            public const string Dist = "dist";
            ///<summary>distz</summary>
            public const string Distz = "distz";
            ///<summary>pkg</summary>
            public const string Pkg = "pkg";
            ///<summary>bpk</summary>
            public const string Bpk = "bpk";
            ///<summary>dump</summary>
            public const string Dump = "dump";
            ///<summary>elc</summary>
            public const string Elc = "elc";
            ///<summary>deploy</summary>
            public const string Deploy = "deploy";
            ///<summary>exe</summary>
            public const string Exe = "exe";
            ///<summary>dll</summary>
            public const string Dll = "dll";
            ///<summary>deb</summary>
            public const string Deb = "deb";
            ///<summary>dmg</summary>
            public const string Dmg = "dmg";
            ///<summary>iso</summary>
            public const string Iso = "iso";
            ///<summary>img</summary>
            public const string Img = "img";
            ///<summary>msi</summary>
            public const string Msi = "msi";
            ///<summary>msp</summary>
            public const string Msp = "msp";
            ///<summary>msm</summary>
            public const string Msm = "msm";
            ///<summary>buffer</summary>
            public const string Buffer = "buffer";
            ///<summary>oda</summary>
            public const string Oda = "oda";
            ///<summary>opf</summary>
            public const string Opf = "opf";
            ///<summary>ogx</summary>
            public const string Ogx = "ogx";
            ///<summary>omdoc</summary>
            public const string Omdoc = "omdoc";
            ///<summary>onetoc</summary>
            public const string Onetoc = "onetoc";
            ///<summary>onetoc2</summary>
            public const string Onetoc2 = "onetoc2";
            ///<summary>onetmp</summary>
            public const string Onetmp = "onetmp";
            ///<summary>onepkg</summary>
            public const string Onepkg = "onepkg";
            ///<summary>oxps</summary>
            public const string Oxps = "oxps";
            ///<summary>relo</summary>
            public const string Relo = "relo";
            ///<summary>xer</summary>
            public const string Xer = "xer";
            ///<summary>pdf</summary>
            public const string Pdf = "pdf";
            ///<summary>pgp</summary>
            public const string Pgp = "pgp";
            ///<summary>asc</summary>
            public const string Asc = "asc";
            ///<summary>sig</summary>
            public const string Sig = "sig";
            ///<summary>prf</summary>
            public const string Prf = "prf";
            ///<summary>p10</summary>
            public const string P10 = "p10";
            ///<summary>p7m</summary>
            public const string P7m = "p7m";
            ///<summary>p7c</summary>
            public const string P7c = "p7c";
            ///<summary>p7s</summary>
            public const string P7s = "p7s";
            ///<summary>p8</summary>
            public const string P8 = "p8";
            ///<summary>ac</summary>
            public const string Ac = "ac";
            ///<summary>cer</summary>
            public const string Cer = "cer";
            ///<summary>crl</summary>
            public const string Crl = "crl";
            ///<summary>pkipath</summary>
            public const string Pkipath = "pkipath";
            ///<summary>pki</summary>
            public const string Pki = "pki";
            ///<summary>pls</summary>
            public const string Pls = "pls";
            ///<summary>ai</summary>
            public const string Ai = "ai";
            ///<summary>eps</summary>
            public const string Eps = "eps";
            ///<summary>ps</summary>
            public const string Ps = "ps";
            ///<summary>provx</summary>
            public const string Provx = "provx";
            ///<summary>cww</summary>
            public const string Cww = "cww";
            ///<summary>pskcxml</summary>
            public const string Pskcxml = "pskcxml";
            ///<summary>raml</summary>
            public const string Raml = "raml";
            ///<summary>rdf</summary>
            public const string Rdf = "rdf";
            ///<summary>owl</summary>
            public const string Owl = "owl";
            ///<summary>rif</summary>
            public const string Rif = "rif";
            ///<summary>rnc</summary>
            public const string Rnc = "rnc";
            ///<summary>rl</summary>
            public const string Rl = "rl";
            ///<summary>rld</summary>
            public const string Rld = "rld";
            ///<summary>rs</summary>
            public const string Rs = "rs";
            ///<summary>rapd</summary>
            public const string Rapd = "rapd";
            ///<summary>sls</summary>
            public const string Sls = "sls";
            ///<summary>rusd</summary>
            public const string Rusd = "rusd";
            ///<summary>gbr</summary>
            public const string Gbr = "gbr";
            ///<summary>mft</summary>
            public const string Mft = "mft";
            ///<summary>roa</summary>
            public const string Roa = "roa";
            ///<summary>rsd</summary>
            public const string Rsd = "rsd";
            ///<summary>rss</summary>
            public const string Rss = "rss";
            ///<summary>rtf</summary>
            public const string Rtf = "rtf";
            ///<summary>sbml</summary>
            public const string Sbml = "sbml";
            ///<summary>scq</summary>
            public const string Scq = "scq";
            ///<summary>scs</summary>
            public const string Scs = "scs";
            ///<summary>spq</summary>
            public const string Spq = "spq";
            ///<summary>spp</summary>
            public const string Spp = "spp";
            ///<summary>sdp</summary>
            public const string Sdp = "sdp";
            ///<summary>senmlx</summary>
            public const string Senmlx = "senmlx";
            ///<summary>sensmlx</summary>
            public const string Sensmlx = "sensmlx";
            ///<summary>setpay</summary>
            public const string Setpay = "setpay";
            ///<summary>setreg</summary>
            public const string Setreg = "setreg";
            ///<summary>shf</summary>
            public const string Shf = "shf";
            ///<summary>siv</summary>
            public const string Siv = "siv";
            ///<summary>sieve</summary>
            public const string Sieve = "sieve";
            ///<summary>smi</summary>
            public const string Smi = "smi";
            ///<summary>smil</summary>
            public const string Smil = "smil";
            ///<summary>rq</summary>
            public const string Rq = "rq";
            ///<summary>srx</summary>
            public const string Srx = "srx";
            ///<summary>gram</summary>
            public const string Gram = "gram";
            ///<summary>grxml</summary>
            public const string Grxml = "grxml";
            ///<summary>sru</summary>
            public const string Sru = "sru";
            ///<summary>ssdl</summary>
            public const string Ssdl = "ssdl";
            ///<summary>ssml</summary>
            public const string Ssml = "ssml";
            ///<summary>swidtag</summary>
            public const string Swidtag = "swidtag";
            ///<summary>tei</summary>
            public const string Tei = "tei";
            ///<summary>teicorpus</summary>
            public const string Teicorpus = "teicorpus";
            ///<summary>tfi</summary>
            public const string Tfi = "tfi";
            ///<summary>tsd</summary>
            public const string Tsd = "tsd";
            ///<summary>toml</summary>
            public const string Toml = "toml";
            ///<summary>trig</summary>
            public const string Trig = "trig";
            ///<summary>ttml</summary>
            public const string Ttml = "ttml";
            ///<summary>ubj</summary>
            public const string Ubj = "ubj";
            ///<summary>rsheet</summary>
            public const string Rsheet = "rsheet";
            ///<summary>td</summary>
            public const string Td = "td";
            ///<summary>1km</summary>
            public const string _1km = "1km";
            ///<summary>plb</summary>
            public const string Plb = "plb";
            ///<summary>psb</summary>
            public const string Psb = "psb";
            ///<summary>pvb</summary>
            public const string Pvb = "pvb";
            ///<summary>tcap</summary>
            public const string Tcap = "tcap";
            ///<summary>pwn</summary>
            public const string Pwn = "pwn";
            ///<summary>aso</summary>
            public const string Aso = "aso";
            ///<summary>imp</summary>
            public const string Imp = "imp";
            ///<summary>acu</summary>
            public const string Acu = "acu";
            ///<summary>atc</summary>
            public const string Atc = "atc";
            ///<summary>acutc</summary>
            public const string Acutc = "acutc";
            ///<summary>air</summary>
            public const string Air = "air";
            ///<summary>fcdt</summary>
            public const string Fcdt = "fcdt";
            ///<summary>fxp</summary>
            public const string Fxp = "fxp";
            ///<summary>fxpl</summary>
            public const string Fxpl = "fxpl";
            ///<summary>xdp</summary>
            public const string Xdp = "xdp";
            ///<summary>xfdf</summary>
            public const string Xfdf = "xfdf";
            ///<summary>age</summary>
            public const string Age = "age";
            ///<summary>ahead</summary>
            public const string Ahead = "ahead";
            ///<summary>azf</summary>
            public const string Azf = "azf";
            ///<summary>azs</summary>
            public const string Azs = "azs";
            ///<summary>azw</summary>
            public const string Azw = "azw";
            ///<summary>acc</summary>
            public const string Acc = "acc";
            ///<summary>ami</summary>
            public const string Ami = "ami";
            ///<summary>apk</summary>
            public const string Apk = "apk";
            ///<summary>cii</summary>
            public const string Cii = "cii";
            ///<summary>fti</summary>
            public const string Fti = "fti";
            ///<summary>atx</summary>
            public const string Atx = "atx";
            ///<summary>mpkg</summary>
            public const string Mpkg = "mpkg";
            ///<summary>key</summary>
            public const string Key = "key";
            ///<summary>m3u8</summary>
            public const string M3u8 = "m3u8";
            ///<summary>numbers</summary>
            public const string Numbers = "numbers";
            ///<summary>pages</summary>
            public const string Pages = "pages";
            ///<summary>pkpass</summary>
            public const string Pkpass = "pkpass";
            ///<summary>swi</summary>
            public const string Swi = "swi";
            ///<summary>iota</summary>
            public const string Iota = "iota";
            ///<summary>aep</summary>
            public const string Aep = "aep";
            ///<summary>bmml</summary>
            public const string Bmml = "bmml";
            ///<summary>mpm</summary>
            public const string Mpm = "mpm";
            ///<summary>bmi</summary>
            public const string Bmi = "bmi";
            ///<summary>rep</summary>
            public const string Rep = "rep";
            ///<summary>cdxml</summary>
            public const string Cdxml = "cdxml";
            ///<summary>mmd</summary>
            public const string Mmd = "mmd";
            ///<summary>cdy</summary>
            public const string Cdy = "cdy";
            ///<summary>csl</summary>
            public const string Csl = "csl";
            ///<summary>cla</summary>
            public const string Cla = "cla";
            ///<summary>rp9</summary>
            public const string Rp9 = "rp9";
            ///<summary>c4g</summary>
            public const string C4g = "c4g";
            ///<summary>c4d</summary>
            public const string C4d = "c4d";
            ///<summary>c4f</summary>
            public const string C4f = "c4f";
            ///<summary>c4p</summary>
            public const string C4p = "c4p";
            ///<summary>c4u</summary>
            public const string C4u = "c4u";
            ///<summary>c11amc</summary>
            public const string C11amc = "c11amc";
            ///<summary>c11amz</summary>
            public const string C11amz = "c11amz";
            ///<summary>csp</summary>
            public const string Csp = "csp";
            ///<summary>cdbcmsg</summary>
            public const string Cdbcmsg = "cdbcmsg";
            ///<summary>cmc</summary>
            public const string Cmc = "cmc";
            ///<summary>clkx</summary>
            public const string Clkx = "clkx";
            ///<summary>clkk</summary>
            public const string Clkk = "clkk";
            ///<summary>clkp</summary>
            public const string Clkp = "clkp";
            ///<summary>clkt</summary>
            public const string Clkt = "clkt";
            ///<summary>clkw</summary>
            public const string Clkw = "clkw";
            ///<summary>wbs</summary>
            public const string Wbs = "wbs";
            ///<summary>pml</summary>
            public const string Pml = "pml";
            ///<summary>ppd</summary>
            public const string Ppd = "ppd";
            ///<summary>car</summary>
            public const string Car = "car";
            ///<summary>pcurl</summary>
            public const string Pcurl = "pcurl";
            ///<summary>dart</summary>
            public const string Dart = "dart";
            ///<summary>rdz</summary>
            public const string Rdz = "rdz";
            ///<summary>dbf</summary>
            public const string Dbf = "dbf";
            ///<summary>uvf</summary>
            public const string Uvf = "uvf";
            ///<summary>uvvf</summary>
            public const string Uvvf = "uvvf";
            ///<summary>uvd</summary>
            public const string Uvd = "uvd";
            ///<summary>uvvd</summary>
            public const string Uvvd = "uvvd";
            ///<summary>uvt</summary>
            public const string Uvt = "uvt";
            ///<summary>uvvt</summary>
            public const string Uvvt = "uvvt";
            ///<summary>uvx</summary>
            public const string Uvx = "uvx";
            ///<summary>uvvx</summary>
            public const string Uvvx = "uvvx";
            ///<summary>uvz</summary>
            public const string Uvz = "uvz";
            ///<summary>uvvz</summary>
            public const string Uvvz = "uvvz";
            ///<summary>fe_launch</summary>
            public const string Fe_launch = "fe_launch";
            ///<summary>dna</summary>
            public const string Dna = "dna";
            ///<summary>mlp</summary>
            public const string Mlp = "mlp";
            ///<summary>dpg</summary>
            public const string Dpg = "dpg";
            ///<summary>dfac</summary>
            public const string Dfac = "dfac";
            ///<summary>kpxx</summary>
            public const string Kpxx = "kpxx";
            ///<summary>ait</summary>
            public const string Ait = "ait";
            ///<summary>svc</summary>
            public const string Svc = "svc";
            ///<summary>geo</summary>
            public const string Geo = "geo";
            ///<summary>mag</summary>
            public const string Mag = "mag";
            ///<summary>nml</summary>
            public const string Nml = "nml";
            ///<summary>esf</summary>
            public const string Esf = "esf";
            ///<summary>msf</summary>
            public const string Msf = "msf";
            ///<summary>qam</summary>
            public const string Qam = "qam";
            ///<summary>slt</summary>
            public const string Slt = "slt";
            ///<summary>ssf</summary>
            public const string Ssf = "ssf";
            ///<summary>es3</summary>
            public const string Es3 = "es3";
            ///<summary>et3</summary>
            public const string Et3 = "et3";
            ///<summary>ez2</summary>
            public const string Ez2 = "ez2";
            ///<summary>ez3</summary>
            public const string Ez3 = "ez3";
            ///<summary>fdf</summary>
            public const string Fdf = "fdf";
            ///<summary>mseed</summary>
            public const string Mseed = "mseed";
            ///<summary>seed</summary>
            public const string Seed = "seed";
            ///<summary>dataless</summary>
            public const string Dataless = "dataless";
            ///<summary>gph</summary>
            public const string Gph = "gph";
            ///<summary>ftc</summary>
            public const string Ftc = "ftc";
            ///<summary>fm</summary>
            public const string Fm = "fm";
            ///<summary>frame</summary>
            public const string Frame = "frame";
            ///<summary>maker</summary>
            public const string Maker = "maker";
            ///<summary>book</summary>
            public const string Book = "book";
            ///<summary>fnc</summary>
            public const string Fnc = "fnc";
            ///<summary>ltf</summary>
            public const string Ltf = "ltf";
            ///<summary>fsc</summary>
            public const string Fsc = "fsc";
            ///<summary>oas</summary>
            public const string Oas = "oas";
            ///<summary>oa2</summary>
            public const string Oa2 = "oa2";
            ///<summary>oa3</summary>
            public const string Oa3 = "oa3";
            ///<summary>fg5</summary>
            public const string Fg5 = "fg5";
            ///<summary>bh2</summary>
            public const string Bh2 = "bh2";
            ///<summary>ddd</summary>
            public const string Ddd = "ddd";
            ///<summary>xdw</summary>
            public const string Xdw = "xdw";
            ///<summary>xbd</summary>
            public const string Xbd = "xbd";
            ///<summary>fzs</summary>
            public const string Fzs = "fzs";
            ///<summary>txd</summary>
            public const string Txd = "txd";
            ///<summary>ggb</summary>
            public const string Ggb = "ggb";
            ///<summary>ggt</summary>
            public const string Ggt = "ggt";
            ///<summary>gex</summary>
            public const string Gex = "gex";
            ///<summary>gre</summary>
            public const string Gre = "gre";
            ///<summary>gxt</summary>
            public const string Gxt = "gxt";
            ///<summary>g2w</summary>
            public const string G2w = "g2w";
            ///<summary>g3w</summary>
            public const string G3w = "g3w";
            ///<summary>gmx</summary>
            public const string Gmx = "gmx";
            ///<summary>gdoc</summary>
            public const string Gdoc = "gdoc";
            ///<summary>gslides</summary>
            public const string Gslides = "gslides";
            ///<summary>gsheet</summary>
            public const string Gsheet = "gsheet";
            ///<summary>kml</summary>
            public const string Kml = "kml";
            ///<summary>kmz</summary>
            public const string Kmz = "kmz";
            ///<summary>gqf</summary>
            public const string Gqf = "gqf";
            ///<summary>gqs</summary>
            public const string Gqs = "gqs";
            ///<summary>gac</summary>
            public const string Gac = "gac";
            ///<summary>ghf</summary>
            public const string Ghf = "ghf";
            ///<summary>gim</summary>
            public const string Gim = "gim";
            ///<summary>grv</summary>
            public const string Grv = "grv";
            ///<summary>gtm</summary>
            public const string Gtm = "gtm";
            ///<summary>tpl</summary>
            public const string Tpl = "tpl";
            ///<summary>vcg</summary>
            public const string Vcg = "vcg";
            ///<summary>hal</summary>
            public const string Hal = "hal";
            ///<summary>zmm</summary>
            public const string Zmm = "zmm";
            ///<summary>hbci</summary>
            public const string Hbci = "hbci";
            ///<summary>les</summary>
            public const string Les = "les";
            ///<summary>hpgl</summary>
            public const string Hpgl = "hpgl";
            ///<summary>hpid</summary>
            public const string Hpid = "hpid";
            ///<summary>hps</summary>
            public const string Hps = "hps";
            ///<summary>jlt</summary>
            public const string Jlt = "jlt";
            ///<summary>pcl</summary>
            public const string Pcl = "pcl";
            ///<summary>pclxl</summary>
            public const string Pclxl = "pclxl";
            ///<summary>sfd-hdstx</summary>
            public const string Sfd_hdstx = "sfd-hdstx";
            ///<summary>mpy</summary>
            public const string Mpy = "mpy";
            ///<summary>afp</summary>
            public const string Afp = "afp";
            ///<summary>listafp</summary>
            public const string Listafp = "listafp";
            ///<summary>list3820</summary>
            public const string List3820 = "list3820";
            ///<summary>irm</summary>
            public const string Irm = "irm";
            ///<summary>sc</summary>
            public const string Sc = "sc";
            ///<summary>icc</summary>
            public const string Icc = "icc";
            ///<summary>icm</summary>
            public const string Icm = "icm";
            ///<summary>igl</summary>
            public const string Igl = "igl";
            ///<summary>ivp</summary>
            public const string Ivp = "ivp";
            ///<summary>ivu</summary>
            public const string Ivu = "ivu";
            ///<summary>igm</summary>
            public const string Igm = "igm";
            ///<summary>xpw</summary>
            public const string Xpw = "xpw";
            ///<summary>xpx</summary>
            public const string Xpx = "xpx";
            ///<summary>i2g</summary>
            public const string I2g = "i2g";
            ///<summary>qbo</summary>
            public const string Qbo = "qbo";
            ///<summary>qfx</summary>
            public const string Qfx = "qfx";
            ///<summary>rcprofile</summary>
            public const string Rcprofile = "rcprofile";
            ///<summary>irp</summary>
            public const string Irp = "irp";
            ///<summary>xpr</summary>
            public const string Xpr = "xpr";
            ///<summary>fcs</summary>
            public const string Fcs = "fcs";
            ///<summary>jam</summary>
            public const string Jam = "jam";
            ///<summary>rms</summary>
            public const string Rms = "rms";
            ///<summary>jisp</summary>
            public const string Jisp = "jisp";
            ///<summary>joda</summary>
            public const string Joda = "joda";
            ///<summary>ktz</summary>
            public const string Ktz = "ktz";
            ///<summary>ktr</summary>
            public const string Ktr = "ktr";
            ///<summary>karbon</summary>
            public const string Karbon = "karbon";
            ///<summary>chrt</summary>
            public const string Chrt = "chrt";
            ///<summary>kfo</summary>
            public const string Kfo = "kfo";
            ///<summary>flw</summary>
            public const string Flw = "flw";
            ///<summary>kon</summary>
            public const string Kon = "kon";
            ///<summary>kpr</summary>
            public const string Kpr = "kpr";
            ///<summary>kpt</summary>
            public const string Kpt = "kpt";
            ///<summary>ksp</summary>
            public const string Ksp = "ksp";
            ///<summary>kwd</summary>
            public const string Kwd = "kwd";
            ///<summary>kwt</summary>
            public const string Kwt = "kwt";
            ///<summary>htke</summary>
            public const string Htke = "htke";
            ///<summary>kia</summary>
            public const string Kia = "kia";
            ///<summary>kne</summary>
            public const string Kne = "kne";
            ///<summary>knp</summary>
            public const string Knp = "knp";
            ///<summary>skp</summary>
            public const string Skp = "skp";
            ///<summary>skd</summary>
            public const string Skd = "skd";
            ///<summary>skt</summary>
            public const string Skt = "skt";
            ///<summary>skm</summary>
            public const string Skm = "skm";
            ///<summary>sse</summary>
            public const string Sse = "sse";
            ///<summary>lasxml</summary>
            public const string Lasxml = "lasxml";
            ///<summary>lbd</summary>
            public const string Lbd = "lbd";
            ///<summary>lbe</summary>
            public const string Lbe = "lbe";
            ///<summary>123</summary>
            public const string _123 = "123";
            ///<summary>apr</summary>
            public const string Apr = "apr";
            ///<summary>pre</summary>
            public const string Pre = "pre";
            ///<summary>nsf</summary>
            public const string Nsf = "nsf";
            ///<summary>org</summary>
            public const string Org = "org";
            ///<summary>scm</summary>
            public const string Scm = "scm";
            ///<summary>lwp</summary>
            public const string Lwp = "lwp";
            ///<summary>portpkg</summary>
            public const string Portpkg = "portpkg";
            ///<summary>mvt</summary>
            public const string Mvt = "mvt";
            ///<summary>mcd</summary>
            public const string Mcd = "mcd";
            ///<summary>mc1</summary>
            public const string Mc1 = "mc1";
            ///<summary>cdkey</summary>
            public const string Cdkey = "cdkey";
            ///<summary>mwf</summary>
            public const string Mwf = "mwf";
            ///<summary>mfm</summary>
            public const string Mfm = "mfm";
            ///<summary>flo</summary>
            public const string Flo = "flo";
            ///<summary>igx</summary>
            public const string Igx = "igx";
            ///<summary>mif</summary>
            public const string Mif = "mif";
            ///<summary>daf</summary>
            public const string Daf = "daf";
            ///<summary>dis</summary>
            public const string Dis = "dis";
            ///<summary>mbk</summary>
            public const string Mbk = "mbk";
            ///<summary>mqy</summary>
            public const string Mqy = "mqy";
            ///<summary>msl</summary>
            public const string Msl = "msl";
            ///<summary>plc</summary>
            public const string Plc = "plc";
            ///<summary>txf</summary>
            public const string Txf = "txf";
            ///<summary>mpn</summary>
            public const string Mpn = "mpn";
            ///<summary>mpc</summary>
            public const string Mpc = "mpc";
            ///<summary>xul</summary>
            public const string Xul = "xul";
            ///<summary>cil</summary>
            public const string Cil = "cil";
            ///<summary>cab</summary>
            public const string Cab = "cab";
            ///<summary>xls</summary>
            public const string Xls = "xls";
            ///<summary>xlm</summary>
            public const string Xlm = "xlm";
            ///<summary>xla</summary>
            public const string Xla = "xla";
            ///<summary>xlc</summary>
            public const string Xlc = "xlc";
            ///<summary>xlt</summary>
            public const string Xlt = "xlt";
            ///<summary>xlw</summary>
            public const string Xlw = "xlw";
            ///<summary>xlam</summary>
            public const string Xlam = "xlam";
            ///<summary>xlsb</summary>
            public const string Xlsb = "xlsb";
            ///<summary>xlsm</summary>
            public const string Xlsm = "xlsm";
            ///<summary>xltm</summary>
            public const string Xltm = "xltm";
            ///<summary>eot</summary>
            public const string Eot = "eot";
            ///<summary>chm</summary>
            public const string Chm = "chm";
            ///<summary>ims</summary>
            public const string Ims = "ims";
            ///<summary>lrm</summary>
            public const string Lrm = "lrm";
            ///<summary>thmx</summary>
            public const string Thmx = "thmx";
            ///<summary>msg</summary>
            public const string Msg = "msg";
            ///<summary>cat</summary>
            public const string Cat = "cat";
            ///<summary>stl</summary>
            public const string Stl = "stl";
            ///<summary>ppt</summary>
            public const string Ppt = "ppt";
            ///<summary>pps</summary>
            public const string Pps = "pps";
            ///<summary>pot</summary>
            public const string Pot = "pot";
            ///<summary>ppam</summary>
            public const string Ppam = "ppam";
            ///<summary>pptm</summary>
            public const string Pptm = "pptm";
            ///<summary>sldm</summary>
            public const string Sldm = "sldm";
            ///<summary>ppsm</summary>
            public const string Ppsm = "ppsm";
            ///<summary>potm</summary>
            public const string Potm = "potm";
            ///<summary>mpt</summary>
            public const string Mpt = "mpt";
            ///<summary>docm</summary>
            public const string Docm = "docm";
            ///<summary>dotm</summary>
            public const string Dotm = "dotm";
            ///<summary>wps</summary>
            public const string Wps = "wps";
            ///<summary>wks</summary>
            public const string Wks = "wks";
            ///<summary>wcm</summary>
            public const string Wcm = "wcm";
            ///<summary>wdb</summary>
            public const string Wdb = "wdb";
            ///<summary>wpl</summary>
            public const string Wpl = "wpl";
            ///<summary>xps</summary>
            public const string Xps = "xps";
            ///<summary>mseq</summary>
            public const string Mseq = "mseq";
            ///<summary>mus</summary>
            public const string Mus = "mus";
            ///<summary>msty</summary>
            public const string Msty = "msty";
            ///<summary>taglet</summary>
            public const string Taglet = "taglet";
            ///<summary>nlu</summary>
            public const string Nlu = "nlu";
            ///<summary>ntf</summary>
            public const string Ntf = "ntf";
            ///<summary>nitf</summary>
            public const string Nitf = "nitf";
            ///<summary>nnd</summary>
            public const string Nnd = "nnd";
            ///<summary>nns</summary>
            public const string Nns = "nns";
            ///<summary>nnw</summary>
            public const string Nnw = "nnw";
            ///<summary>ngdat</summary>
            public const string Ngdat = "ngdat";
            ///<summary>n-gage</summary>
            public const string N_gage = "n-gage";
            ///<summary>rpst</summary>
            public const string Rpst = "rpst";
            ///<summary>rpss</summary>
            public const string Rpss = "rpss";
            ///<summary>edm</summary>
            public const string Edm = "edm";
            ///<summary>edx</summary>
            public const string Edx = "edx";
            ///<summary>ext</summary>
            public const string Ext = "ext";
            ///<summary>odc</summary>
            public const string Odc = "odc";
            ///<summary>otc</summary>
            public const string Otc = "otc";
            ///<summary>odb</summary>
            public const string Odb = "odb";
            ///<summary>odf</summary>
            public const string Odf = "odf";
            ///<summary>odft</summary>
            public const string Odft = "odft";
            ///<summary>odg</summary>
            public const string Odg = "odg";
            ///<summary>otg</summary>
            public const string Otg = "otg";
            ///<summary>odi</summary>
            public const string Odi = "odi";
            ///<summary>oti</summary>
            public const string Oti = "oti";
            ///<summary>odp</summary>
            public const string Odp = "odp";
            ///<summary>otp</summary>
            public const string Otp = "otp";
            ///<summary>ods</summary>
            public const string Ods = "ods";
            ///<summary>ots</summary>
            public const string Ots = "ots";
            ///<summary>odt</summary>
            public const string Odt = "odt";
            ///<summary>odm</summary>
            public const string Odm = "odm";
            ///<summary>ott</summary>
            public const string Ott = "ott";
            ///<summary>oth</summary>
            public const string Oth = "oth";
            ///<summary>xo</summary>
            public const string Xo = "xo";
            ///<summary>dd2</summary>
            public const string Dd2 = "dd2";
            ///<summary>obgx</summary>
            public const string Obgx = "obgx";
            ///<summary>oxt</summary>
            public const string Oxt = "oxt";
            ///<summary>osm</summary>
            public const string Osm = "osm";
            ///<summary>pptx</summary>
            public const string Pptx = "pptx";
            ///<summary>sldx</summary>
            public const string Sldx = "sldx";
            ///<summary>ppsx</summary>
            public const string Ppsx = "ppsx";
            ///<summary>potx</summary>
            public const string Potx = "potx";
            ///<summary>xlsx</summary>
            public const string Xlsx = "xlsx";
            ///<summary>xltx</summary>
            public const string Xltx = "xltx";
            ///<summary>docx</summary>
            public const string Docx = "docx";
            ///<summary>dotx</summary>
            public const string Dotx = "dotx";
            ///<summary>mgp</summary>
            public const string Mgp = "mgp";
            ///<summary>dp</summary>
            public const string Dp = "dp";
            ///<summary>esa</summary>
            public const string Esa = "esa";
            ///<summary>pdb</summary>
            public const string Pdb = "pdb";
            ///<summary>pqa</summary>
            public const string Pqa = "pqa";
            ///<summary>oprc</summary>
            public const string Oprc = "oprc";
            ///<summary>paw</summary>
            public const string Paw = "paw";
            ///<summary>str</summary>
            public const string Str = "str";
            ///<summary>ei6</summary>
            public const string Ei6 = "ei6";
            ///<summary>efif</summary>
            public const string Efif = "efif";
            ///<summary>wg</summary>
            public const string Wg = "wg";
            ///<summary>plf</summary>
            public const string Plf = "plf";
            ///<summary>pbd</summary>
            public const string Pbd = "pbd";
            ///<summary>box</summary>
            public const string Box = "box";
            ///<summary>mgz</summary>
            public const string Mgz = "mgz";
            ///<summary>qps</summary>
            public const string Qps = "qps";
            ///<summary>ptid</summary>
            public const string Ptid = "ptid";
            ///<summary>qxd</summary>
            public const string Qxd = "qxd";
            ///<summary>qxt</summary>
            public const string Qxt = "qxt";
            ///<summary>qwd</summary>
            public const string Qwd = "qwd";
            ///<summary>qwt</summary>
            public const string Qwt = "qwt";
            ///<summary>qxl</summary>
            public const string Qxl = "qxl";
            ///<summary>qxb</summary>
            public const string Qxb = "qxb";
            ///<summary>rar</summary>
            public const string Rar = "rar";
            ///<summary>bed</summary>
            public const string Bed = "bed";
            ///<summary>mxl</summary>
            public const string Mxl = "mxl";
            ///<summary>musicxml</summary>
            public const string Musicxml = "musicxml";
            ///<summary>cryptonote</summary>
            public const string Cryptonote = "cryptonote";
            ///<summary>cod</summary>
            public const string Cod = "cod";
            ///<summary>rm</summary>
            public const string Rm = "rm";
            ///<summary>rmvb</summary>
            public const string Rmvb = "rmvb";
            ///<summary>link66</summary>
            public const string Link66 = "link66";
            ///<summary>st</summary>
            public const string St = "st";
            ///<summary>see</summary>
            public const string See = "see";
            ///<summary>sema</summary>
            public const string Sema = "sema";
            ///<summary>semd</summary>
            public const string Semd = "semd";
            ///<summary>semf</summary>
            public const string Semf = "semf";
            ///<summary>ifm</summary>
            public const string Ifm = "ifm";
            ///<summary>itp</summary>
            public const string Itp = "itp";
            ///<summary>iif</summary>
            public const string Iif = "iif";
            ///<summary>ipk</summary>
            public const string Ipk = "ipk";
            ///<summary>twd</summary>
            public const string Twd = "twd";
            ///<summary>twds</summary>
            public const string Twds = "twds";
            ///<summary>mmf</summary>
            public const string Mmf = "mmf";
            ///<summary>teacher</summary>
            public const string Teacher = "teacher";
            ///<summary>fo</summary>
            public const string Fo = "fo";
            ///<summary>sdkm</summary>
            public const string Sdkm = "sdkm";
            ///<summary>sdkd</summary>
            public const string Sdkd = "sdkd";
            ///<summary>dxp</summary>
            public const string Dxp = "dxp";
            ///<summary>sfs</summary>
            public const string Sfs = "sfs";
            ///<summary>sdc</summary>
            public const string Sdc = "sdc";
            ///<summary>sda</summary>
            public const string Sda = "sda";
            ///<summary>sdd</summary>
            public const string Sdd = "sdd";
            ///<summary>smf</summary>
            public const string Smf = "smf";
            ///<summary>sdw</summary>
            public const string Sdw = "sdw";
            ///<summary>vor</summary>
            public const string Vor = "vor";
            ///<summary>sgl</summary>
            public const string Sgl = "sgl";
            ///<summary>smzip</summary>
            public const string Smzip = "smzip";
            ///<summary>sm</summary>
            public const string Sm = "sm";
            ///<summary>wadl</summary>
            public const string Wadl = "wadl";
            ///<summary>sxc</summary>
            public const string Sxc = "sxc";
            ///<summary>stc</summary>
            public const string Stc = "stc";
            ///<summary>sxd</summary>
            public const string Sxd = "sxd";
            ///<summary>std</summary>
            public const string Std = "std";
            ///<summary>sxi</summary>
            public const string Sxi = "sxi";
            ///<summary>sti</summary>
            public const string Sti = "sti";
            ///<summary>sxm</summary>
            public const string Sxm = "sxm";
            ///<summary>sxw</summary>
            public const string Sxw = "sxw";
            ///<summary>sxg</summary>
            public const string Sxg = "sxg";
            ///<summary>stw</summary>
            public const string Stw = "stw";
            ///<summary>sus</summary>
            public const string Sus = "sus";
            ///<summary>susp</summary>
            public const string Susp = "susp";
            ///<summary>svd</summary>
            public const string Svd = "svd";
            ///<summary>sis</summary>
            public const string Sis = "sis";
            ///<summary>sisx</summary>
            public const string Sisx = "sisx";
            ///<summary>xsm</summary>
            public const string Xsm = "xsm";
            ///<summary>bdm</summary>
            public const string Bdm = "bdm";
            ///<summary>xdm</summary>
            public const string Xdm = "xdm";
            ///<summary>ddf</summary>
            public const string Ddf = "ddf";
            ///<summary>tao</summary>
            public const string Tao = "tao";
            ///<summary>pcap</summary>
            public const string Pcap = "pcap";
            ///<summary>cap</summary>
            public const string Cap = "cap";
            ///<summary>dmp</summary>
            public const string Dmp = "dmp";
            ///<summary>tmo</summary>
            public const string Tmo = "tmo";
            ///<summary>tpt</summary>
            public const string Tpt = "tpt";
            ///<summary>mxs</summary>
            public const string Mxs = "mxs";
            ///<summary>tra</summary>
            public const string Tra = "tra";
            ///<summary>ufd</summary>
            public const string Ufd = "ufd";
            ///<summary>ufdl</summary>
            public const string Ufdl = "ufdl";
            ///<summary>utz</summary>
            public const string Utz = "utz";
            ///<summary>umj</summary>
            public const string Umj = "umj";
            ///<summary>unityweb</summary>
            public const string Unityweb = "unityweb";
            ///<summary>uoml</summary>
            public const string Uoml = "uoml";
            ///<summary>vcx</summary>
            public const string Vcx = "vcx";
            ///<summary>vsd</summary>
            public const string Vsd = "vsd";
            ///<summary>vst</summary>
            public const string Vst = "vst";
            ///<summary>vss</summary>
            public const string Vss = "vss";
            ///<summary>vsw</summary>
            public const string Vsw = "vsw";
            ///<summary>vis</summary>
            public const string Vis = "vis";
            ///<summary>vsf</summary>
            public const string Vsf = "vsf";
            ///<summary>wbxml</summary>
            public const string Wbxml = "wbxml";
            ///<summary>wmlc</summary>
            public const string Wmlc = "wmlc";
            ///<summary>wmlsc</summary>
            public const string Wmlsc = "wmlsc";
            ///<summary>wtb</summary>
            public const string Wtb = "wtb";
            ///<summary>nbp</summary>
            public const string Nbp = "nbp";
            ///<summary>wpd</summary>
            public const string Wpd = "wpd";
            ///<summary>wqd</summary>
            public const string Wqd = "wqd";
            ///<summary>stf</summary>
            public const string Stf = "stf";
            ///<summary>xar</summary>
            public const string Xar = "xar";
            ///<summary>xfdl</summary>
            public const string Xfdl = "xfdl";
            ///<summary>hvd</summary>
            public const string Hvd = "hvd";
            ///<summary>hvs</summary>
            public const string Hvs = "hvs";
            ///<summary>hvp</summary>
            public const string Hvp = "hvp";
            ///<summary>osf</summary>
            public const string Osf = "osf";
            ///<summary>osfpvg</summary>
            public const string Osfpvg = "osfpvg";
            ///<summary>saf</summary>
            public const string Saf = "saf";
            ///<summary>spf</summary>
            public const string Spf = "spf";
            ///<summary>cmp</summary>
            public const string Cmp = "cmp";
            ///<summary>zir</summary>
            public const string Zir = "zir";
            ///<summary>zirz</summary>
            public const string Zirz = "zirz";
            ///<summary>zaz</summary>
            public const string Zaz = "zaz";
            ///<summary>vxml</summary>
            public const string Vxml = "vxml";
            ///<summary>wasm</summary>
            public const string Wasm = "wasm";
            ///<summary>wif</summary>
            public const string Wif = "wif";
            ///<summary>wgt</summary>
            public const string Wgt = "wgt";
            ///<summary>hlp</summary>
            public const string Hlp = "hlp";
            ///<summary>wsdl</summary>
            public const string Wsdl = "wsdl";
            ///<summary>wspolicy</summary>
            public const string Wspolicy = "wspolicy";
            ///<summary>7z</summary>
            public const string _7z = "7z";
            ///<summary>abw</summary>
            public const string Abw = "abw";
            ///<summary>ace</summary>
            public const string Ace = "ace";
            ///<summary>arj</summary>
            public const string Arj = "arj";
            ///<summary>aab</summary>
            public const string Aab = "aab";
            ///<summary>x32</summary>
            public const string X32 = "x32";
            ///<summary>u32</summary>
            public const string U32 = "u32";
            ///<summary>vox</summary>
            public const string Vox = "vox";
            ///<summary>aam</summary>
            public const string Aam = "aam";
            ///<summary>aas</summary>
            public const string Aas = "aas";
            ///<summary>bcpio</summary>
            public const string Bcpio = "bcpio";
            ///<summary>torrent</summary>
            public const string Torrent = "torrent";
            ///<summary>blb</summary>
            public const string Blb = "blb";
            ///<summary>blorb</summary>
            public const string Blorb = "blorb";
            ///<summary>bz</summary>
            public const string Bz = "bz";
            ///<summary>bz2</summary>
            public const string Bz2 = "bz2";
            ///<summary>boz</summary>
            public const string Boz = "boz";
            ///<summary>cbr</summary>
            public const string Cbr = "cbr";
            ///<summary>cba</summary>
            public const string Cba = "cba";
            ///<summary>cbt</summary>
            public const string Cbt = "cbt";
            ///<summary>cbz</summary>
            public const string Cbz = "cbz";
            ///<summary>cb7</summary>
            public const string Cb7 = "cb7";
            ///<summary>vcd</summary>
            public const string Vcd = "vcd";
            ///<summary>cfs</summary>
            public const string Cfs = "cfs";
            ///<summary>chat</summary>
            public const string Chat = "chat";
            ///<summary>pgn</summary>
            public const string Pgn = "pgn";
            ///<summary>crx</summary>
            public const string Crx = "crx";
            ///<summary>cco</summary>
            public const string Cco = "cco";
            ///<summary>nsc</summary>
            public const string Nsc = "nsc";
            ///<summary>cpio</summary>
            public const string Cpio = "cpio";
            ///<summary>csh</summary>
            public const string Csh = "csh";
            ///<summary>udeb</summary>
            public const string Udeb = "udeb";
            ///<summary>dgc</summary>
            public const string Dgc = "dgc";
            ///<summary>dir</summary>
            public const string Dir = "dir";
            ///<summary>dcr</summary>
            public const string Dcr = "dcr";
            ///<summary>dxr</summary>
            public const string Dxr = "dxr";
            ///<summary>cst</summary>
            public const string Cst = "cst";
            ///<summary>cct</summary>
            public const string Cct = "cct";
            ///<summary>cxt</summary>
            public const string Cxt = "cxt";
            ///<summary>w3d</summary>
            public const string W3d = "w3d";
            ///<summary>fgd</summary>
            public const string Fgd = "fgd";
            ///<summary>swa</summary>
            public const string Swa = "swa";
            ///<summary>wad</summary>
            public const string Wad = "wad";
            ///<summary>ncx</summary>
            public const string Ncx = "ncx";
            ///<summary>dtb</summary>
            public const string Dtb = "dtb";
            ///<summary>res</summary>
            public const string Res = "res";
            ///<summary>dvi</summary>
            public const string Dvi = "dvi";
            ///<summary>evy</summary>
            public const string Evy = "evy";
            ///<summary>eva</summary>
            public const string Eva = "eva";
            ///<summary>bdf</summary>
            public const string Bdf = "bdf";
            ///<summary>gsf</summary>
            public const string Gsf = "gsf";
            ///<summary>psf</summary>
            public const string Psf = "psf";
            ///<summary>pcf</summary>
            public const string Pcf = "pcf";
            ///<summary>snf</summary>
            public const string Snf = "snf";
            ///<summary>pfa</summary>
            public const string Pfa = "pfa";
            ///<summary>pfb</summary>
            public const string Pfb = "pfb";
            ///<summary>pfm</summary>
            public const string Pfm = "pfm";
            ///<summary>afm</summary>
            public const string Afm = "afm";
            ///<summary>arc</summary>
            public const string Arc = "arc";
            ///<summary>spl</summary>
            public const string Spl = "spl";
            ///<summary>gca</summary>
            public const string Gca = "gca";
            ///<summary>ulx</summary>
            public const string Ulx = "ulx";
            ///<summary>gnumeric</summary>
            public const string Gnumeric = "gnumeric";
            ///<summary>gramps</summary>
            public const string Gramps = "gramps";
            ///<summary>gtar</summary>
            public const string Gtar = "gtar";
            ///<summary>hdf</summary>
            public const string Hdf = "hdf";
            ///<summary>php</summary>
            public const string Php = "php";
            ///<summary>install</summary>
            public const string Install = "install";
            ///<summary>jardiff</summary>
            public const string Jardiff = "jardiff";
            ///<summary>jnlp</summary>
            public const string Jnlp = "jnlp";
            ///<summary>kdbx</summary>
            public const string Kdbx = "kdbx";
            ///<summary>latex</summary>
            public const string Latex = "latex";
            ///<summary>luac</summary>
            public const string Luac = "luac";
            ///<summary>lzh</summary>
            public const string Lzh = "lzh";
            ///<summary>lha</summary>
            public const string Lha = "lha";
            ///<summary>run</summary>
            public const string Run = "run";
            ///<summary>mie</summary>
            public const string Mie = "mie";
            ///<summary>prc</summary>
            public const string Prc = "prc";
            ///<summary>mobi</summary>
            public const string Mobi = "mobi";
            ///<summary>application</summary>
            public const string Application = "application";
            ///<summary>lnk</summary>
            public const string Lnk = "lnk";
            ///<summary>wmd</summary>
            public const string Wmd = "wmd";
            ///<summary>wmz</summary>
            public const string Wmz = "wmz";
            ///<summary>xbap</summary>
            public const string Xbap = "xbap";
            ///<summary>mdb</summary>
            public const string Mdb = "mdb";
            ///<summary>obd</summary>
            public const string Obd = "obd";
            ///<summary>crd</summary>
            public const string Crd = "crd";
            ///<summary>clp</summary>
            public const string Clp = "clp";
            ///<summary>com</summary>
            public const string Com = "com";
            ///<summary>bat</summary>
            public const string Bat = "bat";
            ///<summary>mvb</summary>
            public const string Mvb = "mvb";
            ///<summary>m13</summary>
            public const string M13 = "m13";
            ///<summary>m14</summary>
            public const string M14 = "m14";
            ///<summary>wmf</summary>
            public const string Wmf = "wmf";
            ///<summary>emf</summary>
            public const string Emf = "emf";
            ///<summary>emz</summary>
            public const string Emz = "emz";
            ///<summary>mny</summary>
            public const string Mny = "mny";
            ///<summary>pub</summary>
            public const string Pub = "pub";
            ///<summary>scd</summary>
            public const string Scd = "scd";
            ///<summary>trm</summary>
            public const string Trm = "trm";
            ///<summary>wri</summary>
            public const string Wri = "wri";
            ///<summary>nc</summary>
            public const string Nc = "nc";
            ///<summary>cdf</summary>
            public const string Cdf = "cdf";
            ///<summary>pac</summary>
            public const string Pac = "pac";
            ///<summary>nzb</summary>
            public const string Nzb = "nzb";
            ///<summary>pl</summary>
            public const string Pl = "pl";
            ///<summary>pm</summary>
            public const string Pm = "pm";
            ///<summary>p12</summary>
            public const string P12 = "p12";
            ///<summary>pfx</summary>
            public const string Pfx = "pfx";
            ///<summary>p7b</summary>
            public const string P7b = "p7b";
            ///<summary>spc</summary>
            public const string Spc = "spc";
            ///<summary>p7r</summary>
            public const string P7r = "p7r";
            ///<summary>rpm</summary>
            public const string Rpm = "rpm";
            ///<summary>ris</summary>
            public const string Ris = "ris";
            ///<summary>sea</summary>
            public const string Sea = "sea";
            ///<summary>sh</summary>
            public const string Sh = "sh";
            ///<summary>shar</summary>
            public const string Shar = "shar";
            ///<summary>swf</summary>
            public const string Swf = "swf";
            ///<summary>xap</summary>
            public const string Xap = "xap";
            ///<summary>sql</summary>
            public const string Sql = "sql";
            ///<summary>sit</summary>
            public const string Sit = "sit";
            ///<summary>sitx</summary>
            public const string Sitx = "sitx";
            ///<summary>srt</summary>
            public const string Srt = "srt";
            ///<summary>sv4cpio</summary>
            public const string Sv4cpio = "sv4cpio";
            ///<summary>sv4crc</summary>
            public const string Sv4crc = "sv4crc";
            ///<summary>t3</summary>
            public const string T3 = "t3";
            ///<summary>gam</summary>
            public const string Gam = "gam";
            ///<summary>tar</summary>
            public const string Tar = "tar";
            ///<summary>tcl</summary>
            public const string Tcl = "tcl";
            ///<summary>tk</summary>
            public const string Tk = "tk";
            ///<summary>tex</summary>
            public const string Tex = "tex";
            ///<summary>tfm</summary>
            public const string Tfm = "tfm";
            ///<summary>texinfo</summary>
            public const string Texinfo = "texinfo";
            ///<summary>texi</summary>
            public const string Texi = "texi";
            ///<summary>obj</summary>
            public const string Obj = "obj";
            ///<summary>ustar</summary>
            public const string Ustar = "ustar";
            ///<summary>hdd</summary>
            public const string Hdd = "hdd";
            ///<summary>ova</summary>
            public const string Ova = "ova";
            ///<summary>ovf</summary>
            public const string Ovf = "ovf";
            ///<summary>vbox</summary>
            public const string Vbox = "vbox";
            ///<summary>vbox-extpack</summary>
            public const string Vbox_extpack = "vbox-extpack";
            ///<summary>vdi</summary>
            public const string Vdi = "vdi";
            ///<summary>vhd</summary>
            public const string Vhd = "vhd";
            ///<summary>vmdk</summary>
            public const string Vmdk = "vmdk";
            ///<summary>src</summary>
            public const string Src = "src";
            ///<summary>webapp</summary>
            public const string Webapp = "webapp";
            ///<summary>der</summary>
            public const string Der = "der";
            ///<summary>crt</summary>
            public const string Crt = "crt";
            ///<summary>pem</summary>
            public const string Pem = "pem";
            ///<summary>fig</summary>
            public const string Fig = "fig";
            ///<summary>xlf</summary>
            public const string Xlf = "xlf";
            ///<summary>xpi</summary>
            public const string Xpi = "xpi";
            ///<summary>xz</summary>
            public const string Xz = "xz";
            ///<summary>z1</summary>
            public const string Z1 = "z1";
            ///<summary>z2</summary>
            public const string Z2 = "z2";
            ///<summary>z3</summary>
            public const string Z3 = "z3";
            ///<summary>z4</summary>
            public const string Z4 = "z4";
            ///<summary>z5</summary>
            public const string Z5 = "z5";
            ///<summary>z6</summary>
            public const string Z6 = "z6";
            ///<summary>z7</summary>
            public const string Z7 = "z7";
            ///<summary>z8</summary>
            public const string Z8 = "z8";
            ///<summary>xaml</summary>
            public const string Xaml = "xaml";
            ///<summary>xav</summary>
            public const string Xav = "xav";
            ///<summary>xca</summary>
            public const string Xca = "xca";
            ///<summary>xdf</summary>
            public const string Xdf = "xdf";
            ///<summary>xel</summary>
            public const string Xel = "xel";
            ///<summary>xns</summary>
            public const string Xns = "xns";
            ///<summary>xenc</summary>
            public const string Xenc = "xenc";
            ///<summary>xhtml</summary>
            public const string Xhtml = "xhtml";
            ///<summary>xht</summary>
            public const string Xht = "xht";
            ///<summary>xml</summary>
            public const string Xml = "xml";
            ///<summary>xsl</summary>
            public const string Xsl = "xsl";
            ///<summary>xsd</summary>
            public const string Xsd = "xsd";
            ///<summary>rng</summary>
            public const string Rng = "rng";
            ///<summary>dtd</summary>
            public const string Dtd = "dtd";
            ///<summary>xop</summary>
            public const string Xop = "xop";
            ///<summary>xpl</summary>
            public const string Xpl = "xpl";
            ///<summary>xslt</summary>
            public const string Xslt = "xslt";
            ///<summary>xspf</summary>
            public const string Xspf = "xspf";
            ///<summary>mxml</summary>
            public const string Mxml = "mxml";
            ///<summary>xhvml</summary>
            public const string Xhvml = "xhvml";
            ///<summary>xvml</summary>
            public const string Xvml = "xvml";
            ///<summary>xvm</summary>
            public const string Xvm = "xvm";
            ///<summary>yang</summary>
            public const string Yang = "yang";
            ///<summary>yin</summary>
            public const string Yin = "yin";
            ///<summary>zip</summary>
            public const string Zip = "zip";
            ///<summary>3gpp</summary>
            public const string _3gpp = "3gpp";
            ///<summary>adp</summary>
            public const string Adp = "adp";
            ///<summary>amr</summary>
            public const string Amr = "amr";
            ///<summary>au</summary>
            public const string Au = "au";
            ///<summary>snd</summary>
            public const string Snd = "snd";
            ///<summary>mid</summary>
            public const string Mid = "mid";
            ///<summary>midi</summary>
            public const string Midi = "midi";
            ///<summary>kar</summary>
            public const string Kar = "kar";
            ///<summary>rmi</summary>
            public const string Rmi = "rmi";
            ///<summary>mxmf</summary>
            public const string Mxmf = "mxmf";
            ///<summary>mp3</summary>
            public const string Mp3 = "mp3";
            ///<summary>m4a</summary>
            public const string M4a = "m4a";
            ///<summary>mp4a</summary>
            public const string Mp4a = "mp4a";
            ///<summary>mpga</summary>
            public const string Mpga = "mpga";
            ///<summary>mp2</summary>
            public const string Mp2 = "mp2";
            ///<summary>mp2a</summary>
            public const string Mp2a = "mp2a";
            ///<summary>m2a</summary>
            public const string M2a = "m2a";
            ///<summary>m3a</summary>
            public const string M3a = "m3a";
            ///<summary>oga</summary>
            public const string Oga = "oga";
            ///<summary>ogg</summary>
            public const string Ogg = "ogg";
            ///<summary>spx</summary>
            public const string Spx = "spx";
            ///<summary>opus</summary>
            public const string Opus = "opus";
            ///<summary>s3m</summary>
            public const string S3m = "s3m";
            ///<summary>sil</summary>
            public const string Sil = "sil";
            ///<summary>uva</summary>
            public const string Uva = "uva";
            ///<summary>uvva</summary>
            public const string Uvva = "uvva";
            ///<summary>eol</summary>
            public const string Eol = "eol";
            ///<summary>dra</summary>
            public const string Dra = "dra";
            ///<summary>dts</summary>
            public const string Dts = "dts";
            ///<summary>dtshd</summary>
            public const string Dtshd = "dtshd";
            ///<summary>lvp</summary>
            public const string Lvp = "lvp";
            ///<summary>pya</summary>
            public const string Pya = "pya";
            ///<summary>ecelp4800</summary>
            public const string Ecelp4800 = "ecelp4800";
            ///<summary>ecelp7470</summary>
            public const string Ecelp7470 = "ecelp7470";
            ///<summary>ecelp9600</summary>
            public const string Ecelp9600 = "ecelp9600";
            ///<summary>rip</summary>
            public const string Rip = "rip";
            ///<summary>wav</summary>
            public const string Wav = "wav";
            ///<summary>weba</summary>
            public const string Weba = "weba";
            ///<summary>aac</summary>
            public const string Aac = "aac";
            ///<summary>aif</summary>
            public const string Aif = "aif";
            ///<summary>aiff</summary>
            public const string Aiff = "aiff";
            ///<summary>aifc</summary>
            public const string Aifc = "aifc";
            ///<summary>caf</summary>
            public const string Caf = "caf";
            ///<summary>flac</summary>
            public const string Flac = "flac";
            ///<summary>mka</summary>
            public const string Mka = "mka";
            ///<summary>m3u</summary>
            public const string M3u = "m3u";
            ///<summary>wax</summary>
            public const string Wax = "wax";
            ///<summary>wma</summary>
            public const string Wma = "wma";
            ///<summary>ram</summary>
            public const string Ram = "ram";
            ///<summary>ra</summary>
            public const string Ra = "ra";
            ///<summary>rmp</summary>
            public const string Rmp = "rmp";
            ///<summary>xm</summary>
            public const string Xm = "xm";
            ///<summary>cdx</summary>
            public const string Cdx = "cdx";
            ///<summary>cif</summary>
            public const string Cif = "cif";
            ///<summary>cmdf</summary>
            public const string Cmdf = "cmdf";
            ///<summary>cml</summary>
            public const string Cml = "cml";
            ///<summary>csml</summary>
            public const string Csml = "csml";
            ///<summary>xyz</summary>
            public const string Xyz = "xyz";
            ///<summary>ttc</summary>
            public const string Ttc = "ttc";
            ///<summary>otf</summary>
            public const string Otf = "otf";
            ///<summary>ttf</summary>
            public const string Ttf = "ttf";
            ///<summary>woff</summary>
            public const string Woff = "woff";
            ///<summary>woff2</summary>
            public const string Woff2 = "woff2";
            ///<summary>exr</summary>
            public const string Exr = "exr";
            ///<summary>apng</summary>
            public const string Apng = "apng";
            ///<summary>avci</summary>
            public const string Avci = "avci";
            ///<summary>avcs</summary>
            public const string Avcs = "avcs";
            ///<summary>avif</summary>
            public const string Avif = "avif";
            ///<summary>bmp</summary>
            public const string Bmp = "bmp";
            ///<summary>cgm</summary>
            public const string Cgm = "cgm";
            ///<summary>drle</summary>
            public const string Drle = "drle";
            ///<summary>fits</summary>
            public const string Fits = "fits";
            ///<summary>g3</summary>
            public const string G3 = "g3";
            ///<summary>gif</summary>
            public const string Gif = "gif";
            ///<summary>heic</summary>
            public const string Heic = "heic";
            ///<summary>heics</summary>
            public const string Heics = "heics";
            ///<summary>heif</summary>
            public const string Heif = "heif";
            ///<summary>heifs</summary>
            public const string Heifs = "heifs";
            ///<summary>hej2</summary>
            public const string Hej2 = "hej2";
            ///<summary>hsj2</summary>
            public const string Hsj2 = "hsj2";
            ///<summary>ief</summary>
            public const string Ief = "ief";
            ///<summary>jls</summary>
            public const string Jls = "jls";
            ///<summary>jp2</summary>
            public const string Jp2 = "jp2";
            ///<summary>jpg2</summary>
            public const string Jpg2 = "jpg2";
            ///<summary>jpeg</summary>
            public const string Jpeg = "jpeg";
            ///<summary>jpg</summary>
            public const string Jpg = "jpg";
            ///<summary>jpe</summary>
            public const string Jpe = "jpe";
            ///<summary>jph</summary>
            public const string Jph = "jph";
            ///<summary>jhc</summary>
            public const string Jhc = "jhc";
            ///<summary>jpm</summary>
            public const string Jpm = "jpm";
            ///<summary>jpx</summary>
            public const string Jpx = "jpx";
            ///<summary>jpf</summary>
            public const string Jpf = "jpf";
            ///<summary>jxr</summary>
            public const string Jxr = "jxr";
            ///<summary>jxra</summary>
            public const string Jxra = "jxra";
            ///<summary>jxrs</summary>
            public const string Jxrs = "jxrs";
            ///<summary>jxs</summary>
            public const string Jxs = "jxs";
            ///<summary>jxsc</summary>
            public const string Jxsc = "jxsc";
            ///<summary>jxsi</summary>
            public const string Jxsi = "jxsi";
            ///<summary>jxss</summary>
            public const string Jxss = "jxss";
            ///<summary>ktx</summary>
            public const string Ktx = "ktx";
            ///<summary>ktx2</summary>
            public const string Ktx2 = "ktx2";
            ///<summary>png</summary>
            public const string Png = "png";
            ///<summary>btif</summary>
            public const string Btif = "btif";
            ///<summary>pti</summary>
            public const string Pti = "pti";
            ///<summary>sgi</summary>
            public const string Sgi = "sgi";
            ///<summary>svg</summary>
            public const string Svg = "svg";
            ///<summary>svgz</summary>
            public const string Svgz = "svgz";
            ///<summary>t38</summary>
            public const string T38 = "t38";
            ///<summary>tif</summary>
            public const string Tif = "tif";
            ///<summary>tiff</summary>
            public const string Tiff = "tiff";
            ///<summary>tfx</summary>
            public const string Tfx = "tfx";
            ///<summary>psd</summary>
            public const string Psd = "psd";
            ///<summary>azv</summary>
            public const string Azv = "azv";
            ///<summary>uvi</summary>
            public const string Uvi = "uvi";
            ///<summary>uvvi</summary>
            public const string Uvvi = "uvvi";
            ///<summary>uvg</summary>
            public const string Uvg = "uvg";
            ///<summary>uvvg</summary>
            public const string Uvvg = "uvvg";
            ///<summary>djvu</summary>
            public const string Djvu = "djvu";
            ///<summary>djv</summary>
            public const string Djv = "djv";
            ///<summary>sub</summary>
            public const string Sub = "sub";
            ///<summary>dwg</summary>
            public const string Dwg = "dwg";
            ///<summary>dxf</summary>
            public const string Dxf = "dxf";
            ///<summary>fbs</summary>
            public const string Fbs = "fbs";
            ///<summary>fpx</summary>
            public const string Fpx = "fpx";
            ///<summary>fst</summary>
            public const string Fst = "fst";
            ///<summary>mmr</summary>
            public const string Mmr = "mmr";
            ///<summary>rlc</summary>
            public const string Rlc = "rlc";
            ///<summary>ico</summary>
            public const string Ico = "ico";
            ///<summary>dds</summary>
            public const string Dds = "dds";
            ///<summary>mdi</summary>
            public const string Mdi = "mdi";
            ///<summary>wdp</summary>
            public const string Wdp = "wdp";
            ///<summary>npx</summary>
            public const string Npx = "npx";
            ///<summary>b16</summary>
            public const string B16 = "b16";
            ///<summary>tap</summary>
            public const string Tap = "tap";
            ///<summary>vtf</summary>
            public const string Vtf = "vtf";
            ///<summary>wbmp</summary>
            public const string Wbmp = "wbmp";
            ///<summary>xif</summary>
            public const string Xif = "xif";
            ///<summary>pcx</summary>
            public const string Pcx = "pcx";
            ///<summary>webp</summary>
            public const string Webp = "webp";
            ///<summary>3ds</summary>
            public const string _3ds = "3ds";
            ///<summary>ras</summary>
            public const string Ras = "ras";
            ///<summary>cmx</summary>
            public const string Cmx = "cmx";
            ///<summary>fh</summary>
            public const string Fh = "fh";
            ///<summary>fhc</summary>
            public const string Fhc = "fhc";
            ///<summary>fh4</summary>
            public const string Fh4 = "fh4";
            ///<summary>fh5</summary>
            public const string Fh5 = "fh5";
            ///<summary>fh7</summary>
            public const string Fh7 = "fh7";
            ///<summary>jng</summary>
            public const string Jng = "jng";
            ///<summary>sid</summary>
            public const string Sid = "sid";
            ///<summary>pic</summary>
            public const string Pic = "pic";
            ///<summary>pct</summary>
            public const string Pct = "pct";
            ///<summary>pnm</summary>
            public const string Pnm = "pnm";
            ///<summary>pbm</summary>
            public const string Pbm = "pbm";
            ///<summary>pgm</summary>
            public const string Pgm = "pgm";
            ///<summary>ppm</summary>
            public const string Ppm = "ppm";
            ///<summary>rgb</summary>
            public const string Rgb = "rgb";
            ///<summary>tga</summary>
            public const string Tga = "tga";
            ///<summary>xbm</summary>
            public const string Xbm = "xbm";
            ///<summary>xpm</summary>
            public const string Xpm = "xpm";
            ///<summary>xwd</summary>
            public const string Xwd = "xwd";
            ///<summary>disposition-notification</summary>
            public const string Disposition_notification = "disposition-notification";
            ///<summary>u8msg</summary>
            public const string U8msg = "u8msg";
            ///<summary>u8dsn</summary>
            public const string U8dsn = "u8dsn";
            ///<summary>u8mdn</summary>
            public const string U8mdn = "u8mdn";
            ///<summary>u8hdr</summary>
            public const string U8hdr = "u8hdr";
            ///<summary>eml</summary>
            public const string Eml = "eml";
            ///<summary>mime</summary>
            public const string Mime = "mime";
            ///<summary>wsc</summary>
            public const string Wsc = "wsc";
            ///<summary>3mf</summary>
            public const string _3mf = "3mf";
            ///<summary>gltf</summary>
            public const string Gltf = "gltf";
            ///<summary>glb</summary>
            public const string Glb = "glb";
            ///<summary>igs</summary>
            public const string Igs = "igs";
            ///<summary>iges</summary>
            public const string Iges = "iges";
            ///<summary>msh</summary>
            public const string Msh = "msh";
            ///<summary>mesh</summary>
            public const string Mesh = "mesh";
            ///<summary>silo</summary>
            public const string Silo = "silo";
            ///<summary>mtl</summary>
            public const string Mtl = "mtl";
            ///<summary>stpx</summary>
            public const string Stpx = "stpx";
            ///<summary>stpz</summary>
            public const string Stpz = "stpz";
            ///<summary>stpxz</summary>
            public const string Stpxz = "stpxz";
            ///<summary>dae</summary>
            public const string Dae = "dae";
            ///<summary>dwf</summary>
            public const string Dwf = "dwf";
            ///<summary>gdl</summary>
            public const string Gdl = "gdl";
            ///<summary>gtw</summary>
            public const string Gtw = "gtw";
            ///<summary>mts</summary>
            public const string Mts = "mts";
            ///<summary>ogex</summary>
            public const string Ogex = "ogex";
            ///<summary>x_b</summary>
            public const string X_b = "x_b";
            ///<summary>x_t</summary>
            public const string X_t = "x_t";
            ///<summary>vds</summary>
            public const string Vds = "vds";
            ///<summary>usdz</summary>
            public const string Usdz = "usdz";
            ///<summary>bsp</summary>
            public const string Bsp = "bsp";
            ///<summary>vtu</summary>
            public const string Vtu = "vtu";
            ///<summary>wrl</summary>
            public const string Wrl = "wrl";
            ///<summary>vrml</summary>
            public const string Vrml = "vrml";
            ///<summary>x3db</summary>
            public const string X3db = "x3db";
            ///<summary>x3dbz</summary>
            public const string X3dbz = "x3dbz";
            ///<summary>x3dv</summary>
            public const string X3dv = "x3dv";
            ///<summary>x3dvz</summary>
            public const string X3dvz = "x3dvz";
            ///<summary>x3d</summary>
            public const string X3d = "x3d";
            ///<summary>x3dz</summary>
            public const string X3dz = "x3dz";
            ///<summary>appcache</summary>
            public const string Appcache = "appcache";
            ///<summary>manifest</summary>
            public const string Manifest = "manifest";
            ///<summary>ics</summary>
            public const string Ics = "ics";
            ///<summary>ifb</summary>
            public const string Ifb = "ifb";
            ///<summary>coffee</summary>
            public const string Coffee = "coffee";
            ///<summary>litcoffee</summary>
            public const string Litcoffee = "litcoffee";
            ///<summary>css</summary>
            public const string Css = "css";
            ///<summary>csv</summary>
            public const string Csv = "csv";
            ///<summary>html</summary>
            public const string Html = "html";
            ///<summary>htm</summary>
            public const string Htm = "htm";
            ///<summary>shtml</summary>
            public const string Shtml = "shtml";
            ///<summary>jade</summary>
            public const string Jade = "jade";
            ///<summary>jsx</summary>
            public const string Jsx = "jsx";
            ///<summary>less</summary>
            public const string Less = "less";
            ///<summary>markdown</summary>
            public const string Markdown = "markdown";
            ///<summary>md</summary>
            public const string Md = "md";
            ///<summary>mml</summary>
            public const string Mml = "mml";
            ///<summary>mdx</summary>
            public const string Mdx = "mdx";
            ///<summary>n3</summary>
            public const string N3 = "n3";
            ///<summary>txt</summary>
            public const string Txt = "txt";
            ///<summary>text</summary>
            public const string Text = "text";
            ///<summary>conf</summary>
            public const string Conf = "conf";
            ///<summary>def</summary>
            public const string Def = "def";
            ///<summary>list</summary>
            public const string List = "list";
            ///<summary>log</summary>
            public const string Log = "log";
            ///<summary>in</summary>
            public const string In = "in";
            ///<summary>ini</summary>
            public const string Ini = "ini";
            ///<summary>dsc</summary>
            public const string Dsc = "dsc";
            ///<summary>rtx</summary>
            public const string Rtx = "rtx";
            ///<summary>sgml</summary>
            public const string Sgml = "sgml";
            ///<summary>sgm</summary>
            public const string Sgm = "sgm";
            ///<summary>shex</summary>
            public const string Shex = "shex";
            ///<summary>slim</summary>
            public const string Slim = "slim";
            ///<summary>slm</summary>
            public const string Slm = "slm";
            ///<summary>spdx</summary>
            public const string Spdx = "spdx";
            ///<summary>stylus</summary>
            public const string Stylus = "stylus";
            ///<summary>styl</summary>
            public const string Styl = "styl";
            ///<summary>tsv</summary>
            public const string Tsv = "tsv";
            ///<summary>t</summary>
            public const string T = "t";
            ///<summary>tr</summary>
            public const string Tr = "tr";
            ///<summary>roff</summary>
            public const string Roff = "roff";
            ///<summary>man</summary>
            public const string Man = "man";
            ///<summary>me</summary>
            public const string Me = "me";
            ///<summary>ms</summary>
            public const string Ms = "ms";
            ///<summary>ttl</summary>
            public const string Ttl = "ttl";
            ///<summary>uri</summary>
            public const string Uri = "uri";
            ///<summary>uris</summary>
            public const string Uris = "uris";
            ///<summary>urls</summary>
            public const string Urls = "urls";
            ///<summary>vcard</summary>
            public const string Vcard = "vcard";
            ///<summary>curl</summary>
            public const string Curl = "curl";
            ///<summary>dcurl</summary>
            public const string Dcurl = "dcurl";
            ///<summary>mcurl</summary>
            public const string Mcurl = "mcurl";
            ///<summary>scurl</summary>
            public const string Scurl = "scurl";
            ///<summary>ged</summary>
            public const string Ged = "ged";
            ///<summary>fly</summary>
            public const string Fly = "fly";
            ///<summary>flx</summary>
            public const string Flx = "flx";
            ///<summary>gv</summary>
            public const string Gv = "gv";
            ///<summary>3dml</summary>
            public const string _3dml = "3dml";
            ///<summary>spot</summary>
            public const string Spot = "spot";
            ///<summary>jad</summary>
            public const string Jad = "jad";
            ///<summary>wml</summary>
            public const string Wml = "wml";
            ///<summary>wmls</summary>
            public const string Wmls = "wmls";
            ///<summary>vtt</summary>
            public const string Vtt = "vtt";
            ///<summary>s</summary>
            public const string S = "s";
            ///<summary>asm</summary>
            public const string Asm = "asm";
            ///<summary>c</summary>
            public const string C = "c";
            ///<summary>cc</summary>
            public const string Cc = "cc";
            ///<summary>cxx</summary>
            public const string Cxx = "cxx";
            ///<summary>cpp</summary>
            public const string Cpp = "cpp";
            ///<summary>h</summary>
            public const string H = "h";
            ///<summary>hh</summary>
            public const string Hh = "hh";
            ///<summary>dic</summary>
            public const string Dic = "dic";
            ///<summary>htc</summary>
            public const string Htc = "htc";
            ///<summary>f</summary>
            public const string F = "f";
            ///<summary>for</summary>
            public const string For = "for";
            ///<summary>f77</summary>
            public const string F77 = "f77";
            ///<summary>f90</summary>
            public const string F90 = "f90";
            ///<summary>hbs</summary>
            public const string Hbs = "hbs";
            ///<summary>java</summary>
            public const string Java = "java";
            ///<summary>lua</summary>
            public const string Lua = "lua";
            ///<summary>mkd</summary>
            public const string Mkd = "mkd";
            ///<summary>nfo</summary>
            public const string Nfo = "nfo";
            ///<summary>opml</summary>
            public const string Opml = "opml";
            ///<summary>p</summary>
            public const string P = "p";
            ///<summary>pas</summary>
            public const string Pas = "pas";
            ///<summary>pde</summary>
            public const string Pde = "pde";
            ///<summary>sass</summary>
            public const string Sass = "sass";
            ///<summary>scss</summary>
            public const string Scss = "scss";
            ///<summary>etx</summary>
            public const string Etx = "etx";
            ///<summary>sfv</summary>
            public const string Sfv = "sfv";
            ///<summary>ymp</summary>
            public const string Ymp = "ymp";
            ///<summary>uu</summary>
            public const string Uu = "uu";
            ///<summary>vcs</summary>
            public const string Vcs = "vcs";
            ///<summary>vcf</summary>
            public const string Vcf = "vcf";
            ///<summary>yaml</summary>
            public const string Yaml = "yaml";
            ///<summary>yml</summary>
            public const string Yml = "yml";
            ///<summary>3gp</summary>
            public const string _3gp = "3gp";
            ///<summary>3g2</summary>
            public const string _3g2 = "3g2";
            ///<summary>h261</summary>
            public const string H261 = "h261";
            ///<summary>h263</summary>
            public const string H263 = "h263";
            ///<summary>h264</summary>
            public const string H264 = "h264";
            ///<summary>m4s</summary>
            public const string M4s = "m4s";
            ///<summary>jpgv</summary>
            public const string Jpgv = "jpgv";
            ///<summary>jpgm</summary>
            public const string Jpgm = "jpgm";
            ///<summary>mj2</summary>
            public const string Mj2 = "mj2";
            ///<summary>mjp2</summary>
            public const string Mjp2 = "mjp2";
            ///<summary>ts</summary>
            public const string Ts = "ts";
            ///<summary>mp4</summary>
            public const string Mp4 = "mp4";
            ///<summary>mp4v</summary>
            public const string Mp4v = "mp4v";
            ///<summary>mpg4</summary>
            public const string Mpg4 = "mpg4";
            ///<summary>mpeg</summary>
            public const string Mpeg = "mpeg";
            ///<summary>mpg</summary>
            public const string Mpg = "mpg";
            ///<summary>mpe</summary>
            public const string Mpe = "mpe";
            ///<summary>m1v</summary>
            public const string M1v = "m1v";
            ///<summary>m2v</summary>
            public const string M2v = "m2v";
            ///<summary>ogv</summary>
            public const string Ogv = "ogv";
            ///<summary>qt</summary>
            public const string Qt = "qt";
            ///<summary>mov</summary>
            public const string Mov = "mov";
            ///<summary>uvh</summary>
            public const string Uvh = "uvh";
            ///<summary>uvvh</summary>
            public const string Uvvh = "uvvh";
            ///<summary>uvm</summary>
            public const string Uvm = "uvm";
            ///<summary>uvvm</summary>
            public const string Uvvm = "uvvm";
            ///<summary>uvp</summary>
            public const string Uvp = "uvp";
            ///<summary>uvvp</summary>
            public const string Uvvp = "uvvp";
            ///<summary>uvs</summary>
            public const string Uvs = "uvs";
            ///<summary>uvvs</summary>
            public const string Uvvs = "uvvs";
            ///<summary>uvv</summary>
            public const string Uvv = "uvv";
            ///<summary>uvvv</summary>
            public const string Uvvv = "uvvv";
            ///<summary>dvb</summary>
            public const string Dvb = "dvb";
            ///<summary>fvt</summary>
            public const string Fvt = "fvt";
            ///<summary>mxu</summary>
            public const string Mxu = "mxu";
            ///<summary>m4u</summary>
            public const string M4u = "m4u";
            ///<summary>pyv</summary>
            public const string Pyv = "pyv";
            ///<summary>uvu</summary>
            public const string Uvu = "uvu";
            ///<summary>uvvu</summary>
            public const string Uvvu = "uvvu";
            ///<summary>viv</summary>
            public const string Viv = "viv";
            ///<summary>webm</summary>
            public const string Webm = "webm";
            ///<summary>f4v</summary>
            public const string F4v = "f4v";
            ///<summary>fli</summary>
            public const string Fli = "fli";
            ///<summary>flv</summary>
            public const string Flv = "flv";
            ///<summary>m4v</summary>
            public const string M4v = "m4v";
            ///<summary>mkv</summary>
            public const string Mkv = "mkv";
            ///<summary>mk3d</summary>
            public const string Mk3d = "mk3d";
            ///<summary>mks</summary>
            public const string Mks = "mks";
            ///<summary>mng</summary>
            public const string Mng = "mng";
            ///<summary>asf</summary>
            public const string Asf = "asf";
            ///<summary>asx</summary>
            public const string Asx = "asx";
            ///<summary>vob</summary>
            public const string Vob = "vob";
            ///<summary>wm</summary>
            public const string Wm = "wm";
            ///<summary>wmv</summary>
            public const string Wmv = "wmv";
            ///<summary>wmx</summary>
            public const string Wmx = "wmx";
            ///<summary>wvx</summary>
            public const string Wvx = "wvx";
            ///<summary>avi</summary>
            public const string Avi = "avi";
            ///<summary>movie</summary>
            public const string Movie = "movie";
            ///<summary>smv</summary>
            public const string Smv = "smv";
            ///<summary>ice</summary>
            public const string Ice = "ice";
        }

        // List of all available extensions, used to build the dictionary
        internal static readonly Lazy<string[]> ALL_EXTS = new Lazy<string[]>(() => new [] {
            FileExtensions.Ez,
            FileExtensions.Aw,
            FileExtensions.Atom,
            FileExtensions.Atomcat,
            FileExtensions.Atomdeleted,
            FileExtensions.Atomsvc,
            FileExtensions.Dwd,
            FileExtensions.Held,
            FileExtensions.Rsat,
            FileExtensions.Bdoc,
            FileExtensions.Xcs,
            FileExtensions.Ccxml,
            FileExtensions.Cdfx,
            FileExtensions.Cdmia,
            FileExtensions.Cdmic,
            FileExtensions.Cdmid,
            FileExtensions.Cdmio,
            FileExtensions.Cdmiq,
            FileExtensions.Cpl,
            FileExtensions.Cu,
            FileExtensions.Mpd,
            FileExtensions.Mpp,
            FileExtensions.Davmount,
            FileExtensions.Dbk,
            FileExtensions.Dssc,
            FileExtensions.Xdssc,
            FileExtensions.Es,
            FileExtensions.Ecma,
            FileExtensions.Emma,
            FileExtensions.Emotionml,
            FileExtensions.Epub,
            FileExtensions.Exi,
            FileExtensions.Exp,
            FileExtensions.Fdt,
            FileExtensions.Pfr,
            FileExtensions.Geojson,
            FileExtensions.Gml,
            FileExtensions.Gpx,
            FileExtensions.Gxf,
            FileExtensions.Gz,
            FileExtensions.Hjson,
            FileExtensions.Stk,
            FileExtensions.Ink,
            FileExtensions.Inkml,
            FileExtensions.Ipfix,
            FileExtensions.Its,
            FileExtensions.Jar,
            FileExtensions.War,
            FileExtensions.Ear,
            FileExtensions.Ser,
            FileExtensions.Class,
            FileExtensions.Js,
            FileExtensions.Mjs,
            FileExtensions.Json,
            FileExtensions.Map,
            FileExtensions.Json5,
            FileExtensions.Jsonml,
            FileExtensions.Jsonld,
            FileExtensions.Lgr,
            FileExtensions.Lostxml,
            FileExtensions.Hqx,
            FileExtensions.Cpt,
            FileExtensions.Mads,
            FileExtensions.Webmanifest,
            FileExtensions.Mrc,
            FileExtensions.Mrcx,
            FileExtensions.Ma,
            FileExtensions.Nb,
            FileExtensions.Mb,
            FileExtensions.Mathml,
            FileExtensions.Mbox,
            FileExtensions.Mpf,
            FileExtensions.Mscml,
            FileExtensions.Metalink,
            FileExtensions.Meta4,
            FileExtensions.Mets,
            FileExtensions.Maei,
            FileExtensions.Musd,
            FileExtensions.Mods,
            FileExtensions.M21,
            FileExtensions.Mp21,
            FileExtensions.Mp4s,
            FileExtensions.M4p,
            FileExtensions.Doc,
            FileExtensions.Dot,
            FileExtensions.Mxf,
            FileExtensions.Nq,
            FileExtensions.Nt,
            FileExtensions.Cjs,
            FileExtensions.Bin,
            FileExtensions.Dms,
            FileExtensions.Lrf,
            FileExtensions.Mar,
            FileExtensions.So,
            FileExtensions.Dist,
            FileExtensions.Distz,
            FileExtensions.Pkg,
            FileExtensions.Bpk,
            FileExtensions.Dump,
            FileExtensions.Elc,
            FileExtensions.Deploy,
            FileExtensions.Exe,
            FileExtensions.Dll,
            FileExtensions.Deb,
            FileExtensions.Dmg,
            FileExtensions.Iso,
            FileExtensions.Img,
            FileExtensions.Msi,
            FileExtensions.Msp,
            FileExtensions.Msm,
            FileExtensions.Buffer,
            FileExtensions.Oda,
            FileExtensions.Opf,
            FileExtensions.Ogx,
            FileExtensions.Omdoc,
            FileExtensions.Onetoc,
            FileExtensions.Onetoc2,
            FileExtensions.Onetmp,
            FileExtensions.Onepkg,
            FileExtensions.Oxps,
            FileExtensions.Relo,
            FileExtensions.Xer,
            FileExtensions.Pdf,
            FileExtensions.Pgp,
            FileExtensions.Asc,
            FileExtensions.Sig,
            FileExtensions.Prf,
            FileExtensions.P10,
            FileExtensions.P7m,
            FileExtensions.P7c,
            FileExtensions.P7s,
            FileExtensions.P8,
            FileExtensions.Ac,
            FileExtensions.Cer,
            FileExtensions.Crl,
            FileExtensions.Pkipath,
            FileExtensions.Pki,
            FileExtensions.Pls,
            FileExtensions.Ai,
            FileExtensions.Eps,
            FileExtensions.Ps,
            FileExtensions.Provx,
            FileExtensions.Cww,
            FileExtensions.Pskcxml,
            FileExtensions.Raml,
            FileExtensions.Rdf,
            FileExtensions.Owl,
            FileExtensions.Rif,
            FileExtensions.Rnc,
            FileExtensions.Rl,
            FileExtensions.Rld,
            FileExtensions.Rs,
            FileExtensions.Rapd,
            FileExtensions.Sls,
            FileExtensions.Rusd,
            FileExtensions.Gbr,
            FileExtensions.Mft,
            FileExtensions.Roa,
            FileExtensions.Rsd,
            FileExtensions.Rss,
            FileExtensions.Rtf,
            FileExtensions.Sbml,
            FileExtensions.Scq,
            FileExtensions.Scs,
            FileExtensions.Spq,
            FileExtensions.Spp,
            FileExtensions.Sdp,
            FileExtensions.Senmlx,
            FileExtensions.Sensmlx,
            FileExtensions.Setpay,
            FileExtensions.Setreg,
            FileExtensions.Shf,
            FileExtensions.Siv,
            FileExtensions.Sieve,
            FileExtensions.Smi,
            FileExtensions.Smil,
            FileExtensions.Rq,
            FileExtensions.Srx,
            FileExtensions.Gram,
            FileExtensions.Grxml,
            FileExtensions.Sru,
            FileExtensions.Ssdl,
            FileExtensions.Ssml,
            FileExtensions.Swidtag,
            FileExtensions.Tei,
            FileExtensions.Teicorpus,
            FileExtensions.Tfi,
            FileExtensions.Tsd,
            FileExtensions.Toml,
            FileExtensions.Trig,
            FileExtensions.Ttml,
            FileExtensions.Ubj,
            FileExtensions.Rsheet,
            FileExtensions.Td,
            FileExtensions._1km,
            FileExtensions.Plb,
            FileExtensions.Psb,
            FileExtensions.Pvb,
            FileExtensions.Tcap,
            FileExtensions.Pwn,
            FileExtensions.Aso,
            FileExtensions.Imp,
            FileExtensions.Acu,
            FileExtensions.Atc,
            FileExtensions.Acutc,
            FileExtensions.Air,
            FileExtensions.Fcdt,
            FileExtensions.Fxp,
            FileExtensions.Fxpl,
            FileExtensions.Xdp,
            FileExtensions.Xfdf,
            FileExtensions.Age,
            FileExtensions.Ahead,
            FileExtensions.Azf,
            FileExtensions.Azs,
            FileExtensions.Azw,
            FileExtensions.Acc,
            FileExtensions.Ami,
            FileExtensions.Apk,
            FileExtensions.Cii,
            FileExtensions.Fti,
            FileExtensions.Atx,
            FileExtensions.Mpkg,
            FileExtensions.Key,
            FileExtensions.M3u8,
            FileExtensions.Numbers,
            FileExtensions.Pages,
            FileExtensions.Pkpass,
            FileExtensions.Swi,
            FileExtensions.Iota,
            FileExtensions.Aep,
            FileExtensions.Bmml,
            FileExtensions.Mpm,
            FileExtensions.Bmi,
            FileExtensions.Rep,
            FileExtensions.Cdxml,
            FileExtensions.Mmd,
            FileExtensions.Cdy,
            FileExtensions.Csl,
            FileExtensions.Cla,
            FileExtensions.Rp9,
            FileExtensions.C4g,
            FileExtensions.C4d,
            FileExtensions.C4f,
            FileExtensions.C4p,
            FileExtensions.C4u,
            FileExtensions.C11amc,
            FileExtensions.C11amz,
            FileExtensions.Csp,
            FileExtensions.Cdbcmsg,
            FileExtensions.Cmc,
            FileExtensions.Clkx,
            FileExtensions.Clkk,
            FileExtensions.Clkp,
            FileExtensions.Clkt,
            FileExtensions.Clkw,
            FileExtensions.Wbs,
            FileExtensions.Pml,
            FileExtensions.Ppd,
            FileExtensions.Car,
            FileExtensions.Pcurl,
            FileExtensions.Dart,
            FileExtensions.Rdz,
            FileExtensions.Dbf,
            FileExtensions.Uvf,
            FileExtensions.Uvvf,
            FileExtensions.Uvd,
            FileExtensions.Uvvd,
            FileExtensions.Uvt,
            FileExtensions.Uvvt,
            FileExtensions.Uvx,
            FileExtensions.Uvvx,
            FileExtensions.Uvz,
            FileExtensions.Uvvz,
            FileExtensions.Fe_launch,
            FileExtensions.Dna,
            FileExtensions.Mlp,
            FileExtensions.Dpg,
            FileExtensions.Dfac,
            FileExtensions.Kpxx,
            FileExtensions.Ait,
            FileExtensions.Svc,
            FileExtensions.Geo,
            FileExtensions.Mag,
            FileExtensions.Nml,
            FileExtensions.Esf,
            FileExtensions.Msf,
            FileExtensions.Qam,
            FileExtensions.Slt,
            FileExtensions.Ssf,
            FileExtensions.Es3,
            FileExtensions.Et3,
            FileExtensions.Ez2,
            FileExtensions.Ez3,
            FileExtensions.Fdf,
            FileExtensions.Mseed,
            FileExtensions.Seed,
            FileExtensions.Dataless,
            FileExtensions.Gph,
            FileExtensions.Ftc,
            FileExtensions.Fm,
            FileExtensions.Frame,
            FileExtensions.Maker,
            FileExtensions.Book,
            FileExtensions.Fnc,
            FileExtensions.Ltf,
            FileExtensions.Fsc,
            FileExtensions.Oas,
            FileExtensions.Oa2,
            FileExtensions.Oa3,
            FileExtensions.Fg5,
            FileExtensions.Bh2,
            FileExtensions.Ddd,
            FileExtensions.Xdw,
            FileExtensions.Xbd,
            FileExtensions.Fzs,
            FileExtensions.Txd,
            FileExtensions.Ggb,
            FileExtensions.Ggt,
            FileExtensions.Gex,
            FileExtensions.Gre,
            FileExtensions.Gxt,
            FileExtensions.G2w,
            FileExtensions.G3w,
            FileExtensions.Gmx,
            FileExtensions.Gdoc,
            FileExtensions.Gslides,
            FileExtensions.Gsheet,
            FileExtensions.Kml,
            FileExtensions.Kmz,
            FileExtensions.Gqf,
            FileExtensions.Gqs,
            FileExtensions.Gac,
            FileExtensions.Ghf,
            FileExtensions.Gim,
            FileExtensions.Grv,
            FileExtensions.Gtm,
            FileExtensions.Tpl,
            FileExtensions.Vcg,
            FileExtensions.Hal,
            FileExtensions.Zmm,
            FileExtensions.Hbci,
            FileExtensions.Les,
            FileExtensions.Hpgl,
            FileExtensions.Hpid,
            FileExtensions.Hps,
            FileExtensions.Jlt,
            FileExtensions.Pcl,
            FileExtensions.Pclxl,
            FileExtensions.Sfd_hdstx,
            FileExtensions.Mpy,
            FileExtensions.Afp,
            FileExtensions.Listafp,
            FileExtensions.List3820,
            FileExtensions.Irm,
            FileExtensions.Sc,
            FileExtensions.Icc,
            FileExtensions.Icm,
            FileExtensions.Igl,
            FileExtensions.Ivp,
            FileExtensions.Ivu,
            FileExtensions.Igm,
            FileExtensions.Xpw,
            FileExtensions.Xpx,
            FileExtensions.I2g,
            FileExtensions.Qbo,
            FileExtensions.Qfx,
            FileExtensions.Rcprofile,
            FileExtensions.Irp,
            FileExtensions.Xpr,
            FileExtensions.Fcs,
            FileExtensions.Jam,
            FileExtensions.Rms,
            FileExtensions.Jisp,
            FileExtensions.Joda,
            FileExtensions.Ktz,
            FileExtensions.Ktr,
            FileExtensions.Karbon,
            FileExtensions.Chrt,
            FileExtensions.Kfo,
            FileExtensions.Flw,
            FileExtensions.Kon,
            FileExtensions.Kpr,
            FileExtensions.Kpt,
            FileExtensions.Ksp,
            FileExtensions.Kwd,
            FileExtensions.Kwt,
            FileExtensions.Htke,
            FileExtensions.Kia,
            FileExtensions.Kne,
            FileExtensions.Knp,
            FileExtensions.Skp,
            FileExtensions.Skd,
            FileExtensions.Skt,
            FileExtensions.Skm,
            FileExtensions.Sse,
            FileExtensions.Lasxml,
            FileExtensions.Lbd,
            FileExtensions.Lbe,
            FileExtensions._123,
            FileExtensions.Apr,
            FileExtensions.Pre,
            FileExtensions.Nsf,
            FileExtensions.Org,
            FileExtensions.Scm,
            FileExtensions.Lwp,
            FileExtensions.Portpkg,
            FileExtensions.Mvt,
            FileExtensions.Mcd,
            FileExtensions.Mc1,
            FileExtensions.Cdkey,
            FileExtensions.Mwf,
            FileExtensions.Mfm,
            FileExtensions.Flo,
            FileExtensions.Igx,
            FileExtensions.Mif,
            FileExtensions.Daf,
            FileExtensions.Dis,
            FileExtensions.Mbk,
            FileExtensions.Mqy,
            FileExtensions.Msl,
            FileExtensions.Plc,
            FileExtensions.Txf,
            FileExtensions.Mpn,
            FileExtensions.Mpc,
            FileExtensions.Xul,
            FileExtensions.Cil,
            FileExtensions.Cab,
            FileExtensions.Xls,
            FileExtensions.Xlm,
            FileExtensions.Xla,
            FileExtensions.Xlc,
            FileExtensions.Xlt,
            FileExtensions.Xlw,
            FileExtensions.Xlam,
            FileExtensions.Xlsb,
            FileExtensions.Xlsm,
            FileExtensions.Xltm,
            FileExtensions.Eot,
            FileExtensions.Chm,
            FileExtensions.Ims,
            FileExtensions.Lrm,
            FileExtensions.Thmx,
            FileExtensions.Msg,
            FileExtensions.Cat,
            FileExtensions.Stl,
            FileExtensions.Ppt,
            FileExtensions.Pps,
            FileExtensions.Pot,
            FileExtensions.Ppam,
            FileExtensions.Pptm,
            FileExtensions.Sldm,
            FileExtensions.Ppsm,
            FileExtensions.Potm,
            FileExtensions.Mpt,
            FileExtensions.Docm,
            FileExtensions.Dotm,
            FileExtensions.Wps,
            FileExtensions.Wks,
            FileExtensions.Wcm,
            FileExtensions.Wdb,
            FileExtensions.Wpl,
            FileExtensions.Xps,
            FileExtensions.Mseq,
            FileExtensions.Mus,
            FileExtensions.Msty,
            FileExtensions.Taglet,
            FileExtensions.Nlu,
            FileExtensions.Ntf,
            FileExtensions.Nitf,
            FileExtensions.Nnd,
            FileExtensions.Nns,
            FileExtensions.Nnw,
            FileExtensions.Ngdat,
            FileExtensions.N_gage,
            FileExtensions.Rpst,
            FileExtensions.Rpss,
            FileExtensions.Edm,
            FileExtensions.Edx,
            FileExtensions.Ext,
            FileExtensions.Odc,
            FileExtensions.Otc,
            FileExtensions.Odb,
            FileExtensions.Odf,
            FileExtensions.Odft,
            FileExtensions.Odg,
            FileExtensions.Otg,
            FileExtensions.Odi,
            FileExtensions.Oti,
            FileExtensions.Odp,
            FileExtensions.Otp,
            FileExtensions.Ods,
            FileExtensions.Ots,
            FileExtensions.Odt,
            FileExtensions.Odm,
            FileExtensions.Ott,
            FileExtensions.Oth,
            FileExtensions.Xo,
            FileExtensions.Dd2,
            FileExtensions.Obgx,
            FileExtensions.Oxt,
            FileExtensions.Osm,
            FileExtensions.Pptx,
            FileExtensions.Sldx,
            FileExtensions.Ppsx,
            FileExtensions.Potx,
            FileExtensions.Xlsx,
            FileExtensions.Xltx,
            FileExtensions.Docx,
            FileExtensions.Dotx,
            FileExtensions.Mgp,
            FileExtensions.Dp,
            FileExtensions.Esa,
            FileExtensions.Pdb,
            FileExtensions.Pqa,
            FileExtensions.Oprc,
            FileExtensions.Paw,
            FileExtensions.Str,
            FileExtensions.Ei6,
            FileExtensions.Efif,
            FileExtensions.Wg,
            FileExtensions.Plf,
            FileExtensions.Pbd,
            FileExtensions.Box,
            FileExtensions.Mgz,
            FileExtensions.Qps,
            FileExtensions.Ptid,
            FileExtensions.Qxd,
            FileExtensions.Qxt,
            FileExtensions.Qwd,
            FileExtensions.Qwt,
            FileExtensions.Qxl,
            FileExtensions.Qxb,
            FileExtensions.Rar,
            FileExtensions.Bed,
            FileExtensions.Mxl,
            FileExtensions.Musicxml,
            FileExtensions.Cryptonote,
            FileExtensions.Cod,
            FileExtensions.Rm,
            FileExtensions.Rmvb,
            FileExtensions.Link66,
            FileExtensions.St,
            FileExtensions.See,
            FileExtensions.Sema,
            FileExtensions.Semd,
            FileExtensions.Semf,
            FileExtensions.Ifm,
            FileExtensions.Itp,
            FileExtensions.Iif,
            FileExtensions.Ipk,
            FileExtensions.Twd,
            FileExtensions.Twds,
            FileExtensions.Mmf,
            FileExtensions.Teacher,
            FileExtensions.Fo,
            FileExtensions.Sdkm,
            FileExtensions.Sdkd,
            FileExtensions.Dxp,
            FileExtensions.Sfs,
            FileExtensions.Sdc,
            FileExtensions.Sda,
            FileExtensions.Sdd,
            FileExtensions.Smf,
            FileExtensions.Sdw,
            FileExtensions.Vor,
            FileExtensions.Sgl,
            FileExtensions.Smzip,
            FileExtensions.Sm,
            FileExtensions.Wadl,
            FileExtensions.Sxc,
            FileExtensions.Stc,
            FileExtensions.Sxd,
            FileExtensions.Std,
            FileExtensions.Sxi,
            FileExtensions.Sti,
            FileExtensions.Sxm,
            FileExtensions.Sxw,
            FileExtensions.Sxg,
            FileExtensions.Stw,
            FileExtensions.Sus,
            FileExtensions.Susp,
            FileExtensions.Svd,
            FileExtensions.Sis,
            FileExtensions.Sisx,
            FileExtensions.Xsm,
            FileExtensions.Bdm,
            FileExtensions.Xdm,
            FileExtensions.Ddf,
            FileExtensions.Tao,
            FileExtensions.Pcap,
            FileExtensions.Cap,
            FileExtensions.Dmp,
            FileExtensions.Tmo,
            FileExtensions.Tpt,
            FileExtensions.Mxs,
            FileExtensions.Tra,
            FileExtensions.Ufd,
            FileExtensions.Ufdl,
            FileExtensions.Utz,
            FileExtensions.Umj,
            FileExtensions.Unityweb,
            FileExtensions.Uoml,
            FileExtensions.Vcx,
            FileExtensions.Vsd,
            FileExtensions.Vst,
            FileExtensions.Vss,
            FileExtensions.Vsw,
            FileExtensions.Vis,
            FileExtensions.Vsf,
            FileExtensions.Wbxml,
            FileExtensions.Wmlc,
            FileExtensions.Wmlsc,
            FileExtensions.Wtb,
            FileExtensions.Nbp,
            FileExtensions.Wpd,
            FileExtensions.Wqd,
            FileExtensions.Stf,
            FileExtensions.Xar,
            FileExtensions.Xfdl,
            FileExtensions.Hvd,
            FileExtensions.Hvs,
            FileExtensions.Hvp,
            FileExtensions.Osf,
            FileExtensions.Osfpvg,
            FileExtensions.Saf,
            FileExtensions.Spf,
            FileExtensions.Cmp,
            FileExtensions.Zir,
            FileExtensions.Zirz,
            FileExtensions.Zaz,
            FileExtensions.Vxml,
            FileExtensions.Wasm,
            FileExtensions.Wif,
            FileExtensions.Wgt,
            FileExtensions.Hlp,
            FileExtensions.Wsdl,
            FileExtensions.Wspolicy,
            FileExtensions._7z,
            FileExtensions.Abw,
            FileExtensions.Ace,
            FileExtensions.Arj,
            FileExtensions.Aab,
            FileExtensions.X32,
            FileExtensions.U32,
            FileExtensions.Vox,
            FileExtensions.Aam,
            FileExtensions.Aas,
            FileExtensions.Bcpio,
            FileExtensions.Torrent,
            FileExtensions.Blb,
            FileExtensions.Blorb,
            FileExtensions.Bz,
            FileExtensions.Bz2,
            FileExtensions.Boz,
            FileExtensions.Cbr,
            FileExtensions.Cba,
            FileExtensions.Cbt,
            FileExtensions.Cbz,
            FileExtensions.Cb7,
            FileExtensions.Vcd,
            FileExtensions.Cfs,
            FileExtensions.Chat,
            FileExtensions.Pgn,
            FileExtensions.Crx,
            FileExtensions.Cco,
            FileExtensions.Nsc,
            FileExtensions.Cpio,
            FileExtensions.Csh,
            FileExtensions.Udeb,
            FileExtensions.Dgc,
            FileExtensions.Dir,
            FileExtensions.Dcr,
            FileExtensions.Dxr,
            FileExtensions.Cst,
            FileExtensions.Cct,
            FileExtensions.Cxt,
            FileExtensions.W3d,
            FileExtensions.Fgd,
            FileExtensions.Swa,
            FileExtensions.Wad,
            FileExtensions.Ncx,
            FileExtensions.Dtb,
            FileExtensions.Res,
            FileExtensions.Dvi,
            FileExtensions.Evy,
            FileExtensions.Eva,
            FileExtensions.Bdf,
            FileExtensions.Gsf,
            FileExtensions.Psf,
            FileExtensions.Pcf,
            FileExtensions.Snf,
            FileExtensions.Pfa,
            FileExtensions.Pfb,
            FileExtensions.Pfm,
            FileExtensions.Afm,
            FileExtensions.Arc,
            FileExtensions.Spl,
            FileExtensions.Gca,
            FileExtensions.Ulx,
            FileExtensions.Gnumeric,
            FileExtensions.Gramps,
            FileExtensions.Gtar,
            FileExtensions.Hdf,
            FileExtensions.Php,
            FileExtensions.Install,
            FileExtensions.Jardiff,
            FileExtensions.Jnlp,
            FileExtensions.Kdbx,
            FileExtensions.Latex,
            FileExtensions.Luac,
            FileExtensions.Lzh,
            FileExtensions.Lha,
            FileExtensions.Run,
            FileExtensions.Mie,
            FileExtensions.Prc,
            FileExtensions.Mobi,
            FileExtensions.Application,
            FileExtensions.Lnk,
            FileExtensions.Wmd,
            FileExtensions.Wmz,
            FileExtensions.Xbap,
            FileExtensions.Mdb,
            FileExtensions.Obd,
            FileExtensions.Crd,
            FileExtensions.Clp,
            FileExtensions.Com,
            FileExtensions.Bat,
            FileExtensions.Mvb,
            FileExtensions.M13,
            FileExtensions.M14,
            FileExtensions.Wmf,
            FileExtensions.Emf,
            FileExtensions.Emz,
            FileExtensions.Mny,
            FileExtensions.Pub,
            FileExtensions.Scd,
            FileExtensions.Trm,
            FileExtensions.Wri,
            FileExtensions.Nc,
            FileExtensions.Cdf,
            FileExtensions.Pac,
            FileExtensions.Nzb,
            FileExtensions.Pl,
            FileExtensions.Pm,
            FileExtensions.P12,
            FileExtensions.Pfx,
            FileExtensions.P7b,
            FileExtensions.Spc,
            FileExtensions.P7r,
            FileExtensions.Rpm,
            FileExtensions.Ris,
            FileExtensions.Sea,
            FileExtensions.Sh,
            FileExtensions.Shar,
            FileExtensions.Swf,
            FileExtensions.Xap,
            FileExtensions.Sql,
            FileExtensions.Sit,
            FileExtensions.Sitx,
            FileExtensions.Srt,
            FileExtensions.Sv4cpio,
            FileExtensions.Sv4crc,
            FileExtensions.T3,
            FileExtensions.Gam,
            FileExtensions.Tar,
            FileExtensions.Tcl,
            FileExtensions.Tk,
            FileExtensions.Tex,
            FileExtensions.Tfm,
            FileExtensions.Texinfo,
            FileExtensions.Texi,
            FileExtensions.Obj,
            FileExtensions.Ustar,
            FileExtensions.Hdd,
            FileExtensions.Ova,
            FileExtensions.Ovf,
            FileExtensions.Vbox,
            FileExtensions.Vbox_extpack,
            FileExtensions.Vdi,
            FileExtensions.Vhd,
            FileExtensions.Vmdk,
            FileExtensions.Src,
            FileExtensions.Webapp,
            FileExtensions.Der,
            FileExtensions.Crt,
            FileExtensions.Pem,
            FileExtensions.Fig,
            FileExtensions.Xlf,
            FileExtensions.Xpi,
            FileExtensions.Xz,
            FileExtensions.Z1,
            FileExtensions.Z2,
            FileExtensions.Z3,
            FileExtensions.Z4,
            FileExtensions.Z5,
            FileExtensions.Z6,
            FileExtensions.Z7,
            FileExtensions.Z8,
            FileExtensions.Xaml,
            FileExtensions.Xav,
            FileExtensions.Xca,
            FileExtensions.Xdf,
            FileExtensions.Xel,
            FileExtensions.Xns,
            FileExtensions.Xenc,
            FileExtensions.Xhtml,
            FileExtensions.Xht,
            FileExtensions.Xml,
            FileExtensions.Xsl,
            FileExtensions.Xsd,
            FileExtensions.Rng,
            FileExtensions.Dtd,
            FileExtensions.Xop,
            FileExtensions.Xpl,
            FileExtensions.Xslt,
            FileExtensions.Xspf,
            FileExtensions.Mxml,
            FileExtensions.Xhvml,
            FileExtensions.Xvml,
            FileExtensions.Xvm,
            FileExtensions.Yang,
            FileExtensions.Yin,
            FileExtensions.Zip,
            FileExtensions._3gpp,
            FileExtensions.Adp,
            FileExtensions.Amr,
            FileExtensions.Au,
            FileExtensions.Snd,
            FileExtensions.Mid,
            FileExtensions.Midi,
            FileExtensions.Kar,
            FileExtensions.Rmi,
            FileExtensions.Mxmf,
            FileExtensions.Mp3,
            FileExtensions.M4a,
            FileExtensions.Mp4a,
            FileExtensions.Mpga,
            FileExtensions.Mp2,
            FileExtensions.Mp2a,
            FileExtensions.M2a,
            FileExtensions.M3a,
            FileExtensions.Oga,
            FileExtensions.Ogg,
            FileExtensions.Spx,
            FileExtensions.Opus,
            FileExtensions.S3m,
            FileExtensions.Sil,
            FileExtensions.Uva,
            FileExtensions.Uvva,
            FileExtensions.Eol,
            FileExtensions.Dra,
            FileExtensions.Dts,
            FileExtensions.Dtshd,
            FileExtensions.Lvp,
            FileExtensions.Pya,
            FileExtensions.Ecelp4800,
            FileExtensions.Ecelp7470,
            FileExtensions.Ecelp9600,
            FileExtensions.Rip,
            FileExtensions.Wav,
            FileExtensions.Weba,
            FileExtensions.Aac,
            FileExtensions.Aif,
            FileExtensions.Aiff,
            FileExtensions.Aifc,
            FileExtensions.Caf,
            FileExtensions.Flac,
            FileExtensions.Mka,
            FileExtensions.M3u,
            FileExtensions.Wax,
            FileExtensions.Wma,
            FileExtensions.Ram,
            FileExtensions.Ra,
            FileExtensions.Rmp,
            FileExtensions.Xm,
            FileExtensions.Cdx,
            FileExtensions.Cif,
            FileExtensions.Cmdf,
            FileExtensions.Cml,
            FileExtensions.Csml,
            FileExtensions.Xyz,
            FileExtensions.Ttc,
            FileExtensions.Otf,
            FileExtensions.Ttf,
            FileExtensions.Woff,
            FileExtensions.Woff2,
            FileExtensions.Exr,
            FileExtensions.Apng,
            FileExtensions.Avci,
            FileExtensions.Avcs,
            FileExtensions.Avif,
            FileExtensions.Bmp,
            FileExtensions.Cgm,
            FileExtensions.Drle,
            FileExtensions.Fits,
            FileExtensions.G3,
            FileExtensions.Gif,
            FileExtensions.Heic,
            FileExtensions.Heics,
            FileExtensions.Heif,
            FileExtensions.Heifs,
            FileExtensions.Hej2,
            FileExtensions.Hsj2,
            FileExtensions.Ief,
            FileExtensions.Jls,
            FileExtensions.Jp2,
            FileExtensions.Jpg2,
            FileExtensions.Jpeg,
            FileExtensions.Jpg,
            FileExtensions.Jpe,
            FileExtensions.Jph,
            FileExtensions.Jhc,
            FileExtensions.Jpm,
            FileExtensions.Jpx,
            FileExtensions.Jpf,
            FileExtensions.Jxr,
            FileExtensions.Jxra,
            FileExtensions.Jxrs,
            FileExtensions.Jxs,
            FileExtensions.Jxsc,
            FileExtensions.Jxsi,
            FileExtensions.Jxss,
            FileExtensions.Ktx,
            FileExtensions.Ktx2,
            FileExtensions.Png,
            FileExtensions.Btif,
            FileExtensions.Pti,
            FileExtensions.Sgi,
            FileExtensions.Svg,
            FileExtensions.Svgz,
            FileExtensions.T38,
            FileExtensions.Tif,
            FileExtensions.Tiff,
            FileExtensions.Tfx,
            FileExtensions.Psd,
            FileExtensions.Azv,
            FileExtensions.Uvi,
            FileExtensions.Uvvi,
            FileExtensions.Uvg,
            FileExtensions.Uvvg,
            FileExtensions.Djvu,
            FileExtensions.Djv,
            FileExtensions.Sub,
            FileExtensions.Dwg,
            FileExtensions.Dxf,
            FileExtensions.Fbs,
            FileExtensions.Fpx,
            FileExtensions.Fst,
            FileExtensions.Mmr,
            FileExtensions.Rlc,
            FileExtensions.Ico,
            FileExtensions.Dds,
            FileExtensions.Mdi,
            FileExtensions.Wdp,
            FileExtensions.Npx,
            FileExtensions.B16,
            FileExtensions.Tap,
            FileExtensions.Vtf,
            FileExtensions.Wbmp,
            FileExtensions.Xif,
            FileExtensions.Pcx,
            FileExtensions.Webp,
            FileExtensions._3ds,
            FileExtensions.Ras,
            FileExtensions.Cmx,
            FileExtensions.Fh,
            FileExtensions.Fhc,
            FileExtensions.Fh4,
            FileExtensions.Fh5,
            FileExtensions.Fh7,
            FileExtensions.Jng,
            FileExtensions.Sid,
            FileExtensions.Pic,
            FileExtensions.Pct,
            FileExtensions.Pnm,
            FileExtensions.Pbm,
            FileExtensions.Pgm,
            FileExtensions.Ppm,
            FileExtensions.Rgb,
            FileExtensions.Tga,
            FileExtensions.Xbm,
            FileExtensions.Xpm,
            FileExtensions.Xwd,
            FileExtensions.Disposition_notification,
            FileExtensions.U8msg,
            FileExtensions.U8dsn,
            FileExtensions.U8mdn,
            FileExtensions.U8hdr,
            FileExtensions.Eml,
            FileExtensions.Mime,
            FileExtensions.Wsc,
            FileExtensions._3mf,
            FileExtensions.Gltf,
            FileExtensions.Glb,
            FileExtensions.Igs,
            FileExtensions.Iges,
            FileExtensions.Msh,
            FileExtensions.Mesh,
            FileExtensions.Silo,
            FileExtensions.Mtl,
            FileExtensions.Stpx,
            FileExtensions.Stpz,
            FileExtensions.Stpxz,
            FileExtensions.Dae,
            FileExtensions.Dwf,
            FileExtensions.Gdl,
            FileExtensions.Gtw,
            FileExtensions.Mts,
            FileExtensions.Ogex,
            FileExtensions.X_b,
            FileExtensions.X_t,
            FileExtensions.Vds,
            FileExtensions.Usdz,
            FileExtensions.Bsp,
            FileExtensions.Vtu,
            FileExtensions.Wrl,
            FileExtensions.Vrml,
            FileExtensions.X3db,
            FileExtensions.X3dbz,
            FileExtensions.X3dv,
            FileExtensions.X3dvz,
            FileExtensions.X3d,
            FileExtensions.X3dz,
            FileExtensions.Appcache,
            FileExtensions.Manifest,
            FileExtensions.Ics,
            FileExtensions.Ifb,
            FileExtensions.Coffee,
            FileExtensions.Litcoffee,
            FileExtensions.Css,
            FileExtensions.Csv,
            FileExtensions.Html,
            FileExtensions.Htm,
            FileExtensions.Shtml,
            FileExtensions.Jade,
            FileExtensions.Jsx,
            FileExtensions.Less,
            FileExtensions.Markdown,
            FileExtensions.Md,
            FileExtensions.Mml,
            FileExtensions.Mdx,
            FileExtensions.N3,
            FileExtensions.Txt,
            FileExtensions.Text,
            FileExtensions.Conf,
            FileExtensions.Def,
            FileExtensions.List,
            FileExtensions.Log,
            FileExtensions.In,
            FileExtensions.Ini,
            FileExtensions.Dsc,
            FileExtensions.Rtx,
            FileExtensions.Sgml,
            FileExtensions.Sgm,
            FileExtensions.Shex,
            FileExtensions.Slim,
            FileExtensions.Slm,
            FileExtensions.Spdx,
            FileExtensions.Stylus,
            FileExtensions.Styl,
            FileExtensions.Tsv,
            FileExtensions.T,
            FileExtensions.Tr,
            FileExtensions.Roff,
            FileExtensions.Man,
            FileExtensions.Me,
            FileExtensions.Ms,
            FileExtensions.Ttl,
            FileExtensions.Uri,
            FileExtensions.Uris,
            FileExtensions.Urls,
            FileExtensions.Vcard,
            FileExtensions.Curl,
            FileExtensions.Dcurl,
            FileExtensions.Mcurl,
            FileExtensions.Scurl,
            FileExtensions.Ged,
            FileExtensions.Fly,
            FileExtensions.Flx,
            FileExtensions.Gv,
            FileExtensions._3dml,
            FileExtensions.Spot,
            FileExtensions.Jad,
            FileExtensions.Wml,
            FileExtensions.Wmls,
            FileExtensions.Vtt,
            FileExtensions.S,
            FileExtensions.Asm,
            FileExtensions.C,
            FileExtensions.Cc,
            FileExtensions.Cxx,
            FileExtensions.Cpp,
            FileExtensions.H,
            FileExtensions.Hh,
            FileExtensions.Dic,
            FileExtensions.Htc,
            FileExtensions.F,
            FileExtensions.For,
            FileExtensions.F77,
            FileExtensions.F90,
            FileExtensions.Hbs,
            FileExtensions.Java,
            FileExtensions.Lua,
            FileExtensions.Mkd,
            FileExtensions.Nfo,
            FileExtensions.Opml,
            FileExtensions.P,
            FileExtensions.Pas,
            FileExtensions.Pde,
            FileExtensions.Sass,
            FileExtensions.Scss,
            FileExtensions.Etx,
            FileExtensions.Sfv,
            FileExtensions.Ymp,
            FileExtensions.Uu,
            FileExtensions.Vcs,
            FileExtensions.Vcf,
            FileExtensions.Yaml,
            FileExtensions.Yml,
            FileExtensions._3gp,
            FileExtensions._3g2,
            FileExtensions.H261,
            FileExtensions.H263,
            FileExtensions.H264,
            FileExtensions.M4s,
            FileExtensions.Jpgv,
            FileExtensions.Jpgm,
            FileExtensions.Mj2,
            FileExtensions.Mjp2,
            FileExtensions.Ts,
            FileExtensions.Mp4,
            FileExtensions.Mp4v,
            FileExtensions.Mpg4,
            FileExtensions.Mpeg,
            FileExtensions.Mpg,
            FileExtensions.Mpe,
            FileExtensions.M1v,
            FileExtensions.M2v,
            FileExtensions.Ogv,
            FileExtensions.Qt,
            FileExtensions.Mov,
            FileExtensions.Uvh,
            FileExtensions.Uvvh,
            FileExtensions.Uvm,
            FileExtensions.Uvvm,
            FileExtensions.Uvp,
            FileExtensions.Uvvp,
            FileExtensions.Uvs,
            FileExtensions.Uvvs,
            FileExtensions.Uvv,
            FileExtensions.Uvvv,
            FileExtensions.Dvb,
            FileExtensions.Fvt,
            FileExtensions.Mxu,
            FileExtensions.M4u,
            FileExtensions.Pyv,
            FileExtensions.Uvu,
            FileExtensions.Uvvu,
            FileExtensions.Viv,
            FileExtensions.Webm,
            FileExtensions.F4v,
            FileExtensions.Fli,
            FileExtensions.Flv,
            FileExtensions.M4v,
            FileExtensions.Mkv,
            FileExtensions.Mk3d,
            FileExtensions.Mks,
            FileExtensions.Mng,
            FileExtensions.Asf,
            FileExtensions.Asx,
            FileExtensions.Vob,
            FileExtensions.Wm,
            FileExtensions.Wmv,
            FileExtensions.Wmx,
            FileExtensions.Wvx,
            FileExtensions.Avi,
            FileExtensions.Movie,
            FileExtensions.Smv,
            FileExtensions.Ice,
        });


        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        internal static string? LookupType(string type)
        {
            switch (type)
            {
                case FileExtensions.Ez:
                    return Ez;

                case FileExtensions.Aw:
                    return Aw;

                case FileExtensions.Atom:
                    return Atom;

                case FileExtensions.Atomcat:
                    return Atomcat;

                case FileExtensions.Atomdeleted:
                    return Atomdeleted;

                case FileExtensions.Atomsvc:
                    return Atomsvc;

                case FileExtensions.Dwd:
                    return Dwd;

                case FileExtensions.Held:
                    return Held;

                case FileExtensions.Rsat:
                    return Rsat;

                case FileExtensions.Bdoc:
                    return Bdoc;

                case FileExtensions.Xcs:
                    return Xcs;

                case FileExtensions.Ccxml:
                    return Ccxml;

                case FileExtensions.Cdfx:
                    return Cdfx;

                case FileExtensions.Cdmia:
                    return Cdmia;

                case FileExtensions.Cdmic:
                    return Cdmic;

                case FileExtensions.Cdmid:
                    return Cdmid;

                case FileExtensions.Cdmio:
                    return Cdmio;

                case FileExtensions.Cdmiq:
                    return Cdmiq;

                case FileExtensions.Cpl:
                    return Cpl;

                case FileExtensions.Cu:
                    return Cu;

                case FileExtensions.Mpd:
                    return Mpd;

                case FileExtensions.Mpp:
                    return Mpp;

                case FileExtensions.Davmount:
                    return Davmount;

                case FileExtensions.Dbk:
                    return Dbk;

                case FileExtensions.Dssc:
                    return Dssc;

                case FileExtensions.Xdssc:
                    return Xdssc;

                case FileExtensions.Es:
                case FileExtensions.Ecma:
                    return Es;

                case FileExtensions.Emma:
                    return Emma;

                case FileExtensions.Emotionml:
                    return Emotionml;

                case FileExtensions.Epub:
                    return Epub;

                case FileExtensions.Exi:
                    return Exi;

                case FileExtensions.Exp:
                    return Exp;

                case FileExtensions.Fdt:
                    return Fdt;

                case FileExtensions.Pfr:
                    return Pfr;

                case FileExtensions.Geojson:
                    return Geojson;

                case FileExtensions.Gml:
                    return Gml;

                case FileExtensions.Gpx:
                    return Gpx;

                case FileExtensions.Gxf:
                    return Gxf;

                case FileExtensions.Gz:
                    return Gz;

                case FileExtensions.Hjson:
                    return Hjson;

                case FileExtensions.Stk:
                    return Stk;

                case FileExtensions.Ink:
                case FileExtensions.Inkml:
                    return Ink;

                case FileExtensions.Ipfix:
                    return Ipfix;

                case FileExtensions.Its:
                    return Its;

                case FileExtensions.Jar:
                case FileExtensions.War:
                case FileExtensions.Ear:
                    return Jar;

                case FileExtensions.Ser:
                    return Ser;

                case FileExtensions.Class:
                    return Class;

                case FileExtensions.Js:
                case FileExtensions.Mjs:
                    return Js;

                case FileExtensions.Json:
                case FileExtensions.Map:
                    return Json;

                case FileExtensions.Json5:
                    return Json5;

                case FileExtensions.Jsonml:
                    return Jsonml;

                case FileExtensions.Jsonld:
                    return Jsonld;

                case FileExtensions.Lgr:
                    return Lgr;

                case FileExtensions.Lostxml:
                    return Lostxml;

                case FileExtensions.Hqx:
                    return Hqx;

                case FileExtensions.Cpt:
                    return Cpt;

                case FileExtensions.Mads:
                    return Mads;

                case FileExtensions.Webmanifest:
                    return Webmanifest;

                case FileExtensions.Mrc:
                    return Mrc;

                case FileExtensions.Mrcx:
                    return Mrcx;

                case FileExtensions.Ma:
                case FileExtensions.Nb:
                case FileExtensions.Mb:
                    return Ma;

                case FileExtensions.Mathml:
                    return Mathml;

                case FileExtensions.Mbox:
                    return Mbox;

                case FileExtensions.Mpf:
                    return Mpf;

                case FileExtensions.Mscml:
                    return Mscml;

                case FileExtensions.Metalink:
                    return Metalink;

                case FileExtensions.Meta4:
                    return Meta4;

                case FileExtensions.Mets:
                    return Mets;

                case FileExtensions.Maei:
                    return Maei;

                case FileExtensions.Musd:
                    return Musd;

                case FileExtensions.Mods:
                    return Mods;

                case FileExtensions.M21:
                case FileExtensions.Mp21:
                    return M21;

                case FileExtensions.Mp4s:
                case FileExtensions.M4p:
                    return Mp4s;

                case FileExtensions.Doc:
                case FileExtensions.Dot:
                    return Doc;

                case FileExtensions.Mxf:
                    return Mxf;

                case FileExtensions.Nq:
                    return Nq;

                case FileExtensions.Nt:
                    return Nt;

                case FileExtensions.Cjs:
                    return Cjs;

                case FileExtensions.Bin:
                case FileExtensions.Dms:
                case FileExtensions.Lrf:
                case FileExtensions.Mar:
                case FileExtensions.So:
                case FileExtensions.Dist:
                case FileExtensions.Distz:
                case FileExtensions.Pkg:
                case FileExtensions.Bpk:
                case FileExtensions.Dump:
                case FileExtensions.Elc:
                case FileExtensions.Deploy:
                case FileExtensions.Exe:
                case FileExtensions.Dll:
                case FileExtensions.Deb:
                case FileExtensions.Dmg:
                case FileExtensions.Iso:
                case FileExtensions.Img:
                case FileExtensions.Msi:
                case FileExtensions.Msp:
                case FileExtensions.Msm:
                case FileExtensions.Buffer:
                    return Bin;

                case FileExtensions.Oda:
                    return Oda;

                case FileExtensions.Opf:
                    return Opf;

                case FileExtensions.Ogx:
                    return Ogx;

                case FileExtensions.Omdoc:
                    return Omdoc;

                case FileExtensions.Onetoc:
                case FileExtensions.Onetoc2:
                case FileExtensions.Onetmp:
                case FileExtensions.Onepkg:
                    return Onetoc;

                case FileExtensions.Oxps:
                    return Oxps;

                case FileExtensions.Relo:
                    return Relo;

                case FileExtensions.Xer:
                    return Xer;

                case FileExtensions.Pdf:
                    return Pdf;

                case FileExtensions.Pgp:
                    return Pgp;

                case FileExtensions.Asc:
                    return Asc;

                case FileExtensions.Sig:
                    return Sig;

                case FileExtensions.Prf:
                    return Prf;

                case FileExtensions.P10:
                    return P10;

                case FileExtensions.P7m:
                case FileExtensions.P7c:
                    return P7m;

                case FileExtensions.P7s:
                    return P7s;

                case FileExtensions.P8:
                    return P8;

                case FileExtensions.Ac:
                    return Ac;

                case FileExtensions.Cer:
                    return Cer;

                case FileExtensions.Crl:
                    return Crl;

                case FileExtensions.Pkipath:
                    return Pkipath;

                case FileExtensions.Pki:
                    return Pki;

                case FileExtensions.Pls:
                    return Pls;

                case FileExtensions.Ai:
                case FileExtensions.Eps:
                case FileExtensions.Ps:
                    return Ai;

                case FileExtensions.Provx:
                    return Provx;

                case FileExtensions.Cww:
                    return Cww;

                case FileExtensions.Pskcxml:
                    return Pskcxml;

                case FileExtensions.Raml:
                    return Raml;

                case FileExtensions.Rdf:
                case FileExtensions.Owl:
                    return Rdf;

                case FileExtensions.Rif:
                    return Rif;

                case FileExtensions.Rnc:
                    return Rnc;

                case FileExtensions.Rl:
                    return Rl;

                case FileExtensions.Rld:
                    return Rld;

                case FileExtensions.Rs:
                    return Rs;

                case FileExtensions.Rapd:
                    return Rapd;

                case FileExtensions.Sls:
                    return Sls;

                case FileExtensions.Rusd:
                    return Rusd;

                case FileExtensions.Gbr:
                    return Gbr;

                case FileExtensions.Mft:
                    return Mft;

                case FileExtensions.Roa:
                    return Roa;

                case FileExtensions.Rsd:
                    return Rsd;

                case FileExtensions.Rss:
                    return Rss;

                case FileExtensions.Rtf:
                    return Rtf;

                case FileExtensions.Sbml:
                    return Sbml;

                case FileExtensions.Scq:
                    return Scq;

                case FileExtensions.Scs:
                    return Scs;

                case FileExtensions.Spq:
                    return Spq;

                case FileExtensions.Spp:
                    return Spp;

                case FileExtensions.Sdp:
                    return Sdp;

                case FileExtensions.Senmlx:
                    return Senmlx;

                case FileExtensions.Sensmlx:
                    return Sensmlx;

                case FileExtensions.Setpay:
                    return Setpay;

                case FileExtensions.Setreg:
                    return Setreg;

                case FileExtensions.Shf:
                    return Shf;

                case FileExtensions.Siv:
                case FileExtensions.Sieve:
                    return Siv;

                case FileExtensions.Smi:
                case FileExtensions.Smil:
                    return Smi;

                case FileExtensions.Rq:
                    return Rq;

                case FileExtensions.Srx:
                    return Srx;

                case FileExtensions.Gram:
                    return Gram;

                case FileExtensions.Grxml:
                    return Grxml;

                case FileExtensions.Sru:
                    return Sru;

                case FileExtensions.Ssdl:
                    return Ssdl;

                case FileExtensions.Ssml:
                    return Ssml;

                case FileExtensions.Swidtag:
                    return Swidtag;

                case FileExtensions.Tei:
                case FileExtensions.Teicorpus:
                    return Tei;

                case FileExtensions.Tfi:
                    return Tfi;

                case FileExtensions.Tsd:
                    return Tsd;

                case FileExtensions.Toml:
                    return Toml;

                case FileExtensions.Trig:
                    return Trig;

                case FileExtensions.Ttml:
                    return Ttml;

                case FileExtensions.Ubj:
                    return Ubj;

                case FileExtensions.Rsheet:
                    return Rsheet;

                case FileExtensions.Td:
                    return Td;

                case FileExtensions._1km:
                    return _1km;

                case FileExtensions.Plb:
                    return Plb;

                case FileExtensions.Psb:
                    return Psb;

                case FileExtensions.Pvb:
                    return Pvb;

                case FileExtensions.Tcap:
                    return Tcap;

                case FileExtensions.Pwn:
                    return Pwn;

                case FileExtensions.Aso:
                    return Aso;

                case FileExtensions.Imp:
                    return Imp;

                case FileExtensions.Acu:
                    return Acu;

                case FileExtensions.Atc:
                case FileExtensions.Acutc:
                    return Atc;

                case FileExtensions.Air:
                    return Air;

                case FileExtensions.Fcdt:
                    return Fcdt;

                case FileExtensions.Fxp:
                case FileExtensions.Fxpl:
                    return Fxp;

                case FileExtensions.Xdp:
                    return Xdp;

                case FileExtensions.Xfdf:
                    return Xfdf;

                case FileExtensions.Age:
                    return Age;

                case FileExtensions.Ahead:
                    return Ahead;

                case FileExtensions.Azf:
                    return Azf;

                case FileExtensions.Azs:
                    return Azs;

                case FileExtensions.Azw:
                    return Azw;

                case FileExtensions.Acc:
                    return Acc;

                case FileExtensions.Ami:
                    return Ami;

                case FileExtensions.Apk:
                    return Apk;

                case FileExtensions.Cii:
                    return Cii;

                case FileExtensions.Fti:
                    return Fti;

                case FileExtensions.Atx:
                    return Atx;

                case FileExtensions.Mpkg:
                    return Mpkg;

                case FileExtensions.Key:
                    return Key;

                case FileExtensions.M3u8:
                    return M3u8;

                case FileExtensions.Numbers:
                    return Numbers;

                case FileExtensions.Pages:
                    return Pages;

                case FileExtensions.Pkpass:
                    return Pkpass;

                case FileExtensions.Swi:
                    return Swi;

                case FileExtensions.Iota:
                    return Iota;

                case FileExtensions.Aep:
                    return Aep;

                case FileExtensions.Bmml:
                    return Bmml;

                case FileExtensions.Mpm:
                    return Mpm;

                case FileExtensions.Bmi:
                    return Bmi;

                case FileExtensions.Rep:
                    return Rep;

                case FileExtensions.Cdxml:
                    return Cdxml;

                case FileExtensions.Mmd:
                    return Mmd;

                case FileExtensions.Cdy:
                    return Cdy;

                case FileExtensions.Csl:
                    return Csl;

                case FileExtensions.Cla:
                    return Cla;

                case FileExtensions.Rp9:
                    return Rp9;

                case FileExtensions.C4g:
                case FileExtensions.C4d:
                case FileExtensions.C4f:
                case FileExtensions.C4p:
                case FileExtensions.C4u:
                    return C4g;

                case FileExtensions.C11amc:
                    return C11amc;

                case FileExtensions.C11amz:
                    return C11amz;

                case FileExtensions.Csp:
                    return Csp;

                case FileExtensions.Cdbcmsg:
                    return Cdbcmsg;

                case FileExtensions.Cmc:
                    return Cmc;

                case FileExtensions.Clkx:
                    return Clkx;

                case FileExtensions.Clkk:
                    return Clkk;

                case FileExtensions.Clkp:
                    return Clkp;

                case FileExtensions.Clkt:
                    return Clkt;

                case FileExtensions.Clkw:
                    return Clkw;

                case FileExtensions.Wbs:
                    return Wbs;

                case FileExtensions.Pml:
                    return Pml;

                case FileExtensions.Ppd:
                    return Ppd;

                case FileExtensions.Car:
                    return Car;

                case FileExtensions.Pcurl:
                    return Pcurl;

                case FileExtensions.Dart:
                    return Dart;

                case FileExtensions.Rdz:
                    return Rdz;

                case FileExtensions.Dbf:
                    return Dbf;

                case FileExtensions.Uvf:
                case FileExtensions.Uvvf:
                case FileExtensions.Uvd:
                case FileExtensions.Uvvd:
                    return Uvf;

                case FileExtensions.Uvt:
                case FileExtensions.Uvvt:
                    return Uvt;

                case FileExtensions.Uvx:
                case FileExtensions.Uvvx:
                    return Uvx;

                case FileExtensions.Uvz:
                case FileExtensions.Uvvz:
                    return Uvz;

                case FileExtensions.Fe_launch:
                    return Felaunch;

                case FileExtensions.Dna:
                    return Dna;

                case FileExtensions.Mlp:
                    return Mlp;

                case FileExtensions.Dpg:
                    return Dpg;

                case FileExtensions.Dfac:
                    return Dfac;

                case FileExtensions.Kpxx:
                    return Kpxx;

                case FileExtensions.Ait:
                    return Ait;

                case FileExtensions.Svc:
                    return Svc;

                case FileExtensions.Geo:
                    return Geo;

                case FileExtensions.Mag:
                    return Mag;

                case FileExtensions.Nml:
                    return Nml;

                case FileExtensions.Esf:
                    return Esf;

                case FileExtensions.Msf:
                    return Msf;

                case FileExtensions.Qam:
                    return Qam;

                case FileExtensions.Slt:
                    return Slt;

                case FileExtensions.Ssf:
                    return Ssf;

                case FileExtensions.Es3:
                case FileExtensions.Et3:
                    return Es3;

                case FileExtensions.Ez2:
                    return Ez2;

                case FileExtensions.Ez3:
                    return Ez3;

                case FileExtensions.Fdf:
                    return Fdf;

                case FileExtensions.Mseed:
                    return Mseed;

                case FileExtensions.Seed:
                case FileExtensions.Dataless:
                    return Seed;

                case FileExtensions.Gph:
                    return Gph;

                case FileExtensions.Ftc:
                    return Ftc;

                case FileExtensions.Fm:
                case FileExtensions.Frame:
                case FileExtensions.Maker:
                case FileExtensions.Book:
                    return Fm;

                case FileExtensions.Fnc:
                    return Fnc;

                case FileExtensions.Ltf:
                    return Ltf;

                case FileExtensions.Fsc:
                    return Fsc;

                case FileExtensions.Oas:
                    return Oas;

                case FileExtensions.Oa2:
                    return Oa2;

                case FileExtensions.Oa3:
                    return Oa3;

                case FileExtensions.Fg5:
                    return Fg5;

                case FileExtensions.Bh2:
                    return Bh2;

                case FileExtensions.Ddd:
                    return Ddd;

                case FileExtensions.Xdw:
                    return Xdw;

                case FileExtensions.Xbd:
                    return Xbd;

                case FileExtensions.Fzs:
                    return Fzs;

                case FileExtensions.Txd:
                    return Txd;

                case FileExtensions.Ggb:
                    return Ggb;

                case FileExtensions.Ggt:
                    return Ggt;

                case FileExtensions.Gex:
                case FileExtensions.Gre:
                    return Gex;

                case FileExtensions.Gxt:
                    return Gxt;

                case FileExtensions.G2w:
                    return G2w;

                case FileExtensions.G3w:
                    return G3w;

                case FileExtensions.Gmx:
                    return Gmx;

                case FileExtensions.Gdoc:
                    return Gdoc;

                case FileExtensions.Gslides:
                    return Gslides;

                case FileExtensions.Gsheet:
                    return Gsheet;

                case FileExtensions.Kml:
                    return Kml;

                case FileExtensions.Kmz:
                    return Kmz;

                case FileExtensions.Gqf:
                case FileExtensions.Gqs:
                    return Gqf;

                case FileExtensions.Gac:
                    return Gac;

                case FileExtensions.Ghf:
                    return Ghf;

                case FileExtensions.Gim:
                    return Gim;

                case FileExtensions.Grv:
                    return Grv;

                case FileExtensions.Gtm:
                    return Gtm;

                case FileExtensions.Tpl:
                    return Tpl;

                case FileExtensions.Vcg:
                    return Vcg;

                case FileExtensions.Hal:
                    return Hal;

                case FileExtensions.Zmm:
                    return Zmm;

                case FileExtensions.Hbci:
                    return Hbci;

                case FileExtensions.Les:
                    return Les;

                case FileExtensions.Hpgl:
                    return Hpgl;

                case FileExtensions.Hpid:
                    return Hpid;

                case FileExtensions.Hps:
                    return Hps;

                case FileExtensions.Jlt:
                    return Jlt;

                case FileExtensions.Pcl:
                    return Pcl;

                case FileExtensions.Pclxl:
                    return Pclxl;

                case FileExtensions.Sfd_hdstx:
                    return Sfdhdstx;

                case FileExtensions.Mpy:
                    return Mpy;

                case FileExtensions.Afp:
                case FileExtensions.Listafp:
                case FileExtensions.List3820:
                    return Afp;

                case FileExtensions.Irm:
                    return Irm;

                case FileExtensions.Sc:
                    return Sc;

                case FileExtensions.Icc:
                case FileExtensions.Icm:
                    return Icc;

                case FileExtensions.Igl:
                    return Igl;

                case FileExtensions.Ivp:
                    return Ivp;

                case FileExtensions.Ivu:
                    return Ivu;

                case FileExtensions.Igm:
                    return Igm;

                case FileExtensions.Xpw:
                case FileExtensions.Xpx:
                    return Xpw;

                case FileExtensions.I2g:
                    return I2g;

                case FileExtensions.Qbo:
                    return Qbo;

                case FileExtensions.Qfx:
                    return Qfx;

                case FileExtensions.Rcprofile:
                    return Rcprofile;

                case FileExtensions.Irp:
                    return Irp;

                case FileExtensions.Xpr:
                    return Xpr;

                case FileExtensions.Fcs:
                    return Fcs;

                case FileExtensions.Jam:
                    return Jam;

                case FileExtensions.Rms:
                    return Rms;

                case FileExtensions.Jisp:
                    return Jisp;

                case FileExtensions.Joda:
                    return Joda;

                case FileExtensions.Ktz:
                case FileExtensions.Ktr:
                    return Ktz;

                case FileExtensions.Karbon:
                    return Karbon;

                case FileExtensions.Chrt:
                    return Chrt;

                case FileExtensions.Kfo:
                    return Kfo;

                case FileExtensions.Flw:
                    return Flw;

                case FileExtensions.Kon:
                    return Kon;

                case FileExtensions.Kpr:
                case FileExtensions.Kpt:
                    return Kpr;

                case FileExtensions.Ksp:
                    return Ksp;

                case FileExtensions.Kwd:
                case FileExtensions.Kwt:
                    return Kwd;

                case FileExtensions.Htke:
                    return Htke;

                case FileExtensions.Kia:
                    return Kia;

                case FileExtensions.Kne:
                case FileExtensions.Knp:
                    return Kne;

                case FileExtensions.Skp:
                case FileExtensions.Skd:
                case FileExtensions.Skt:
                case FileExtensions.Skm:
                    return Skp;

                case FileExtensions.Sse:
                    return Sse;

                case FileExtensions.Lasxml:
                    return Lasxml;

                case FileExtensions.Lbd:
                    return Lbd;

                case FileExtensions.Lbe:
                    return Lbe;

                case FileExtensions._123:
                    return _123;

                case FileExtensions.Apr:
                    return Apr;

                case FileExtensions.Pre:
                    return Pre;

                case FileExtensions.Nsf:
                    return Nsf;

                case FileExtensions.Org:
                    return Org;

                case FileExtensions.Scm:
                    return Scm;

                case FileExtensions.Lwp:
                    return Lwp;

                case FileExtensions.Portpkg:
                    return Portpkg;

                case FileExtensions.Mvt:
                    return Mvt;

                case FileExtensions.Mcd:
                    return Mcd;

                case FileExtensions.Mc1:
                    return Mc1;

                case FileExtensions.Cdkey:
                    return Cdkey;

                case FileExtensions.Mwf:
                    return Mwf;

                case FileExtensions.Mfm:
                    return Mfm;

                case FileExtensions.Flo:
                    return Flo;

                case FileExtensions.Igx:
                    return Igx;

                case FileExtensions.Mif:
                    return Mif;

                case FileExtensions.Daf:
                    return Daf;

                case FileExtensions.Dis:
                    return Dis;

                case FileExtensions.Mbk:
                    return Mbk;

                case FileExtensions.Mqy:
                    return Mqy;

                case FileExtensions.Msl:
                    return Msl;

                case FileExtensions.Plc:
                    return Plc;

                case FileExtensions.Txf:
                    return Txf;

                case FileExtensions.Mpn:
                    return Mpn;

                case FileExtensions.Mpc:
                    return Mpc;

                case FileExtensions.Xul:
                    return Xul;

                case FileExtensions.Cil:
                    return Cil;

                case FileExtensions.Cab:
                    return Cab;

                case FileExtensions.Xls:
                case FileExtensions.Xlm:
                case FileExtensions.Xla:
                case FileExtensions.Xlc:
                case FileExtensions.Xlt:
                case FileExtensions.Xlw:
                    return Xls;

                case FileExtensions.Xlam:
                    return Xlam;

                case FileExtensions.Xlsb:
                    return Xlsb;

                case FileExtensions.Xlsm:
                    return Xlsm;

                case FileExtensions.Xltm:
                    return Xltm;

                case FileExtensions.Eot:
                    return Eot;

                case FileExtensions.Chm:
                    return Chm;

                case FileExtensions.Ims:
                    return Ims;

                case FileExtensions.Lrm:
                    return Lrm;

                case FileExtensions.Thmx:
                    return Thmx;

                case FileExtensions.Msg:
                    return Msg;

                case FileExtensions.Cat:
                    return Cat;

                case FileExtensions.Stl:
                    return Stl;

                case FileExtensions.Ppt:
                case FileExtensions.Pps:
                case FileExtensions.Pot:
                    return Ppt;

                case FileExtensions.Ppam:
                    return Ppam;

                case FileExtensions.Pptm:
                    return Pptm;

                case FileExtensions.Sldm:
                    return Sldm;

                case FileExtensions.Ppsm:
                    return Ppsm;

                case FileExtensions.Potm:
                    return Potm;

                case FileExtensions.Mpt:
                    return Mpt;

                case FileExtensions.Docm:
                    return Docm;

                case FileExtensions.Dotm:
                    return Dotm;

                case FileExtensions.Wps:
                case FileExtensions.Wks:
                case FileExtensions.Wcm:
                case FileExtensions.Wdb:
                    return Wps;

                case FileExtensions.Wpl:
                    return Wpl;

                case FileExtensions.Xps:
                    return Xps;

                case FileExtensions.Mseq:
                    return Mseq;

                case FileExtensions.Mus:
                    return Mus;

                case FileExtensions.Msty:
                    return Msty;

                case FileExtensions.Taglet:
                    return Taglet;

                case FileExtensions.Nlu:
                    return Nlu;

                case FileExtensions.Ntf:
                case FileExtensions.Nitf:
                    return Ntf;

                case FileExtensions.Nnd:
                    return Nnd;

                case FileExtensions.Nns:
                    return Nns;

                case FileExtensions.Nnw:
                    return Nnw;

                case FileExtensions.Ngdat:
                    return Ngdat;

                case FileExtensions.N_gage:
                    return Ngage;

                case FileExtensions.Rpst:
                    return Rpst;

                case FileExtensions.Rpss:
                    return Rpss;

                case FileExtensions.Edm:
                    return Edm;

                case FileExtensions.Edx:
                    return Edx;

                case FileExtensions.Ext:
                    return Ext;

                case FileExtensions.Odc:
                    return Odc;

                case FileExtensions.Otc:
                    return Otc;

                case FileExtensions.Odb:
                    return Odb;

                case FileExtensions.Odf:
                    return Odf;

                case FileExtensions.Odft:
                    return Odft;

                case FileExtensions.Odg:
                    return Odg;

                case FileExtensions.Otg:
                    return Otg;

                case FileExtensions.Odi:
                    return Odi;

                case FileExtensions.Oti:
                    return Oti;

                case FileExtensions.Odp:
                    return Odp;

                case FileExtensions.Otp:
                    return Otp;

                case FileExtensions.Ods:
                    return Ods;

                case FileExtensions.Ots:
                    return Ots;

                case FileExtensions.Odt:
                    return Odt;

                case FileExtensions.Odm:
                    return Odm;

                case FileExtensions.Ott:
                    return Ott;

                case FileExtensions.Oth:
                    return Oth;

                case FileExtensions.Xo:
                    return Xo;

                case FileExtensions.Dd2:
                    return Dd2;

                case FileExtensions.Obgx:
                    return Obgx;

                case FileExtensions.Oxt:
                    return Oxt;

                case FileExtensions.Osm:
                    return Osm;

                case FileExtensions.Pptx:
                    return Pptx;

                case FileExtensions.Sldx:
                    return Sldx;

                case FileExtensions.Ppsx:
                    return Ppsx;

                case FileExtensions.Potx:
                    return Potx;

                case FileExtensions.Xlsx:
                    return Xlsx;

                case FileExtensions.Xltx:
                    return Xltx;

                case FileExtensions.Docx:
                    return Docx;

                case FileExtensions.Dotx:
                    return Dotx;

                case FileExtensions.Mgp:
                    return Mgp;

                case FileExtensions.Dp:
                    return Dp;

                case FileExtensions.Esa:
                    return Esa;

                case FileExtensions.Pdb:
                case FileExtensions.Pqa:
                case FileExtensions.Oprc:
                    return Pdb;

                case FileExtensions.Paw:
                    return Paw;

                case FileExtensions.Str:
                    return Str;

                case FileExtensions.Ei6:
                    return Ei6;

                case FileExtensions.Efif:
                    return Efif;

                case FileExtensions.Wg:
                    return Wg;

                case FileExtensions.Plf:
                    return Plf;

                case FileExtensions.Pbd:
                    return Pbd;

                case FileExtensions.Box:
                    return Box;

                case FileExtensions.Mgz:
                    return Mgz;

                case FileExtensions.Qps:
                    return Qps;

                case FileExtensions.Ptid:
                    return Ptid;

                case FileExtensions.Qxd:
                case FileExtensions.Qxt:
                case FileExtensions.Qwd:
                case FileExtensions.Qwt:
                case FileExtensions.Qxl:
                case FileExtensions.Qxb:
                    return Qxd;

                case FileExtensions.Rar:
                    return Rar;

                case FileExtensions.Bed:
                    return Bed;

                case FileExtensions.Mxl:
                    return Mxl;

                case FileExtensions.Musicxml:
                    return Musicxml;

                case FileExtensions.Cryptonote:
                    return Cryptonote;

                case FileExtensions.Cod:
                    return Cod;

                case FileExtensions.Rm:
                    return Rm;

                case FileExtensions.Rmvb:
                    return Rmvb;

                case FileExtensions.Link66:
                    return Link66;

                case FileExtensions.St:
                    return St;

                case FileExtensions.See:
                    return See;

                case FileExtensions.Sema:
                    return Sema;

                case FileExtensions.Semd:
                    return Semd;

                case FileExtensions.Semf:
                    return Semf;

                case FileExtensions.Ifm:
                    return Ifm;

                case FileExtensions.Itp:
                    return Itp;

                case FileExtensions.Iif:
                    return Iif;

                case FileExtensions.Ipk:
                    return Ipk;

                case FileExtensions.Twd:
                case FileExtensions.Twds:
                    return Twd;

                case FileExtensions.Mmf:
                    return Mmf;

                case FileExtensions.Teacher:
                    return Teacher;

                case FileExtensions.Fo:
                    return Fo;

                case FileExtensions.Sdkm:
                case FileExtensions.Sdkd:
                    return Sdkm;

                case FileExtensions.Dxp:
                    return Dxp;

                case FileExtensions.Sfs:
                    return Sfs;

                case FileExtensions.Sdc:
                    return Sdc;

                case FileExtensions.Sda:
                    return Sda;

                case FileExtensions.Sdd:
                    return Sdd;

                case FileExtensions.Smf:
                    return Smf;

                case FileExtensions.Sdw:
                case FileExtensions.Vor:
                    return Sdw;

                case FileExtensions.Sgl:
                    return Sgl;

                case FileExtensions.Smzip:
                    return Smzip;

                case FileExtensions.Sm:
                    return Sm;

                case FileExtensions.Wadl:
                    return Wadl;

                case FileExtensions.Sxc:
                    return Sxc;

                case FileExtensions.Stc:
                    return Stc;

                case FileExtensions.Sxd:
                    return Sxd;

                case FileExtensions.Std:
                    return Std;

                case FileExtensions.Sxi:
                    return Sxi;

                case FileExtensions.Sti:
                    return Sti;

                case FileExtensions.Sxm:
                    return Sxm;

                case FileExtensions.Sxw:
                    return Sxw;

                case FileExtensions.Sxg:
                    return Sxg;

                case FileExtensions.Stw:
                    return Stw;

                case FileExtensions.Sus:
                case FileExtensions.Susp:
                    return Sus;

                case FileExtensions.Svd:
                    return Svd;

                case FileExtensions.Sis:
                case FileExtensions.Sisx:
                    return Sis;

                case FileExtensions.Xsm:
                    return Xsm;

                case FileExtensions.Bdm:
                    return Bdm;

                case FileExtensions.Xdm:
                    return Xdm;

                case FileExtensions.Ddf:
                    return Ddf;

                case FileExtensions.Tao:
                    return Tao;

                case FileExtensions.Pcap:
                case FileExtensions.Cap:
                case FileExtensions.Dmp:
                    return Pcap;

                case FileExtensions.Tmo:
                    return Tmo;

                case FileExtensions.Tpt:
                    return Tpt;

                case FileExtensions.Mxs:
                    return Mxs;

                case FileExtensions.Tra:
                    return Tra;

                case FileExtensions.Ufd:
                case FileExtensions.Ufdl:
                    return Ufd;

                case FileExtensions.Utz:
                    return Utz;

                case FileExtensions.Umj:
                    return Umj;

                case FileExtensions.Unityweb:
                    return Unityweb;

                case FileExtensions.Uoml:
                    return Uoml;

                case FileExtensions.Vcx:
                    return Vcx;

                case FileExtensions.Vsd:
                case FileExtensions.Vst:
                case FileExtensions.Vss:
                case FileExtensions.Vsw:
                    return Vsd;

                case FileExtensions.Vis:
                    return Vis;

                case FileExtensions.Vsf:
                    return Vsf;

                case FileExtensions.Wbxml:
                    return Wbxml;

                case FileExtensions.Wmlc:
                    return Wmlc;

                case FileExtensions.Wmlsc:
                    return Wmlsc;

                case FileExtensions.Wtb:
                    return Wtb;

                case FileExtensions.Nbp:
                    return Nbp;

                case FileExtensions.Wpd:
                    return Wpd;

                case FileExtensions.Wqd:
                    return Wqd;

                case FileExtensions.Stf:
                    return Stf;

                case FileExtensions.Xar:
                    return Xar;

                case FileExtensions.Xfdl:
                    return Xfdl;

                case FileExtensions.Hvd:
                    return Hvd;

                case FileExtensions.Hvs:
                    return Hvs;

                case FileExtensions.Hvp:
                    return Hvp;

                case FileExtensions.Osf:
                    return Osf;

                case FileExtensions.Osfpvg:
                    return Osfpvg;

                case FileExtensions.Saf:
                    return Saf;

                case FileExtensions.Spf:
                    return Spf;

                case FileExtensions.Cmp:
                    return Cmp;

                case FileExtensions.Zir:
                case FileExtensions.Zirz:
                    return Zir;

                case FileExtensions.Zaz:
                    return Zaz;

                case FileExtensions.Vxml:
                    return Vxml;

                case FileExtensions.Wasm:
                    return Wasm;

                case FileExtensions.Wif:
                    return Wif;

                case FileExtensions.Wgt:
                    return Wgt;

                case FileExtensions.Hlp:
                    return Hlp;

                case FileExtensions.Wsdl:
                    return Wsdl;

                case FileExtensions.Wspolicy:
                    return Wspolicy;

                case FileExtensions._7z:
                    return _7z;

                case FileExtensions.Abw:
                    return Abw;

                case FileExtensions.Ace:
                    return Ace;

                case FileExtensions.Arj:
                    return Arj;

                case FileExtensions.Aab:
                case FileExtensions.X32:
                case FileExtensions.U32:
                case FileExtensions.Vox:
                    return Aab;

                case FileExtensions.Aam:
                    return Aam;

                case FileExtensions.Aas:
                    return Aas;

                case FileExtensions.Bcpio:
                    return Bcpio;

                case FileExtensions.Torrent:
                    return Torrent;

                case FileExtensions.Blb:
                case FileExtensions.Blorb:
                    return Blb;

                case FileExtensions.Bz:
                    return Bz;

                case FileExtensions.Bz2:
                case FileExtensions.Boz:
                    return Bz2;

                case FileExtensions.Cbr:
                case FileExtensions.Cba:
                case FileExtensions.Cbt:
                case FileExtensions.Cbz:
                case FileExtensions.Cb7:
                    return Cbr;

                case FileExtensions.Vcd:
                    return Vcd;

                case FileExtensions.Cfs:
                    return Cfs;

                case FileExtensions.Chat:
                    return Chat;

                case FileExtensions.Pgn:
                    return Pgn;

                case FileExtensions.Crx:
                    return Crx;

                case FileExtensions.Cco:
                    return Cco;

                case FileExtensions.Nsc:
                    return Nsc;

                case FileExtensions.Cpio:
                    return Cpio;

                case FileExtensions.Csh:
                    return Csh;

                case FileExtensions.Udeb:
                    return Udeb;

                case FileExtensions.Dgc:
                    return Dgc;

                case FileExtensions.Dir:
                case FileExtensions.Dcr:
                case FileExtensions.Dxr:
                case FileExtensions.Cst:
                case FileExtensions.Cct:
                case FileExtensions.Cxt:
                case FileExtensions.W3d:
                case FileExtensions.Fgd:
                case FileExtensions.Swa:
                    return Dir;

                case FileExtensions.Wad:
                    return Wad;

                case FileExtensions.Ncx:
                    return Ncx;

                case FileExtensions.Dtb:
                    return Dtb;

                case FileExtensions.Res:
                    return Res;

                case FileExtensions.Dvi:
                    return Dvi;

                case FileExtensions.Evy:
                    return Evy;

                case FileExtensions.Eva:
                    return Eva;

                case FileExtensions.Bdf:
                    return Bdf;

                case FileExtensions.Gsf:
                    return Gsf;

                case FileExtensions.Psf:
                    return Psf;

                case FileExtensions.Pcf:
                    return Pcf;

                case FileExtensions.Snf:
                    return Snf;

                case FileExtensions.Pfa:
                case FileExtensions.Pfb:
                case FileExtensions.Pfm:
                case FileExtensions.Afm:
                    return Pfa;

                case FileExtensions.Arc:
                    return Arc;

                case FileExtensions.Spl:
                    return Spl;

                case FileExtensions.Gca:
                    return Gca;

                case FileExtensions.Ulx:
                    return Ulx;

                case FileExtensions.Gnumeric:
                    return Gnumeric;

                case FileExtensions.Gramps:
                    return Gramps;

                case FileExtensions.Gtar:
                    return Gtar;

                case FileExtensions.Hdf:
                    return Hdf;

                case FileExtensions.Php:
                    return Php;

                case FileExtensions.Install:
                    return Install;

                case FileExtensions.Jardiff:
                    return Jardiff;

                case FileExtensions.Jnlp:
                    return Jnlp;

                case FileExtensions.Kdbx:
                    return Kdbx;

                case FileExtensions.Latex:
                    return Latex;

                case FileExtensions.Luac:
                    return Luac;

                case FileExtensions.Lzh:
                case FileExtensions.Lha:
                    return Lzh;

                case FileExtensions.Run:
                    return Run;

                case FileExtensions.Mie:
                    return Mie;

                case FileExtensions.Prc:
                case FileExtensions.Mobi:
                    return Prc;

                case FileExtensions.Application:
                    return Application;

                case FileExtensions.Lnk:
                    return Lnk;

                case FileExtensions.Wmd:
                    return Wmd;

                case FileExtensions.Wmz:
                    return Wmz;

                case FileExtensions.Xbap:
                    return Xbap;

                case FileExtensions.Mdb:
                    return Mdb;

                case FileExtensions.Obd:
                    return Obd;

                case FileExtensions.Crd:
                    return Crd;

                case FileExtensions.Clp:
                    return Clp;

                case FileExtensions.Com:
                case FileExtensions.Bat:
                    return Com;

                case FileExtensions.Mvb:
                case FileExtensions.M13:
                case FileExtensions.M14:
                    return Mvb;

                case FileExtensions.Wmf:
                case FileExtensions.Emf:
                case FileExtensions.Emz:
                    return Wmf;

                case FileExtensions.Mny:
                    return Mny;

                case FileExtensions.Pub:
                    return Pub;

                case FileExtensions.Scd:
                    return Scd;

                case FileExtensions.Trm:
                    return Trm;

                case FileExtensions.Wri:
                    return Wri;

                case FileExtensions.Nc:
                case FileExtensions.Cdf:
                    return Nc;

                case FileExtensions.Pac:
                    return Pac;

                case FileExtensions.Nzb:
                    return Nzb;

                case FileExtensions.Pl:
                case FileExtensions.Pm:
                    return Pl;

                case FileExtensions.P12:
                case FileExtensions.Pfx:
                    return P12;

                case FileExtensions.P7b:
                case FileExtensions.Spc:
                    return P7b;

                case FileExtensions.P7r:
                    return P7r;

                case FileExtensions.Rpm:
                    return Rpm;

                case FileExtensions.Ris:
                    return Ris;

                case FileExtensions.Sea:
                    return Sea;

                case FileExtensions.Sh:
                    return Sh;

                case FileExtensions.Shar:
                    return Shar;

                case FileExtensions.Swf:
                    return Swf;

                case FileExtensions.Xap:
                    return Xap;

                case FileExtensions.Sql:
                    return Sql;

                case FileExtensions.Sit:
                    return Sit;

                case FileExtensions.Sitx:
                    return Sitx;

                case FileExtensions.Srt:
                    return Srt;

                case FileExtensions.Sv4cpio:
                    return Sv4cpio;

                case FileExtensions.Sv4crc:
                    return Sv4crc;

                case FileExtensions.T3:
                    return T3;

                case FileExtensions.Gam:
                    return Gam;

                case FileExtensions.Tar:
                    return Tar;

                case FileExtensions.Tcl:
                case FileExtensions.Tk:
                    return Tcl;

                case FileExtensions.Tex:
                    return Tex;

                case FileExtensions.Tfm:
                    return Tfm;

                case FileExtensions.Texinfo:
                case FileExtensions.Texi:
                    return Texinfo;

                case FileExtensions.Obj:
                    return Obj;

                case FileExtensions.Ustar:
                    return Ustar;

                case FileExtensions.Hdd:
                    return Hdd;

                case FileExtensions.Ova:
                    return Ova;

                case FileExtensions.Ovf:
                    return Ovf;

                case FileExtensions.Vbox:
                    return Vbox;

                case FileExtensions.Vbox_extpack:
                    return Vboxextpack;

                case FileExtensions.Vdi:
                    return Vdi;

                case FileExtensions.Vhd:
                    return Vhd;

                case FileExtensions.Vmdk:
                    return Vmdk;

                case FileExtensions.Src:
                    return Src;

                case FileExtensions.Webapp:
                    return Webapp;

                case FileExtensions.Der:
                case FileExtensions.Crt:
                case FileExtensions.Pem:
                    return Der;

                case FileExtensions.Fig:
                    return Fig;

                case FileExtensions.Xlf:
                    return Xlf;

                case FileExtensions.Xpi:
                    return Xpi;

                case FileExtensions.Xz:
                    return Xz;

                case FileExtensions.Z1:
                case FileExtensions.Z2:
                case FileExtensions.Z3:
                case FileExtensions.Z4:
                case FileExtensions.Z5:
                case FileExtensions.Z6:
                case FileExtensions.Z7:
                case FileExtensions.Z8:
                    return Z1;

                case FileExtensions.Xaml:
                    return Xaml;

                case FileExtensions.Xav:
                    return Xav;

                case FileExtensions.Xca:
                    return Xca;

                case FileExtensions.Xdf:
                    return Xdf;

                case FileExtensions.Xel:
                    return Xel;

                case FileExtensions.Xns:
                    return Xns;

                case FileExtensions.Xenc:
                    return Xenc;

                case FileExtensions.Xhtml:
                case FileExtensions.Xht:
                    return Xhtml;

                case FileExtensions.Xml:
                case FileExtensions.Xsl:
                case FileExtensions.Xsd:
                case FileExtensions.Rng:
                    return Xml;

                case FileExtensions.Dtd:
                    return Dtd;

                case FileExtensions.Xop:
                    return Xop;

                case FileExtensions.Xpl:
                    return Xpl;

                case FileExtensions.Xslt:
                    return Xslt;

                case FileExtensions.Xspf:
                    return Xspf;

                case FileExtensions.Mxml:
                case FileExtensions.Xhvml:
                case FileExtensions.Xvml:
                case FileExtensions.Xvm:
                    return Mxml;

                case FileExtensions.Yang:
                    return Yang;

                case FileExtensions.Yin:
                    return Yin;

                case FileExtensions.Zip:
                    return Zip;

                case FileExtensions._3gpp:
                    return _3gpp;

                case FileExtensions.Adp:
                    return Adp;

                case FileExtensions.Amr:
                    return Amr;

                case FileExtensions.Au:
                case FileExtensions.Snd:
                    return Au;

                case FileExtensions.Mid:
                case FileExtensions.Midi:
                case FileExtensions.Kar:
                case FileExtensions.Rmi:
                    return Mid;

                case FileExtensions.Mxmf:
                    return Mxmf;

                case FileExtensions.Mp3:
                    return Mp3;

                case FileExtensions.M4a:
                case FileExtensions.Mp4a:
                    return M4a;

                case FileExtensions.Mpga:
                case FileExtensions.Mp2:
                case FileExtensions.Mp2a:
                case FileExtensions.M2a:
                case FileExtensions.M3a:
                    return Mpga;

                case FileExtensions.Oga:
                case FileExtensions.Ogg:
                case FileExtensions.Spx:
                case FileExtensions.Opus:
                    return Oga;

                case FileExtensions.S3m:
                    return S3m;

                case FileExtensions.Sil:
                    return Sil;

                case FileExtensions.Uva:
                case FileExtensions.Uvva:
                    return Uva;

                case FileExtensions.Eol:
                    return Eol;

                case FileExtensions.Dra:
                    return Dra;

                case FileExtensions.Dts:
                    return Dts;

                case FileExtensions.Dtshd:
                    return Dtshd;

                case FileExtensions.Lvp:
                    return Lvp;

                case FileExtensions.Pya:
                    return Pya;

                case FileExtensions.Ecelp4800:
                    return Ecelp4800;

                case FileExtensions.Ecelp7470:
                    return Ecelp7470;

                case FileExtensions.Ecelp9600:
                    return Ecelp9600;

                case FileExtensions.Rip:
                    return Rip;

                case FileExtensions.Wav:
                    return Wav;

                case FileExtensions.Weba:
                    return Weba;

                case FileExtensions.Aac:
                    return Aac;

                case FileExtensions.Aif:
                case FileExtensions.Aiff:
                case FileExtensions.Aifc:
                    return Aif;

                case FileExtensions.Caf:
                    return Caf;

                case FileExtensions.Flac:
                    return Flac;

                case FileExtensions.Mka:
                    return Mka;

                case FileExtensions.M3u:
                    return M3u;

                case FileExtensions.Wax:
                    return Wax;

                case FileExtensions.Wma:
                    return Wma;

                case FileExtensions.Ram:
                case FileExtensions.Ra:
                    return Ram;

                case FileExtensions.Rmp:
                    return Rmp;

                case FileExtensions.Xm:
                    return Xm;

                case FileExtensions.Cdx:
                    return Cdx;

                case FileExtensions.Cif:
                    return Cif;

                case FileExtensions.Cmdf:
                    return Cmdf;

                case FileExtensions.Cml:
                    return Cml;

                case FileExtensions.Csml:
                    return Csml;

                case FileExtensions.Xyz:
                    return Xyz;

                case FileExtensions.Ttc:
                    return Ttc;

                case FileExtensions.Otf:
                    return Otf;

                case FileExtensions.Ttf:
                    return Ttf;

                case FileExtensions.Woff:
                    return Woff;

                case FileExtensions.Woff2:
                    return Woff2;

                case FileExtensions.Exr:
                    return Exr;

                case FileExtensions.Apng:
                    return Apng;

                case FileExtensions.Avci:
                    return Avci;

                case FileExtensions.Avcs:
                    return Avcs;

                case FileExtensions.Avif:
                    return Avif;

                case FileExtensions.Bmp:
                    return Bmp;

                case FileExtensions.Cgm:
                    return Cgm;

                case FileExtensions.Drle:
                    return Drle;

                case FileExtensions.Fits:
                    return Fits;

                case FileExtensions.G3:
                    return G3;

                case FileExtensions.Gif:
                    return Gif;

                case FileExtensions.Heic:
                    return Heic;

                case FileExtensions.Heics:
                    return Heics;

                case FileExtensions.Heif:
                    return Heif;

                case FileExtensions.Heifs:
                    return Heifs;

                case FileExtensions.Hej2:
                    return Hej2;

                case FileExtensions.Hsj2:
                    return Hsj2;

                case FileExtensions.Ief:
                    return Ief;

                case FileExtensions.Jls:
                    return Jls;

                case FileExtensions.Jp2:
                case FileExtensions.Jpg2:
                    return Jp2;

                case FileExtensions.Jpeg:
                case FileExtensions.Jpg:
                case FileExtensions.Jpe:
                    return Jpeg;

                case FileExtensions.Jph:
                    return Jph;

                case FileExtensions.Jhc:
                    return Jhc;

                case FileExtensions.Jpm:
                    return Jpm;

                case FileExtensions.Jpx:
                case FileExtensions.Jpf:
                    return Jpx;

                case FileExtensions.Jxr:
                    return Jxr;

                case FileExtensions.Jxra:
                    return Jxra;

                case FileExtensions.Jxrs:
                    return Jxrs;

                case FileExtensions.Jxs:
                    return Jxs;

                case FileExtensions.Jxsc:
                    return Jxsc;

                case FileExtensions.Jxsi:
                    return Jxsi;

                case FileExtensions.Jxss:
                    return Jxss;

                case FileExtensions.Ktx:
                    return Ktx;

                case FileExtensions.Ktx2:
                    return Ktx2;

                case FileExtensions.Png:
                    return Png;

                case FileExtensions.Btif:
                    return Btif;

                case FileExtensions.Pti:
                    return Pti;

                case FileExtensions.Sgi:
                    return Sgi;

                case FileExtensions.Svg:
                case FileExtensions.Svgz:
                    return Svg;

                case FileExtensions.T38:
                    return T38;

                case FileExtensions.Tif:
                case FileExtensions.Tiff:
                    return Tif;

                case FileExtensions.Tfx:
                    return Tfx;

                case FileExtensions.Psd:
                    return Psd;

                case FileExtensions.Azv:
                    return Azv;

                case FileExtensions.Uvi:
                case FileExtensions.Uvvi:
                case FileExtensions.Uvg:
                case FileExtensions.Uvvg:
                    return Uvi;

                case FileExtensions.Djvu:
                case FileExtensions.Djv:
                    return Djvu;

                case FileExtensions.Sub:
                    return Sub;

                case FileExtensions.Dwg:
                    return Dwg;

                case FileExtensions.Dxf:
                    return Dxf;

                case FileExtensions.Fbs:
                    return Fbs;

                case FileExtensions.Fpx:
                    return Fpx;

                case FileExtensions.Fst:
                    return Fst;

                case FileExtensions.Mmr:
                    return Mmr;

                case FileExtensions.Rlc:
                    return Rlc;

                case FileExtensions.Ico:
                    return Ico;

                case FileExtensions.Dds:
                    return Dds;

                case FileExtensions.Mdi:
                    return Mdi;

                case FileExtensions.Wdp:
                    return Wdp;

                case FileExtensions.Npx:
                    return Npx;

                case FileExtensions.B16:
                    return B16;

                case FileExtensions.Tap:
                    return Tap;

                case FileExtensions.Vtf:
                    return Vtf;

                case FileExtensions.Wbmp:
                    return Wbmp;

                case FileExtensions.Xif:
                    return Xif;

                case FileExtensions.Pcx:
                    return Pcx;

                case FileExtensions.Webp:
                    return Webp;

                case FileExtensions._3ds:
                    return _3ds;

                case FileExtensions.Ras:
                    return Ras;

                case FileExtensions.Cmx:
                    return Cmx;

                case FileExtensions.Fh:
                case FileExtensions.Fhc:
                case FileExtensions.Fh4:
                case FileExtensions.Fh5:
                case FileExtensions.Fh7:
                    return Fh;

                case FileExtensions.Jng:
                    return Jng;

                case FileExtensions.Sid:
                    return Sid;

                case FileExtensions.Pic:
                case FileExtensions.Pct:
                    return Pic;

                case FileExtensions.Pnm:
                    return Pnm;

                case FileExtensions.Pbm:
                    return Pbm;

                case FileExtensions.Pgm:
                    return Pgm;

                case FileExtensions.Ppm:
                    return Ppm;

                case FileExtensions.Rgb:
                    return Rgb;

                case FileExtensions.Tga:
                    return Tga;

                case FileExtensions.Xbm:
                    return Xbm;

                case FileExtensions.Xpm:
                    return Xpm;

                case FileExtensions.Xwd:
                    return Xwd;

                case FileExtensions.Disposition_notification:
                    return Dispositionnotification;

                case FileExtensions.U8msg:
                    return U8msg;

                case FileExtensions.U8dsn:
                    return U8dsn;

                case FileExtensions.U8mdn:
                    return U8mdn;

                case FileExtensions.U8hdr:
                    return U8hdr;

                case FileExtensions.Eml:
                case FileExtensions.Mime:
                    return Eml;

                case FileExtensions.Wsc:
                    return Wsc;

                case FileExtensions._3mf:
                    return _3mf;

                case FileExtensions.Gltf:
                    return Gltf;

                case FileExtensions.Glb:
                    return Glb;

                case FileExtensions.Igs:
                case FileExtensions.Iges:
                    return Igs;

                case FileExtensions.Msh:
                case FileExtensions.Mesh:
                case FileExtensions.Silo:
                    return Msh;

                case FileExtensions.Mtl:
                    return Mtl;

                case FileExtensions.Stpx:
                    return Stpx;

                case FileExtensions.Stpz:
                    return Stpz;

                case FileExtensions.Stpxz:
                    return Stpxz;

                case FileExtensions.Dae:
                    return Dae;

                case FileExtensions.Dwf:
                    return Dwf;

                case FileExtensions.Gdl:
                    return Gdl;

                case FileExtensions.Gtw:
                    return Gtw;

                case FileExtensions.Mts:
                    return Mts;

                case FileExtensions.Ogex:
                    return Ogex;

                case FileExtensions.X_b:
                    return Xb;

                case FileExtensions.X_t:
                    return Xt;

                case FileExtensions.Vds:
                    return Vds;

                case FileExtensions.Usdz:
                    return Usdz;

                case FileExtensions.Bsp:
                    return Bsp;

                case FileExtensions.Vtu:
                    return Vtu;

                case FileExtensions.Wrl:
                case FileExtensions.Vrml:
                    return Wrl;

                case FileExtensions.X3db:
                case FileExtensions.X3dbz:
                    return X3db;

                case FileExtensions.X3dv:
                case FileExtensions.X3dvz:
                    return X3dv;

                case FileExtensions.X3d:
                case FileExtensions.X3dz:
                    return X3d;

                case FileExtensions.Appcache:
                case FileExtensions.Manifest:
                    return Appcache;

                case FileExtensions.Ics:
                case FileExtensions.Ifb:
                    return Ics;

                case FileExtensions.Coffee:
                case FileExtensions.Litcoffee:
                    return Coffee;

                case FileExtensions.Css:
                    return Css;

                case FileExtensions.Csv:
                    return Csv;

                case FileExtensions.Html:
                case FileExtensions.Htm:
                case FileExtensions.Shtml:
                    return Html;

                case FileExtensions.Jade:
                    return Jade;

                case FileExtensions.Jsx:
                    return Jsx;

                case FileExtensions.Less:
                    return Less;

                case FileExtensions.Markdown:
                case FileExtensions.Md:
                    return Markdown;

                case FileExtensions.Mml:
                    return Mml;

                case FileExtensions.Mdx:
                    return Mdx;

                case FileExtensions.N3:
                    return N3;

                case FileExtensions.Txt:
                case FileExtensions.Text:
                case FileExtensions.Conf:
                case FileExtensions.Def:
                case FileExtensions.List:
                case FileExtensions.Log:
                case FileExtensions.In:
                case FileExtensions.Ini:
                    return Txt;

                case FileExtensions.Dsc:
                    return Dsc;

                case FileExtensions.Rtx:
                    return Rtx;

                case FileExtensions.Sgml:
                case FileExtensions.Sgm:
                    return Sgml;

                case FileExtensions.Shex:
                    return Shex;

                case FileExtensions.Slim:
                case FileExtensions.Slm:
                    return Slim;

                case FileExtensions.Spdx:
                    return Spdx;

                case FileExtensions.Stylus:
                case FileExtensions.Styl:
                    return Stylus;

                case FileExtensions.Tsv:
                    return Tsv;

                case FileExtensions.T:
                case FileExtensions.Tr:
                case FileExtensions.Roff:
                case FileExtensions.Man:
                case FileExtensions.Me:
                case FileExtensions.Ms:
                    return T;

                case FileExtensions.Ttl:
                    return Ttl;

                case FileExtensions.Uri:
                case FileExtensions.Uris:
                case FileExtensions.Urls:
                    return Uri;

                case FileExtensions.Vcard:
                    return Vcard;

                case FileExtensions.Curl:
                    return Curl;

                case FileExtensions.Dcurl:
                    return Dcurl;

                case FileExtensions.Mcurl:
                    return Mcurl;

                case FileExtensions.Scurl:
                    return Scurl;

                case FileExtensions.Ged:
                    return Ged;

                case FileExtensions.Fly:
                    return Fly;

                case FileExtensions.Flx:
                    return Flx;

                case FileExtensions.Gv:
                    return Gv;

                case FileExtensions._3dml:
                    return _3dml;

                case FileExtensions.Spot:
                    return Spot;

                case FileExtensions.Jad:
                    return Jad;

                case FileExtensions.Wml:
                    return Wml;

                case FileExtensions.Wmls:
                    return Wmls;

                case FileExtensions.Vtt:
                    return Vtt;

                case FileExtensions.S:
                case FileExtensions.Asm:
                    return S;

                case FileExtensions.C:
                case FileExtensions.Cc:
                case FileExtensions.Cxx:
                case FileExtensions.Cpp:
                case FileExtensions.H:
                case FileExtensions.Hh:
                case FileExtensions.Dic:
                    return C;

                case FileExtensions.Htc:
                    return Htc;

                case FileExtensions.F:
                case FileExtensions.For:
                case FileExtensions.F77:
                case FileExtensions.F90:
                    return F;

                case FileExtensions.Hbs:
                    return Hbs;

                case FileExtensions.Java:
                    return Java;

                case FileExtensions.Lua:
                    return Lua;

                case FileExtensions.Mkd:
                    return Mkd;

                case FileExtensions.Nfo:
                    return Nfo;

                case FileExtensions.Opml:
                    return Opml;

                case FileExtensions.P:
                case FileExtensions.Pas:
                    return P;

                case FileExtensions.Pde:
                    return Pde;

                case FileExtensions.Sass:
                    return Sass;

                case FileExtensions.Scss:
                    return Scss;

                case FileExtensions.Etx:
                    return Etx;

                case FileExtensions.Sfv:
                    return Sfv;

                case FileExtensions.Ymp:
                    return Ymp;

                case FileExtensions.Uu:
                    return Uu;

                case FileExtensions.Vcs:
                    return Vcs;

                case FileExtensions.Vcf:
                    return Vcf;

                case FileExtensions.Yaml:
                case FileExtensions.Yml:
                    return Yaml;

                case FileExtensions._3gp:
                    return _3gp;

                case FileExtensions._3g2:
                    return _3g2;

                case FileExtensions.H261:
                    return H261;

                case FileExtensions.H263:
                    return H263;

                case FileExtensions.H264:
                    return H264;

                case FileExtensions.M4s:
                    return M4s;

                case FileExtensions.Jpgv:
                    return Jpgv;

                case FileExtensions.Jpgm:
                    return Jpgm;

                case FileExtensions.Mj2:
                case FileExtensions.Mjp2:
                    return Mj2;

                case FileExtensions.Ts:
                    return Ts;

                case FileExtensions.Mp4:
                case FileExtensions.Mp4v:
                case FileExtensions.Mpg4:
                    return Mp4;

                case FileExtensions.Mpeg:
                case FileExtensions.Mpg:
                case FileExtensions.Mpe:
                case FileExtensions.M1v:
                case FileExtensions.M2v:
                    return Mpeg;

                case FileExtensions.Ogv:
                    return Ogv;

                case FileExtensions.Qt:
                case FileExtensions.Mov:
                    return Qt;

                case FileExtensions.Uvh:
                case FileExtensions.Uvvh:
                    return Uvh;

                case FileExtensions.Uvm:
                case FileExtensions.Uvvm:
                    return Uvm;

                case FileExtensions.Uvp:
                case FileExtensions.Uvvp:
                    return Uvp;

                case FileExtensions.Uvs:
                case FileExtensions.Uvvs:
                    return Uvs;

                case FileExtensions.Uvv:
                case FileExtensions.Uvvv:
                    return Uvv;

                case FileExtensions.Dvb:
                    return Dvb;

                case FileExtensions.Fvt:
                    return Fvt;

                case FileExtensions.Mxu:
                case FileExtensions.M4u:
                    return Mxu;

                case FileExtensions.Pyv:
                    return Pyv;

                case FileExtensions.Uvu:
                case FileExtensions.Uvvu:
                    return Uvu;

                case FileExtensions.Viv:
                    return Viv;

                case FileExtensions.Webm:
                    return Webm;

                case FileExtensions.F4v:
                    return F4v;

                case FileExtensions.Fli:
                    return Fli;

                case FileExtensions.Flv:
                    return Flv;

                case FileExtensions.M4v:
                    return M4v;

                case FileExtensions.Mkv:
                case FileExtensions.Mk3d:
                case FileExtensions.Mks:
                    return Mkv;

                case FileExtensions.Mng:
                    return Mng;

                case FileExtensions.Asf:
                case FileExtensions.Asx:
                    return Asf;

                case FileExtensions.Vob:
                    return Vob;

                case FileExtensions.Wm:
                    return Wm;

                case FileExtensions.Wmv:
                    return Wmv;

                case FileExtensions.Wmx:
                    return Wmx;

                case FileExtensions.Wvx:
                    return Wvx;

                case FileExtensions.Avi:
                    return Avi;

                case FileExtensions.Movie:
                    return Movie;

                case FileExtensions.Smv:
                    return Smv;

                case FileExtensions.Ice:
                    return Ice;

                default: 
                    return null;
            }
        }

        // Switch-case instead of dictionary since it does the hashing at compile time rather than run time
        internal static string[]? LookupMimeType(string mimeType)
        {
            switch (mimeType)
            {
                case Ez:
					return new[] {FileExtensions.Ez};
                case Aw:
					return new[] {FileExtensions.Aw};
                case Atom:
					return new[] {FileExtensions.Atom};
                case Atomcat:
					return new[] {FileExtensions.Atomcat};
                case Atomdeleted:
					return new[] {FileExtensions.Atomdeleted};
                case Atomsvc:
					return new[] {FileExtensions.Atomsvc};
                case Dwd:
					return new[] {FileExtensions.Dwd};
                case Held:
					return new[] {FileExtensions.Held};
                case Rsat:
					return new[] {FileExtensions.Rsat};
                case Bdoc:
					return new[] {FileExtensions.Bdoc};
                case Xcs:
					return new[] {FileExtensions.Xcs};
                case Ccxml:
					return new[] {FileExtensions.Ccxml};
                case Cdfx:
					return new[] {FileExtensions.Cdfx};
                case Cdmia:
					return new[] {FileExtensions.Cdmia};
                case Cdmic:
					return new[] {FileExtensions.Cdmic};
                case Cdmid:
					return new[] {FileExtensions.Cdmid};
                case Cdmio:
					return new[] {FileExtensions.Cdmio};
                case Cdmiq:
					return new[] {FileExtensions.Cdmiq};
                case Cpl:
					return new[] {FileExtensions.Cpl};
                case Cu:
					return new[] {FileExtensions.Cu};
                case Mpd:
					return new[] {FileExtensions.Mpd};
                case Mpp:
					return new[] {FileExtensions.Mpp};
                case Davmount:
					return new[] {FileExtensions.Davmount};
                case Dbk:
					return new[] {FileExtensions.Dbk};
                case Dssc:
					return new[] {FileExtensions.Dssc};
                case Xdssc:
					return new[] {FileExtensions.Xdssc};
                case Es:
                //case Ecma:
					return new[] {FileExtensions.Es, FileExtensions.Ecma};
                case Emma:
					return new[] {FileExtensions.Emma};
                case Emotionml:
					return new[] {FileExtensions.Emotionml};
                case Epub:
					return new[] {FileExtensions.Epub};
                case Exi:
					return new[] {FileExtensions.Exi};
                case Exp:
					return new[] {FileExtensions.Exp};
                case Fdt:
					return new[] {FileExtensions.Fdt};
                case Pfr:
					return new[] {FileExtensions.Pfr};
                case Geojson:
					return new[] {FileExtensions.Geojson};
                case Gml:
					return new[] {FileExtensions.Gml};
                case Gpx:
					return new[] {FileExtensions.Gpx};
                case Gxf:
					return new[] {FileExtensions.Gxf};
                case Gz:
					return new[] {FileExtensions.Gz};
                case Hjson:
					return new[] {FileExtensions.Hjson};
                case Stk:
					return new[] {FileExtensions.Stk};
                case Ink:
                //case Inkml:
					return new[] {FileExtensions.Ink, FileExtensions.Inkml};
                case Ipfix:
					return new[] {FileExtensions.Ipfix};
                case Its:
					return new[] {FileExtensions.Its};
                case Jar:
                //case War:
                //case Ear:
					return new[] {FileExtensions.Jar, FileExtensions.War, FileExtensions.Ear};
                case Ser:
					return new[] {FileExtensions.Ser};
                case Class:
					return new[] {FileExtensions.Class};
                case Js:
                //case Mjs:
					return new[] {FileExtensions.Js, FileExtensions.Mjs};
                case Json:
                //case Map:
					return new[] {FileExtensions.Json, FileExtensions.Map};
                case Json5:
					return new[] {FileExtensions.Json5};
                case Jsonml:
					return new[] {FileExtensions.Jsonml};
                case Jsonld:
					return new[] {FileExtensions.Jsonld};
                case Lgr:
					return new[] {FileExtensions.Lgr};
                case Lostxml:
					return new[] {FileExtensions.Lostxml};
                case Hqx:
					return new[] {FileExtensions.Hqx};
                case Cpt:
					return new[] {FileExtensions.Cpt};
                case Mads:
					return new[] {FileExtensions.Mads};
                case Webmanifest:
					return new[] {FileExtensions.Webmanifest};
                case Mrc:
					return new[] {FileExtensions.Mrc};
                case Mrcx:
					return new[] {FileExtensions.Mrcx};
                case Ma:
                //case Nb:
                //case Mb:
					return new[] {FileExtensions.Ma, FileExtensions.Nb, FileExtensions.Mb};
                case Mathml:
					return new[] {FileExtensions.Mathml};
                case Mbox:
					return new[] {FileExtensions.Mbox};
                case Mpf:
					return new[] {FileExtensions.Mpf};
                case Mscml:
					return new[] {FileExtensions.Mscml};
                case Metalink:
					return new[] {FileExtensions.Metalink};
                case Meta4:
					return new[] {FileExtensions.Meta4};
                case Mets:
					return new[] {FileExtensions.Mets};
                case Maei:
					return new[] {FileExtensions.Maei};
                case Musd:
					return new[] {FileExtensions.Musd};
                case Mods:
					return new[] {FileExtensions.Mods};
                case M21:
                //case Mp21:
					return new[] {FileExtensions.M21, FileExtensions.Mp21};
                case Mp4s:
                //case M4p:
					return new[] {FileExtensions.Mp4s, FileExtensions.M4p};
                case Doc:
                //case Dot:
					return new[] {FileExtensions.Doc, FileExtensions.Dot};
                case Mxf:
					return new[] {FileExtensions.Mxf};
                case Nq:
					return new[] {FileExtensions.Nq};
                case Nt:
					return new[] {FileExtensions.Nt};
                case Cjs:
					return new[] {FileExtensions.Cjs};
                case Bin:
                //case Dms:
                //case Lrf:
                //case Mar:
                //case So:
                //case Dist:
                //case Distz:
                //case Pkg:
                //case Bpk:
                //case Dump:
                //case Elc:
                //case Deploy:
                //case Exe:
                //case Dll:
                //case Deb:
                //case Dmg:
                //case Iso:
                //case Img:
                //case Msi:
                //case Msp:
                //case Msm:
                //case Buffer:
					return new[] {FileExtensions.Bin, FileExtensions.Dms, FileExtensions.Lrf, FileExtensions.Mar, FileExtensions.So, FileExtensions.Dist, FileExtensions.Distz, FileExtensions.Pkg, FileExtensions.Bpk, FileExtensions.Dump, FileExtensions.Elc, FileExtensions.Deploy, FileExtensions.Exe, FileExtensions.Dll, FileExtensions.Deb, FileExtensions.Dmg, FileExtensions.Iso, FileExtensions.Img, FileExtensions.Msi, FileExtensions.Msp, FileExtensions.Msm, FileExtensions.Buffer};
                case Oda:
					return new[] {FileExtensions.Oda};
                case Opf:
					return new[] {FileExtensions.Opf};
                case Ogx:
					return new[] {FileExtensions.Ogx};
                case Omdoc:
					return new[] {FileExtensions.Omdoc};
                case Onetoc:
                //case Onetoc2:
                //case Onetmp:
                //case Onepkg:
					return new[] {FileExtensions.Onetoc, FileExtensions.Onetoc2, FileExtensions.Onetmp, FileExtensions.Onepkg};
                case Oxps:
					return new[] {FileExtensions.Oxps};
                case Relo:
					return new[] {FileExtensions.Relo};
                case Xer:
					return new[] {FileExtensions.Xer};
                case Pdf:
					return new[] {FileExtensions.Pdf};
                case Pgp:
					return new[] {FileExtensions.Pgp};
                case Asc:
					return new[] {FileExtensions.Asc};
                case Sig:
					return new[] {FileExtensions.Sig};
                case Prf:
					return new[] {FileExtensions.Prf};
                case P10:
					return new[] {FileExtensions.P10};
                case P7m:
                //case P7c:
					return new[] {FileExtensions.P7m, FileExtensions.P7c};
                case P7s:
					return new[] {FileExtensions.P7s};
                case P8:
					return new[] {FileExtensions.P8};
                case Ac:
					return new[] {FileExtensions.Ac};
                case Cer:
					return new[] {FileExtensions.Cer};
                case Crl:
					return new[] {FileExtensions.Crl};
                case Pkipath:
					return new[] {FileExtensions.Pkipath};
                case Pki:
					return new[] {FileExtensions.Pki};
                case Pls:
					return new[] {FileExtensions.Pls};
                case Ai:
                //case Eps:
                //case Ps:
					return new[] {FileExtensions.Ai, FileExtensions.Eps, FileExtensions.Ps};
                case Provx:
					return new[] {FileExtensions.Provx};
                case Cww:
					return new[] {FileExtensions.Cww};
                case Pskcxml:
					return new[] {FileExtensions.Pskcxml};
                case Raml:
					return new[] {FileExtensions.Raml};
                case Rdf:
                //case Owl:
					return new[] {FileExtensions.Rdf, FileExtensions.Owl};
                case Rif:
					return new[] {FileExtensions.Rif};
                case Rnc:
					return new[] {FileExtensions.Rnc};
                case Rl:
					return new[] {FileExtensions.Rl};
                case Rld:
					return new[] {FileExtensions.Rld};
                case Rs:
					return new[] {FileExtensions.Rs};
                case Rapd:
					return new[] {FileExtensions.Rapd};
                case Sls:
					return new[] {FileExtensions.Sls};
                case Rusd:
					return new[] {FileExtensions.Rusd};
                case Gbr:
					return new[] {FileExtensions.Gbr};
                case Mft:
					return new[] {FileExtensions.Mft};
                case Roa:
					return new[] {FileExtensions.Roa};
                case Rsd:
					return new[] {FileExtensions.Rsd};
                case Rss:
					return new[] {FileExtensions.Rss};
                case Rtf:
					return new[] {FileExtensions.Rtf};
                case Sbml:
					return new[] {FileExtensions.Sbml};
                case Scq:
					return new[] {FileExtensions.Scq};
                case Scs:
					return new[] {FileExtensions.Scs};
                case Spq:
					return new[] {FileExtensions.Spq};
                case Spp:
					return new[] {FileExtensions.Spp};
                case Sdp:
					return new[] {FileExtensions.Sdp};
                case Senmlx:
					return new[] {FileExtensions.Senmlx};
                case Sensmlx:
					return new[] {FileExtensions.Sensmlx};
                case Setpay:
					return new[] {FileExtensions.Setpay};
                case Setreg:
					return new[] {FileExtensions.Setreg};
                case Shf:
					return new[] {FileExtensions.Shf};
                case Siv:
                //case Sieve:
					return new[] {FileExtensions.Siv, FileExtensions.Sieve};
                case Smi:
                //case Smil:
					return new[] {FileExtensions.Smi, FileExtensions.Smil};
                case Rq:
					return new[] {FileExtensions.Rq};
                case Srx:
					return new[] {FileExtensions.Srx};
                case Gram:
					return new[] {FileExtensions.Gram};
                case Grxml:
					return new[] {FileExtensions.Grxml};
                case Sru:
					return new[] {FileExtensions.Sru};
                case Ssdl:
					return new[] {FileExtensions.Ssdl};
                case Ssml:
					return new[] {FileExtensions.Ssml};
                case Swidtag:
					return new[] {FileExtensions.Swidtag};
                case Tei:
                //case Teicorpus:
					return new[] {FileExtensions.Tei, FileExtensions.Teicorpus};
                case Tfi:
					return new[] {FileExtensions.Tfi};
                case Tsd:
					return new[] {FileExtensions.Tsd};
                case Toml:
					return new[] {FileExtensions.Toml};
                case Trig:
					return new[] {FileExtensions.Trig};
                case Ttml:
					return new[] {FileExtensions.Ttml};
                case Ubj:
					return new[] {FileExtensions.Ubj};
                case Rsheet:
					return new[] {FileExtensions.Rsheet};
                case Td:
					return new[] {FileExtensions.Td};
                case _1km:
					return new[] {FileExtensions._1km};
                case Plb:
					return new[] {FileExtensions.Plb};
                case Psb:
					return new[] {FileExtensions.Psb};
                case Pvb:
					return new[] {FileExtensions.Pvb};
                case Tcap:
					return new[] {FileExtensions.Tcap};
                case Pwn:
					return new[] {FileExtensions.Pwn};
                case Aso:
					return new[] {FileExtensions.Aso};
                case Imp:
					return new[] {FileExtensions.Imp};
                case Acu:
					return new[] {FileExtensions.Acu};
                case Atc:
                //case Acutc:
					return new[] {FileExtensions.Atc, FileExtensions.Acutc};
                case Air:
					return new[] {FileExtensions.Air};
                case Fcdt:
					return new[] {FileExtensions.Fcdt};
                case Fxp:
                //case Fxpl:
					return new[] {FileExtensions.Fxp, FileExtensions.Fxpl};
                case Xdp:
					return new[] {FileExtensions.Xdp};
                case Xfdf:
					return new[] {FileExtensions.Xfdf};
                case Age:
					return new[] {FileExtensions.Age};
                case Ahead:
					return new[] {FileExtensions.Ahead};
                case Azf:
					return new[] {FileExtensions.Azf};
                case Azs:
					return new[] {FileExtensions.Azs};
                case Azw:
					return new[] {FileExtensions.Azw};
                case Acc:
					return new[] {FileExtensions.Acc};
                case Ami:
					return new[] {FileExtensions.Ami};
                case Apk:
					return new[] {FileExtensions.Apk};
                case Cii:
					return new[] {FileExtensions.Cii};
                case Fti:
					return new[] {FileExtensions.Fti};
                case Atx:
					return new[] {FileExtensions.Atx};
                case Mpkg:
					return new[] {FileExtensions.Mpkg};
                case Key:
					return new[] {FileExtensions.Key};
                case M3u8:
					return new[] {FileExtensions.M3u8};
                case Numbers:
					return new[] {FileExtensions.Numbers};
                case Pages:
					return new[] {FileExtensions.Pages};
                case Pkpass:
					return new[] {FileExtensions.Pkpass};
                case Swi:
					return new[] {FileExtensions.Swi};
                case Iota:
					return new[] {FileExtensions.Iota};
                case Aep:
					return new[] {FileExtensions.Aep};
                case Bmml:
					return new[] {FileExtensions.Bmml};
                case Mpm:
					return new[] {FileExtensions.Mpm};
                case Bmi:
					return new[] {FileExtensions.Bmi};
                case Rep:
					return new[] {FileExtensions.Rep};
                case Cdxml:
					return new[] {FileExtensions.Cdxml};
                case Mmd:
					return new[] {FileExtensions.Mmd};
                case Cdy:
					return new[] {FileExtensions.Cdy};
                case Csl:
					return new[] {FileExtensions.Csl};
                case Cla:
					return new[] {FileExtensions.Cla};
                case Rp9:
					return new[] {FileExtensions.Rp9};
                case C4g:
                //case C4d:
                //case C4f:
                //case C4p:
                //case C4u:
					return new[] {FileExtensions.C4g, FileExtensions.C4d, FileExtensions.C4f, FileExtensions.C4p, FileExtensions.C4u};
                case C11amc:
					return new[] {FileExtensions.C11amc};
                case C11amz:
					return new[] {FileExtensions.C11amz};
                case Csp:
					return new[] {FileExtensions.Csp};
                case Cdbcmsg:
					return new[] {FileExtensions.Cdbcmsg};
                case Cmc:
					return new[] {FileExtensions.Cmc};
                case Clkx:
					return new[] {FileExtensions.Clkx};
                case Clkk:
					return new[] {FileExtensions.Clkk};
                case Clkp:
					return new[] {FileExtensions.Clkp};
                case Clkt:
					return new[] {FileExtensions.Clkt};
                case Clkw:
					return new[] {FileExtensions.Clkw};
                case Wbs:
					return new[] {FileExtensions.Wbs};
                case Pml:
					return new[] {FileExtensions.Pml};
                case Ppd:
					return new[] {FileExtensions.Ppd};
                case Car:
					return new[] {FileExtensions.Car};
                case Pcurl:
					return new[] {FileExtensions.Pcurl};
                case Dart:
					return new[] {FileExtensions.Dart};
                case Rdz:
					return new[] {FileExtensions.Rdz};
                case Dbf:
					return new[] {FileExtensions.Dbf};
                case Uvf:
                //case Uvvf:
                //case Uvd:
                //case Uvvd:
					return new[] {FileExtensions.Uvf, FileExtensions.Uvvf, FileExtensions.Uvd, FileExtensions.Uvvd};
                case Uvt:
                //case Uvvt:
					return new[] {FileExtensions.Uvt, FileExtensions.Uvvt};
                case Uvx:
                //case Uvvx:
					return new[] {FileExtensions.Uvx, FileExtensions.Uvvx};
                case Uvz:
                //case Uvvz:
					return new[] {FileExtensions.Uvz, FileExtensions.Uvvz};
                case Felaunch:
					return new[] {FileExtensions.Fe_launch};
                case Dna:
					return new[] {FileExtensions.Dna};
                case Mlp:
					return new[] {FileExtensions.Mlp};
                case Dpg:
					return new[] {FileExtensions.Dpg};
                case Dfac:
					return new[] {FileExtensions.Dfac};
                case Kpxx:
					return new[] {FileExtensions.Kpxx};
                case Ait:
					return new[] {FileExtensions.Ait};
                case Svc:
					return new[] {FileExtensions.Svc};
                case Geo:
					return new[] {FileExtensions.Geo};
                case Mag:
					return new[] {FileExtensions.Mag};
                case Nml:
					return new[] {FileExtensions.Nml};
                case Esf:
					return new[] {FileExtensions.Esf};
                case Msf:
					return new[] {FileExtensions.Msf};
                case Qam:
					return new[] {FileExtensions.Qam};
                case Slt:
					return new[] {FileExtensions.Slt};
                case Ssf:
					return new[] {FileExtensions.Ssf};
                case Es3:
                //case Et3:
					return new[] {FileExtensions.Es3, FileExtensions.Et3};
                case Ez2:
					return new[] {FileExtensions.Ez2};
                case Ez3:
					return new[] {FileExtensions.Ez3};
                case Fdf:
					return new[] {FileExtensions.Fdf};
                case Mseed:
					return new[] {FileExtensions.Mseed};
                case Seed:
                //case Dataless:
					return new[] {FileExtensions.Seed, FileExtensions.Dataless};
                case Gph:
					return new[] {FileExtensions.Gph};
                case Ftc:
					return new[] {FileExtensions.Ftc};
                case Fm:
                //case Frame:
                //case Maker:
                //case Book:
					return new[] {FileExtensions.Fm, FileExtensions.Frame, FileExtensions.Maker, FileExtensions.Book};
                case Fnc:
					return new[] {FileExtensions.Fnc};
                case Ltf:
					return new[] {FileExtensions.Ltf};
                case Fsc:
					return new[] {FileExtensions.Fsc};
                case Oas:
					return new[] {FileExtensions.Oas};
                case Oa2:
					return new[] {FileExtensions.Oa2};
                case Oa3:
					return new[] {FileExtensions.Oa3};
                case Fg5:
					return new[] {FileExtensions.Fg5};
                case Bh2:
					return new[] {FileExtensions.Bh2};
                case Ddd:
					return new[] {FileExtensions.Ddd};
                case Xdw:
					return new[] {FileExtensions.Xdw};
                case Xbd:
					return new[] {FileExtensions.Xbd};
                case Fzs:
					return new[] {FileExtensions.Fzs};
                case Txd:
					return new[] {FileExtensions.Txd};
                case Ggb:
					return new[] {FileExtensions.Ggb};
                case Ggt:
					return new[] {FileExtensions.Ggt};
                case Gex:
                //case Gre:
					return new[] {FileExtensions.Gex, FileExtensions.Gre};
                case Gxt:
					return new[] {FileExtensions.Gxt};
                case G2w:
					return new[] {FileExtensions.G2w};
                case G3w:
					return new[] {FileExtensions.G3w};
                case Gmx:
					return new[] {FileExtensions.Gmx};
                case Gdoc:
					return new[] {FileExtensions.Gdoc};
                case Gslides:
					return new[] {FileExtensions.Gslides};
                case Gsheet:
					return new[] {FileExtensions.Gsheet};
                case Kml:
					return new[] {FileExtensions.Kml};
                case Kmz:
					return new[] {FileExtensions.Kmz};
                case Gqf:
                //case Gqs:
					return new[] {FileExtensions.Gqf, FileExtensions.Gqs};
                case Gac:
					return new[] {FileExtensions.Gac};
                case Ghf:
					return new[] {FileExtensions.Ghf};
                case Gim:
					return new[] {FileExtensions.Gim};
                case Grv:
					return new[] {FileExtensions.Grv};
                case Gtm:
					return new[] {FileExtensions.Gtm};
                case Tpl:
					return new[] {FileExtensions.Tpl};
                case Vcg:
					return new[] {FileExtensions.Vcg};
                case Hal:
					return new[] {FileExtensions.Hal};
                case Zmm:
					return new[] {FileExtensions.Zmm};
                case Hbci:
					return new[] {FileExtensions.Hbci};
                case Les:
					return new[] {FileExtensions.Les};
                case Hpgl:
					return new[] {FileExtensions.Hpgl};
                case Hpid:
					return new[] {FileExtensions.Hpid};
                case Hps:
					return new[] {FileExtensions.Hps};
                case Jlt:
					return new[] {FileExtensions.Jlt};
                case Pcl:
					return new[] {FileExtensions.Pcl};
                case Pclxl:
					return new[] {FileExtensions.Pclxl};
                case Sfdhdstx:
					return new[] {FileExtensions.Sfd_hdstx};
                case Mpy:
					return new[] {FileExtensions.Mpy};
                case Afp:
                //case Listafp:
                //case List3820:
					return new[] {FileExtensions.Afp, FileExtensions.Listafp, FileExtensions.List3820};
                case Irm:
					return new[] {FileExtensions.Irm};
                case Sc:
					return new[] {FileExtensions.Sc};
                case Icc:
                //case Icm:
					return new[] {FileExtensions.Icc, FileExtensions.Icm};
                case Igl:
					return new[] {FileExtensions.Igl};
                case Ivp:
					return new[] {FileExtensions.Ivp};
                case Ivu:
					return new[] {FileExtensions.Ivu};
                case Igm:
					return new[] {FileExtensions.Igm};
                case Xpw:
                //case Xpx:
					return new[] {FileExtensions.Xpw, FileExtensions.Xpx};
                case I2g:
					return new[] {FileExtensions.I2g};
                case Qbo:
					return new[] {FileExtensions.Qbo};
                case Qfx:
					return new[] {FileExtensions.Qfx};
                case Rcprofile:
					return new[] {FileExtensions.Rcprofile};
                case Irp:
					return new[] {FileExtensions.Irp};
                case Xpr:
					return new[] {FileExtensions.Xpr};
                case Fcs:
					return new[] {FileExtensions.Fcs};
                case Jam:
					return new[] {FileExtensions.Jam};
                case Rms:
					return new[] {FileExtensions.Rms};
                case Jisp:
					return new[] {FileExtensions.Jisp};
                case Joda:
					return new[] {FileExtensions.Joda};
                case Ktz:
                //case Ktr:
					return new[] {FileExtensions.Ktz, FileExtensions.Ktr};
                case Karbon:
					return new[] {FileExtensions.Karbon};
                case Chrt:
					return new[] {FileExtensions.Chrt};
                case Kfo:
					return new[] {FileExtensions.Kfo};
                case Flw:
					return new[] {FileExtensions.Flw};
                case Kon:
					return new[] {FileExtensions.Kon};
                case Kpr:
                //case Kpt:
					return new[] {FileExtensions.Kpr, FileExtensions.Kpt};
                case Ksp:
					return new[] {FileExtensions.Ksp};
                case Kwd:
                //case Kwt:
					return new[] {FileExtensions.Kwd, FileExtensions.Kwt};
                case Htke:
					return new[] {FileExtensions.Htke};
                case Kia:
					return new[] {FileExtensions.Kia};
                case Kne:
                //case Knp:
					return new[] {FileExtensions.Kne, FileExtensions.Knp};
                case Skp:
                //case Skd:
                //case Skt:
                //case Skm:
					return new[] {FileExtensions.Skp, FileExtensions.Skd, FileExtensions.Skt, FileExtensions.Skm};
                case Sse:
					return new[] {FileExtensions.Sse};
                case Lasxml:
					return new[] {FileExtensions.Lasxml};
                case Lbd:
					return new[] {FileExtensions.Lbd};
                case Lbe:
					return new[] {FileExtensions.Lbe};
                case _123:
					return new[] {FileExtensions._123};
                case Apr:
					return new[] {FileExtensions.Apr};
                case Pre:
					return new[] {FileExtensions.Pre};
                case Nsf:
					return new[] {FileExtensions.Nsf};
                case Org:
					return new[] {FileExtensions.Org};
                case Scm:
					return new[] {FileExtensions.Scm};
                case Lwp:
					return new[] {FileExtensions.Lwp};
                case Portpkg:
					return new[] {FileExtensions.Portpkg};
                case Mvt:
					return new[] {FileExtensions.Mvt};
                case Mcd:
					return new[] {FileExtensions.Mcd};
                case Mc1:
					return new[] {FileExtensions.Mc1};
                case Cdkey:
					return new[] {FileExtensions.Cdkey};
                case Mwf:
					return new[] {FileExtensions.Mwf};
                case Mfm:
					return new[] {FileExtensions.Mfm};
                case Flo:
					return new[] {FileExtensions.Flo};
                case Igx:
					return new[] {FileExtensions.Igx};
                case Mif:
					return new[] {FileExtensions.Mif};
                case Daf:
					return new[] {FileExtensions.Daf};
                case Dis:
					return new[] {FileExtensions.Dis};
                case Mbk:
					return new[] {FileExtensions.Mbk};
                case Mqy:
					return new[] {FileExtensions.Mqy};
                case Msl:
					return new[] {FileExtensions.Msl};
                case Plc:
					return new[] {FileExtensions.Plc};
                case Txf:
					return new[] {FileExtensions.Txf};
                case Mpn:
					return new[] {FileExtensions.Mpn};
                case Mpc:
					return new[] {FileExtensions.Mpc};
                case Xul:
					return new[] {FileExtensions.Xul};
                case Cil:
					return new[] {FileExtensions.Cil};
                case Cab:
					return new[] {FileExtensions.Cab};
                case Xls:
                //case Xlm:
                //case Xla:
                //case Xlc:
                //case Xlt:
                //case Xlw:
					return new[] {FileExtensions.Xls, FileExtensions.Xlm, FileExtensions.Xla, FileExtensions.Xlc, FileExtensions.Xlt, FileExtensions.Xlw};
                case Xlam:
					return new[] {FileExtensions.Xlam};
                case Xlsb:
					return new[] {FileExtensions.Xlsb};
                case Xlsm:
					return new[] {FileExtensions.Xlsm};
                case Xltm:
					return new[] {FileExtensions.Xltm};
                case Eot:
					return new[] {FileExtensions.Eot};
                case Chm:
					return new[] {FileExtensions.Chm};
                case Ims:
					return new[] {FileExtensions.Ims};
                case Lrm:
					return new[] {FileExtensions.Lrm};
                case Thmx:
					return new[] {FileExtensions.Thmx};
                case Msg:
					return new[] {FileExtensions.Msg};
                case Cat:
					return new[] {FileExtensions.Cat};
                case Stl:
					return new[] {FileExtensions.Stl};
                case Ppt:
                //case Pps:
                //case Pot:
					return new[] {FileExtensions.Ppt, FileExtensions.Pps, FileExtensions.Pot};
                case Ppam:
					return new[] {FileExtensions.Ppam};
                case Pptm:
					return new[] {FileExtensions.Pptm};
                case Sldm:
					return new[] {FileExtensions.Sldm};
                case Ppsm:
					return new[] {FileExtensions.Ppsm};
                case Potm:
					return new[] {FileExtensions.Potm};
                case Mpt:
					return new[] {FileExtensions.Mpt};
                case Docm:
					return new[] {FileExtensions.Docm};
                case Dotm:
					return new[] {FileExtensions.Dotm};
                case Wps:
                //case Wks:
                //case Wcm:
                //case Wdb:
					return new[] {FileExtensions.Wps, FileExtensions.Wks, FileExtensions.Wcm, FileExtensions.Wdb};
                case Wpl:
					return new[] {FileExtensions.Wpl};
                case Xps:
					return new[] {FileExtensions.Xps};
                case Mseq:
					return new[] {FileExtensions.Mseq};
                case Mus:
					return new[] {FileExtensions.Mus};
                case Msty:
					return new[] {FileExtensions.Msty};
                case Taglet:
					return new[] {FileExtensions.Taglet};
                case Nlu:
					return new[] {FileExtensions.Nlu};
                case Ntf:
                //case Nitf:
					return new[] {FileExtensions.Ntf, FileExtensions.Nitf};
                case Nnd:
					return new[] {FileExtensions.Nnd};
                case Nns:
					return new[] {FileExtensions.Nns};
                case Nnw:
					return new[] {FileExtensions.Nnw};
                case Ngdat:
					return new[] {FileExtensions.Ngdat};
                case Ngage:
					return new[] {FileExtensions.N_gage};
                case Rpst:
					return new[] {FileExtensions.Rpst};
                case Rpss:
					return new[] {FileExtensions.Rpss};
                case Edm:
					return new[] {FileExtensions.Edm};
                case Edx:
					return new[] {FileExtensions.Edx};
                case Ext:
					return new[] {FileExtensions.Ext};
                case Odc:
					return new[] {FileExtensions.Odc};
                case Otc:
					return new[] {FileExtensions.Otc};
                case Odb:
					return new[] {FileExtensions.Odb};
                case Odf:
					return new[] {FileExtensions.Odf};
                case Odft:
					return new[] {FileExtensions.Odft};
                case Odg:
					return new[] {FileExtensions.Odg};
                case Otg:
					return new[] {FileExtensions.Otg};
                case Odi:
					return new[] {FileExtensions.Odi};
                case Oti:
					return new[] {FileExtensions.Oti};
                case Odp:
					return new[] {FileExtensions.Odp};
                case Otp:
					return new[] {FileExtensions.Otp};
                case Ods:
					return new[] {FileExtensions.Ods};
                case Ots:
					return new[] {FileExtensions.Ots};
                case Odt:
					return new[] {FileExtensions.Odt};
                case Odm:
					return new[] {FileExtensions.Odm};
                case Ott:
					return new[] {FileExtensions.Ott};
                case Oth:
					return new[] {FileExtensions.Oth};
                case Xo:
					return new[] {FileExtensions.Xo};
                case Dd2:
					return new[] {FileExtensions.Dd2};
                case Obgx:
					return new[] {FileExtensions.Obgx};
                case Oxt:
					return new[] {FileExtensions.Oxt};
                case Osm:
					return new[] {FileExtensions.Osm};
                case Pptx:
					return new[] {FileExtensions.Pptx};
                case Sldx:
					return new[] {FileExtensions.Sldx};
                case Ppsx:
					return new[] {FileExtensions.Ppsx};
                case Potx:
					return new[] {FileExtensions.Potx};
                case Xlsx:
					return new[] {FileExtensions.Xlsx};
                case Xltx:
					return new[] {FileExtensions.Xltx};
                case Docx:
					return new[] {FileExtensions.Docx};
                case Dotx:
					return new[] {FileExtensions.Dotx};
                case Mgp:
					return new[] {FileExtensions.Mgp};
                case Dp:
					return new[] {FileExtensions.Dp};
                case Esa:
					return new[] {FileExtensions.Esa};
                case Pdb:
                //case Pqa:
                //case Oprc:
					return new[] {FileExtensions.Pdb, FileExtensions.Pqa, FileExtensions.Oprc};
                case Paw:
					return new[] {FileExtensions.Paw};
                case Str:
					return new[] {FileExtensions.Str};
                case Ei6:
					return new[] {FileExtensions.Ei6};
                case Efif:
					return new[] {FileExtensions.Efif};
                case Wg:
					return new[] {FileExtensions.Wg};
                case Plf:
					return new[] {FileExtensions.Plf};
                case Pbd:
					return new[] {FileExtensions.Pbd};
                case Box:
					return new[] {FileExtensions.Box};
                case Mgz:
					return new[] {FileExtensions.Mgz};
                case Qps:
					return new[] {FileExtensions.Qps};
                case Ptid:
					return new[] {FileExtensions.Ptid};
                case Qxd:
                //case Qxt:
                //case Qwd:
                //case Qwt:
                //case Qxl:
                //case Qxb:
					return new[] {FileExtensions.Qxd, FileExtensions.Qxt, FileExtensions.Qwd, FileExtensions.Qwt, FileExtensions.Qxl, FileExtensions.Qxb};
                case Rar:
					return new[] {FileExtensions.Rar};
                case Bed:
					return new[] {FileExtensions.Bed};
                case Mxl:
					return new[] {FileExtensions.Mxl};
                case Musicxml:
					return new[] {FileExtensions.Musicxml};
                case Cryptonote:
					return new[] {FileExtensions.Cryptonote};
                case Cod:
					return new[] {FileExtensions.Cod};
                case Rm:
					return new[] {FileExtensions.Rm};
                case Rmvb:
					return new[] {FileExtensions.Rmvb};
                case Link66:
					return new[] {FileExtensions.Link66};
                case St:
					return new[] {FileExtensions.St};
                case See:
					return new[] {FileExtensions.See};
                case Sema:
					return new[] {FileExtensions.Sema};
                case Semd:
					return new[] {FileExtensions.Semd};
                case Semf:
					return new[] {FileExtensions.Semf};
                case Ifm:
					return new[] {FileExtensions.Ifm};
                case Itp:
					return new[] {FileExtensions.Itp};
                case Iif:
					return new[] {FileExtensions.Iif};
                case Ipk:
					return new[] {FileExtensions.Ipk};
                case Twd:
                //case Twds:
					return new[] {FileExtensions.Twd, FileExtensions.Twds};
                case Mmf:
					return new[] {FileExtensions.Mmf};
                case Teacher:
					return new[] {FileExtensions.Teacher};
                case Fo:
					return new[] {FileExtensions.Fo};
                case Sdkm:
                //case Sdkd:
					return new[] {FileExtensions.Sdkm, FileExtensions.Sdkd};
                case Dxp:
					return new[] {FileExtensions.Dxp};
                case Sfs:
					return new[] {FileExtensions.Sfs};
                case Sdc:
					return new[] {FileExtensions.Sdc};
                case Sda:
					return new[] {FileExtensions.Sda};
                case Sdd:
					return new[] {FileExtensions.Sdd};
                case Smf:
					return new[] {FileExtensions.Smf};
                case Sdw:
                //case Vor:
					return new[] {FileExtensions.Sdw, FileExtensions.Vor};
                case Sgl:
					return new[] {FileExtensions.Sgl};
                case Smzip:
					return new[] {FileExtensions.Smzip};
                case Sm:
					return new[] {FileExtensions.Sm};
                case Wadl:
					return new[] {FileExtensions.Wadl};
                case Sxc:
					return new[] {FileExtensions.Sxc};
                case Stc:
					return new[] {FileExtensions.Stc};
                case Sxd:
					return new[] {FileExtensions.Sxd};
                case Std:
					return new[] {FileExtensions.Std};
                case Sxi:
					return new[] {FileExtensions.Sxi};
                case Sti:
					return new[] {FileExtensions.Sti};
                case Sxm:
					return new[] {FileExtensions.Sxm};
                case Sxw:
					return new[] {FileExtensions.Sxw};
                case Sxg:
					return new[] {FileExtensions.Sxg};
                case Stw:
					return new[] {FileExtensions.Stw};
                case Sus:
                //case Susp:
					return new[] {FileExtensions.Sus, FileExtensions.Susp};
                case Svd:
					return new[] {FileExtensions.Svd};
                case Sis:
                //case Sisx:
					return new[] {FileExtensions.Sis, FileExtensions.Sisx};
                case Xsm:
					return new[] {FileExtensions.Xsm};
                case Bdm:
					return new[] {FileExtensions.Bdm};
                case Xdm:
					return new[] {FileExtensions.Xdm};
                case Ddf:
					return new[] {FileExtensions.Ddf};
                case Tao:
					return new[] {FileExtensions.Tao};
                case Pcap:
                //case Cap:
                //case Dmp:
					return new[] {FileExtensions.Pcap, FileExtensions.Cap, FileExtensions.Dmp};
                case Tmo:
					return new[] {FileExtensions.Tmo};
                case Tpt:
					return new[] {FileExtensions.Tpt};
                case Mxs:
					return new[] {FileExtensions.Mxs};
                case Tra:
					return new[] {FileExtensions.Tra};
                case Ufd:
                //case Ufdl:
					return new[] {FileExtensions.Ufd, FileExtensions.Ufdl};
                case Utz:
					return new[] {FileExtensions.Utz};
                case Umj:
					return new[] {FileExtensions.Umj};
                case Unityweb:
					return new[] {FileExtensions.Unityweb};
                case Uoml:
					return new[] {FileExtensions.Uoml};
                case Vcx:
					return new[] {FileExtensions.Vcx};
                case Vsd:
                //case Vst:
                //case Vss:
                //case Vsw:
					return new[] {FileExtensions.Vsd, FileExtensions.Vst, FileExtensions.Vss, FileExtensions.Vsw};
                case Vis:
					return new[] {FileExtensions.Vis};
                case Vsf:
					return new[] {FileExtensions.Vsf};
                case Wbxml:
					return new[] {FileExtensions.Wbxml};
                case Wmlc:
					return new[] {FileExtensions.Wmlc};
                case Wmlsc:
					return new[] {FileExtensions.Wmlsc};
                case Wtb:
					return new[] {FileExtensions.Wtb};
                case Nbp:
					return new[] {FileExtensions.Nbp};
                case Wpd:
					return new[] {FileExtensions.Wpd};
                case Wqd:
					return new[] {FileExtensions.Wqd};
                case Stf:
					return new[] {FileExtensions.Stf};
                case Xar:
					return new[] {FileExtensions.Xar};
                case Xfdl:
					return new[] {FileExtensions.Xfdl};
                case Hvd:
					return new[] {FileExtensions.Hvd};
                case Hvs:
					return new[] {FileExtensions.Hvs};
                case Hvp:
					return new[] {FileExtensions.Hvp};
                case Osf:
					return new[] {FileExtensions.Osf};
                case Osfpvg:
					return new[] {FileExtensions.Osfpvg};
                case Saf:
					return new[] {FileExtensions.Saf};
                case Spf:
					return new[] {FileExtensions.Spf};
                case Cmp:
					return new[] {FileExtensions.Cmp};
                case Zir:
                //case Zirz:
					return new[] {FileExtensions.Zir, FileExtensions.Zirz};
                case Zaz:
					return new[] {FileExtensions.Zaz};
                case Vxml:
					return new[] {FileExtensions.Vxml};
                case Wasm:
					return new[] {FileExtensions.Wasm};
                case Wif:
					return new[] {FileExtensions.Wif};
                case Wgt:
					return new[] {FileExtensions.Wgt};
                case Hlp:
					return new[] {FileExtensions.Hlp};
                case Wsdl:
					return new[] {FileExtensions.Wsdl};
                case Wspolicy:
					return new[] {FileExtensions.Wspolicy};
                case _7z:
					return new[] {FileExtensions._7z};
                case Abw:
					return new[] {FileExtensions.Abw};
                case Ace:
					return new[] {FileExtensions.Ace};
                case Arj:
					return new[] {FileExtensions.Arj};
                case Aab:
                //case X32:
                //case U32:
                //case Vox:
					return new[] {FileExtensions.Aab, FileExtensions.X32, FileExtensions.U32, FileExtensions.Vox};
                case Aam:
					return new[] {FileExtensions.Aam};
                case Aas:
					return new[] {FileExtensions.Aas};
                case Bcpio:
					return new[] {FileExtensions.Bcpio};
                case Torrent:
					return new[] {FileExtensions.Torrent};
                case Blb:
                //case Blorb:
					return new[] {FileExtensions.Blb, FileExtensions.Blorb};
                case Bz:
					return new[] {FileExtensions.Bz};
                case Bz2:
                //case Boz:
					return new[] {FileExtensions.Bz2, FileExtensions.Boz};
                case Cbr:
                //case Cba:
                //case Cbt:
                //case Cbz:
                //case Cb7:
					return new[] {FileExtensions.Cbr, FileExtensions.Cba, FileExtensions.Cbt, FileExtensions.Cbz, FileExtensions.Cb7};
                case Vcd:
					return new[] {FileExtensions.Vcd};
                case Cfs:
					return new[] {FileExtensions.Cfs};
                case Chat:
					return new[] {FileExtensions.Chat};
                case Pgn:
					return new[] {FileExtensions.Pgn};
                case Crx:
					return new[] {FileExtensions.Crx};
                case Cco:
					return new[] {FileExtensions.Cco};
                case Nsc:
					return new[] {FileExtensions.Nsc};
                case Cpio:
					return new[] {FileExtensions.Cpio};
                case Csh:
					return new[] {FileExtensions.Csh};
                case Udeb:
					return new[] {FileExtensions.Udeb};
                case Dgc:
					return new[] {FileExtensions.Dgc};
                case Dir:
                //case Dcr:
                //case Dxr:
                //case Cst:
                //case Cct:
                //case Cxt:
                //case W3d:
                //case Fgd:
                //case Swa:
					return new[] {FileExtensions.Dir, FileExtensions.Dcr, FileExtensions.Dxr, FileExtensions.Cst, FileExtensions.Cct, FileExtensions.Cxt, FileExtensions.W3d, FileExtensions.Fgd, FileExtensions.Swa};
                case Wad:
					return new[] {FileExtensions.Wad};
                case Ncx:
					return new[] {FileExtensions.Ncx};
                case Dtb:
					return new[] {FileExtensions.Dtb};
                case Res:
					return new[] {FileExtensions.Res};
                case Dvi:
					return new[] {FileExtensions.Dvi};
                case Evy:
					return new[] {FileExtensions.Evy};
                case Eva:
					return new[] {FileExtensions.Eva};
                case Bdf:
					return new[] {FileExtensions.Bdf};
                case Gsf:
					return new[] {FileExtensions.Gsf};
                case Psf:
					return new[] {FileExtensions.Psf};
                case Pcf:
					return new[] {FileExtensions.Pcf};
                case Snf:
					return new[] {FileExtensions.Snf};
                case Pfa:
                //case Pfb:
                //case Pfm:
                //case Afm:
					return new[] {FileExtensions.Pfa, FileExtensions.Pfb, FileExtensions.Pfm, FileExtensions.Afm};
                case Arc:
					return new[] {FileExtensions.Arc};
                case Spl:
					return new[] {FileExtensions.Spl};
                case Gca:
					return new[] {FileExtensions.Gca};
                case Ulx:
					return new[] {FileExtensions.Ulx};
                case Gnumeric:
					return new[] {FileExtensions.Gnumeric};
                case Gramps:
					return new[] {FileExtensions.Gramps};
                case Gtar:
					return new[] {FileExtensions.Gtar};
                case Hdf:
					return new[] {FileExtensions.Hdf};
                case Php:
					return new[] {FileExtensions.Php};
                case Install:
					return new[] {FileExtensions.Install};
                case Jardiff:
					return new[] {FileExtensions.Jardiff};
                case Jnlp:
					return new[] {FileExtensions.Jnlp};
                case Kdbx:
					return new[] {FileExtensions.Kdbx};
                case Latex:
					return new[] {FileExtensions.Latex};
                case Luac:
					return new[] {FileExtensions.Luac};
                case Lzh:
                //case Lha:
					return new[] {FileExtensions.Lzh, FileExtensions.Lha};
                case Run:
					return new[] {FileExtensions.Run};
                case Mie:
					return new[] {FileExtensions.Mie};
                case Prc:
                //case Mobi:
					return new[] {FileExtensions.Prc, FileExtensions.Mobi};
                case Application:
					return new[] {FileExtensions.Application};
                case Lnk:
					return new[] {FileExtensions.Lnk};
                case Wmd:
					return new[] {FileExtensions.Wmd};
                case Wmz:
					return new[] {FileExtensions.Wmz};
                case Xbap:
					return new[] {FileExtensions.Xbap};
                case Mdb:
					return new[] {FileExtensions.Mdb};
                case Obd:
					return new[] {FileExtensions.Obd};
                case Crd:
					return new[] {FileExtensions.Crd};
                case Clp:
					return new[] {FileExtensions.Clp};
                case Com:
                //case Bat:
					return new[] {FileExtensions.Com, FileExtensions.Bat};
                case Mvb:
                //case M13:
                //case M14:
					return new[] {FileExtensions.Mvb, FileExtensions.M13, FileExtensions.M14};
                case Wmf:
                //case Emf:
                //case Emz:
					return new[] {FileExtensions.Wmf, FileExtensions.Emf, FileExtensions.Emz};
                case Mny:
					return new[] {FileExtensions.Mny};
                case Pub:
					return new[] {FileExtensions.Pub};
                case Scd:
					return new[] {FileExtensions.Scd};
                case Trm:
					return new[] {FileExtensions.Trm};
                case Wri:
					return new[] {FileExtensions.Wri};
                case Nc:
                //case Cdf:
					return new[] {FileExtensions.Nc, FileExtensions.Cdf};
                case Pac:
					return new[] {FileExtensions.Pac};
                case Nzb:
					return new[] {FileExtensions.Nzb};
                case Pl:
                //case Pm:
					return new[] {FileExtensions.Pl, FileExtensions.Pm};
                case P12:
                //case Pfx:
					return new[] {FileExtensions.P12, FileExtensions.Pfx};
                case P7b:
                //case Spc:
					return new[] {FileExtensions.P7b, FileExtensions.Spc};
                case P7r:
					return new[] {FileExtensions.P7r};
                case Rpm:
					return new[] {FileExtensions.Rpm};
                case Ris:
					return new[] {FileExtensions.Ris};
                case Sea:
					return new[] {FileExtensions.Sea};
                case Sh:
					return new[] {FileExtensions.Sh};
                case Shar:
					return new[] {FileExtensions.Shar};
                case Swf:
					return new[] {FileExtensions.Swf};
                case Xap:
					return new[] {FileExtensions.Xap};
                case Sql:
					return new[] {FileExtensions.Sql};
                case Sit:
					return new[] {FileExtensions.Sit};
                case Sitx:
					return new[] {FileExtensions.Sitx};
                case Srt:
					return new[] {FileExtensions.Srt};
                case Sv4cpio:
					return new[] {FileExtensions.Sv4cpio};
                case Sv4crc:
					return new[] {FileExtensions.Sv4crc};
                case T3:
					return new[] {FileExtensions.T3};
                case Gam:
					return new[] {FileExtensions.Gam};
                case Tar:
					return new[] {FileExtensions.Tar};
                case Tcl:
                //case Tk:
					return new[] {FileExtensions.Tcl, FileExtensions.Tk};
                case Tex:
					return new[] {FileExtensions.Tex};
                case Tfm:
					return new[] {FileExtensions.Tfm};
                case Texinfo:
                //case Texi:
					return new[] {FileExtensions.Texinfo, FileExtensions.Texi};
                case Obj:
					return new[] {FileExtensions.Obj};
                case Ustar:
					return new[] {FileExtensions.Ustar};
                case Hdd:
					return new[] {FileExtensions.Hdd};
                case Ova:
					return new[] {FileExtensions.Ova};
                case Ovf:
					return new[] {FileExtensions.Ovf};
                case Vbox:
					return new[] {FileExtensions.Vbox};
                case Vboxextpack:
					return new[] {FileExtensions.Vbox_extpack};
                case Vdi:
					return new[] {FileExtensions.Vdi};
                case Vhd:
					return new[] {FileExtensions.Vhd};
                case Vmdk:
					return new[] {FileExtensions.Vmdk};
                case Src:
					return new[] {FileExtensions.Src};
                case Webapp:
					return new[] {FileExtensions.Webapp};
                case Der:
                //case Crt:
                //case Pem:
					return new[] {FileExtensions.Der, FileExtensions.Crt, FileExtensions.Pem};
                case Fig:
					return new[] {FileExtensions.Fig};
                case Xlf:
					return new[] {FileExtensions.Xlf};
                case Xpi:
					return new[] {FileExtensions.Xpi};
                case Xz:
					return new[] {FileExtensions.Xz};
                case Z1:
                //case Z2:
                //case Z3:
                //case Z4:
                //case Z5:
                //case Z6:
                //case Z7:
                //case Z8:
					return new[] {FileExtensions.Z1, FileExtensions.Z2, FileExtensions.Z3, FileExtensions.Z4, FileExtensions.Z5, FileExtensions.Z6, FileExtensions.Z7, FileExtensions.Z8};
                case Xaml:
					return new[] {FileExtensions.Xaml};
                case Xav:
					return new[] {FileExtensions.Xav};
                case Xca:
					return new[] {FileExtensions.Xca};
                case Xdf:
					return new[] {FileExtensions.Xdf};
                case Xel:
					return new[] {FileExtensions.Xel};
                case Xns:
					return new[] {FileExtensions.Xns};
                case Xenc:
					return new[] {FileExtensions.Xenc};
                case Xhtml:
                //case Xht:
					return new[] {FileExtensions.Xhtml, FileExtensions.Xht};
                case Xml:
                //case Xsl:
                //case Xsd:
                //case Rng:
					return new[] {FileExtensions.Xml, FileExtensions.Xsl, FileExtensions.Xsd, FileExtensions.Rng};
                case Dtd:
					return new[] {FileExtensions.Dtd};
                case Xop:
					return new[] {FileExtensions.Xop};
                case Xpl:
					return new[] {FileExtensions.Xpl};
                case Xslt:
					return new[] {FileExtensions.Xslt};
                case Xspf:
					return new[] {FileExtensions.Xspf};
                case Mxml:
                //case Xhvml:
                //case Xvml:
                //case Xvm:
					return new[] {FileExtensions.Mxml, FileExtensions.Xhvml, FileExtensions.Xvml, FileExtensions.Xvm};
                case Yang:
					return new[] {FileExtensions.Yang};
                case Yin:
					return new[] {FileExtensions.Yin};
                case Zip:
					return new[] {FileExtensions.Zip};
                case _3gpp:
					return new[] {FileExtensions._3gpp};
                case Adp:
					return new[] {FileExtensions.Adp};
                case Amr:
					return new[] {FileExtensions.Amr};
                case Au:
                //case Snd:
					return new[] {FileExtensions.Au, FileExtensions.Snd};
                case Mid:
                //case Midi:
                //case Kar:
                //case Rmi:
					return new[] {FileExtensions.Mid, FileExtensions.Midi, FileExtensions.Kar, FileExtensions.Rmi};
                case Mxmf:
					return new[] {FileExtensions.Mxmf};
                case Mp3:
					return new[] {FileExtensions.Mp3};
                case M4a:
                //case Mp4a:
					return new[] {FileExtensions.M4a, FileExtensions.Mp4a};
                case Mpga:
                //case Mp2:
                //case Mp2a:
                //case M2a:
                //case M3a:
					return new[] {FileExtensions.Mpga, FileExtensions.Mp2, FileExtensions.Mp2a, FileExtensions.M2a, FileExtensions.M3a};
                case Oga:
                //case Ogg:
                //case Spx:
                //case Opus:
					return new[] {FileExtensions.Oga, FileExtensions.Ogg, FileExtensions.Spx, FileExtensions.Opus};
                case S3m:
					return new[] {FileExtensions.S3m};
                case Sil:
					return new[] {FileExtensions.Sil};
                case Uva:
                //case Uvva:
					return new[] {FileExtensions.Uva, FileExtensions.Uvva};
                case Eol:
					return new[] {FileExtensions.Eol};
                case Dra:
					return new[] {FileExtensions.Dra};
                case Dts:
					return new[] {FileExtensions.Dts};
                case Dtshd:
					return new[] {FileExtensions.Dtshd};
                case Lvp:
					return new[] {FileExtensions.Lvp};
                case Pya:
					return new[] {FileExtensions.Pya};
                case Ecelp4800:
					return new[] {FileExtensions.Ecelp4800};
                case Ecelp7470:
					return new[] {FileExtensions.Ecelp7470};
                case Ecelp9600:
					return new[] {FileExtensions.Ecelp9600};
                case Rip:
					return new[] {FileExtensions.Rip};
                case Wav:
					return new[] {FileExtensions.Wav};
                case Weba:
					return new[] {FileExtensions.Weba};
                case Aac:
					return new[] {FileExtensions.Aac};
                case Aif:
                //case Aiff:
                //case Aifc:
					return new[] {FileExtensions.Aif, FileExtensions.Aiff, FileExtensions.Aifc};
                case Caf:
					return new[] {FileExtensions.Caf};
                case Flac:
					return new[] {FileExtensions.Flac};
                case Mka:
					return new[] {FileExtensions.Mka};
                case M3u:
					return new[] {FileExtensions.M3u};
                case Wax:
					return new[] {FileExtensions.Wax};
                case Wma:
					return new[] {FileExtensions.Wma};
                case Ram:
                //case Ra:
					return new[] {FileExtensions.Ram, FileExtensions.Ra};
                case Rmp:
					return new[] {FileExtensions.Rmp};
                case Xm:
					return new[] {FileExtensions.Xm};
                case Cdx:
					return new[] {FileExtensions.Cdx};
                case Cif:
					return new[] {FileExtensions.Cif};
                case Cmdf:
					return new[] {FileExtensions.Cmdf};
                case Cml:
					return new[] {FileExtensions.Cml};
                case Csml:
					return new[] {FileExtensions.Csml};
                case Xyz:
					return new[] {FileExtensions.Xyz};
                case Ttc:
					return new[] {FileExtensions.Ttc};
                case Otf:
					return new[] {FileExtensions.Otf};
                case Ttf:
					return new[] {FileExtensions.Ttf};
                case Woff:
					return new[] {FileExtensions.Woff};
                case Woff2:
					return new[] {FileExtensions.Woff2};
                case Exr:
					return new[] {FileExtensions.Exr};
                case Apng:
					return new[] {FileExtensions.Apng};
                case Avci:
					return new[] {FileExtensions.Avci};
                case Avcs:
					return new[] {FileExtensions.Avcs};
                case Avif:
					return new[] {FileExtensions.Avif};
                case Bmp:
					return new[] {FileExtensions.Bmp};
                case Cgm:
					return new[] {FileExtensions.Cgm};
                case Drle:
					return new[] {FileExtensions.Drle};
                case Fits:
					return new[] {FileExtensions.Fits};
                case G3:
					return new[] {FileExtensions.G3};
                case Gif:
					return new[] {FileExtensions.Gif};
                case Heic:
					return new[] {FileExtensions.Heic};
                case Heics:
					return new[] {FileExtensions.Heics};
                case Heif:
					return new[] {FileExtensions.Heif};
                case Heifs:
					return new[] {FileExtensions.Heifs};
                case Hej2:
					return new[] {FileExtensions.Hej2};
                case Hsj2:
					return new[] {FileExtensions.Hsj2};
                case Ief:
					return new[] {FileExtensions.Ief};
                case Jls:
					return new[] {FileExtensions.Jls};
                case Jp2:
                //case Jpg2:
					return new[] {FileExtensions.Jp2, FileExtensions.Jpg2};
                case Jpeg:
                //case Jpg:
                //case Jpe:
					return new[] {FileExtensions.Jpeg, FileExtensions.Jpg, FileExtensions.Jpe};
                case Jph:
					return new[] {FileExtensions.Jph};
                case Jhc:
					return new[] {FileExtensions.Jhc};
                case Jpm:
					return new[] {FileExtensions.Jpm};
                case Jpx:
                //case Jpf:
					return new[] {FileExtensions.Jpx, FileExtensions.Jpf};
                case Jxr:
					return new[] {FileExtensions.Jxr};
                case Jxra:
					return new[] {FileExtensions.Jxra};
                case Jxrs:
					return new[] {FileExtensions.Jxrs};
                case Jxs:
					return new[] {FileExtensions.Jxs};
                case Jxsc:
					return new[] {FileExtensions.Jxsc};
                case Jxsi:
					return new[] {FileExtensions.Jxsi};
                case Jxss:
					return new[] {FileExtensions.Jxss};
                case Ktx:
					return new[] {FileExtensions.Ktx};
                case Ktx2:
					return new[] {FileExtensions.Ktx2};
                case Png:
					return new[] {FileExtensions.Png};
                case Btif:
					return new[] {FileExtensions.Btif};
                case Pti:
					return new[] {FileExtensions.Pti};
                case Sgi:
					return new[] {FileExtensions.Sgi};
                case Svg:
                //case Svgz:
					return new[] {FileExtensions.Svg, FileExtensions.Svgz};
                case T38:
					return new[] {FileExtensions.T38};
                case Tif:
                //case Tiff:
					return new[] {FileExtensions.Tif, FileExtensions.Tiff};
                case Tfx:
					return new[] {FileExtensions.Tfx};
                case Psd:
					return new[] {FileExtensions.Psd};
                case Azv:
					return new[] {FileExtensions.Azv};
                case Uvi:
                //case Uvvi:
                //case Uvg:
                //case Uvvg:
					return new[] {FileExtensions.Uvi, FileExtensions.Uvvi, FileExtensions.Uvg, FileExtensions.Uvvg};
                case Djvu:
                //case Djv:
					return new[] {FileExtensions.Djvu, FileExtensions.Djv};
                case Sub:
					return new[] {FileExtensions.Sub};
                case Dwg:
					return new[] {FileExtensions.Dwg};
                case Dxf:
					return new[] {FileExtensions.Dxf};
                case Fbs:
					return new[] {FileExtensions.Fbs};
                case Fpx:
					return new[] {FileExtensions.Fpx};
                case Fst:
					return new[] {FileExtensions.Fst};
                case Mmr:
					return new[] {FileExtensions.Mmr};
                case Rlc:
					return new[] {FileExtensions.Rlc};
                case Ico:
					return new[] {FileExtensions.Ico};
                case Dds:
					return new[] {FileExtensions.Dds};
                case Mdi:
					return new[] {FileExtensions.Mdi};
                case Wdp:
					return new[] {FileExtensions.Wdp};
                case Npx:
					return new[] {FileExtensions.Npx};
                case B16:
					return new[] {FileExtensions.B16};
                case Tap:
					return new[] {FileExtensions.Tap};
                case Vtf:
					return new[] {FileExtensions.Vtf};
                case Wbmp:
					return new[] {FileExtensions.Wbmp};
                case Xif:
					return new[] {FileExtensions.Xif};
                case Pcx:
					return new[] {FileExtensions.Pcx};
                case Webp:
					return new[] {FileExtensions.Webp};
                case _3ds:
					return new[] {FileExtensions._3ds};
                case Ras:
					return new[] {FileExtensions.Ras};
                case Cmx:
					return new[] {FileExtensions.Cmx};
                case Fh:
                //case Fhc:
                //case Fh4:
                //case Fh5:
                //case Fh7:
					return new[] {FileExtensions.Fh, FileExtensions.Fhc, FileExtensions.Fh4, FileExtensions.Fh5, FileExtensions.Fh7};
                case Jng:
					return new[] {FileExtensions.Jng};
                case Sid:
					return new[] {FileExtensions.Sid};
                case Pic:
                //case Pct:
					return new[] {FileExtensions.Pic, FileExtensions.Pct};
                case Pnm:
					return new[] {FileExtensions.Pnm};
                case Pbm:
					return new[] {FileExtensions.Pbm};
                case Pgm:
					return new[] {FileExtensions.Pgm};
                case Ppm:
					return new[] {FileExtensions.Ppm};
                case Rgb:
					return new[] {FileExtensions.Rgb};
                case Tga:
					return new[] {FileExtensions.Tga};
                case Xbm:
					return new[] {FileExtensions.Xbm};
                case Xpm:
					return new[] {FileExtensions.Xpm};
                case Xwd:
					return new[] {FileExtensions.Xwd};
                case Dispositionnotification:
					return new[] {FileExtensions.Disposition_notification};
                case U8msg:
					return new[] {FileExtensions.U8msg};
                case U8dsn:
					return new[] {FileExtensions.U8dsn};
                case U8mdn:
					return new[] {FileExtensions.U8mdn};
                case U8hdr:
					return new[] {FileExtensions.U8hdr};
                case Eml:
                //case Mime:
					return new[] {FileExtensions.Eml, FileExtensions.Mime};
                case Wsc:
					return new[] {FileExtensions.Wsc};
                case _3mf:
					return new[] {FileExtensions._3mf};
                case Gltf:
					return new[] {FileExtensions.Gltf};
                case Glb:
					return new[] {FileExtensions.Glb};
                case Igs:
                //case Iges:
					return new[] {FileExtensions.Igs, FileExtensions.Iges};
                case Msh:
                //case Mesh:
                //case Silo:
					return new[] {FileExtensions.Msh, FileExtensions.Mesh, FileExtensions.Silo};
                case Mtl:
					return new[] {FileExtensions.Mtl};
                case Stpx:
					return new[] {FileExtensions.Stpx};
                case Stpz:
					return new[] {FileExtensions.Stpz};
                case Stpxz:
					return new[] {FileExtensions.Stpxz};
                case Dae:
					return new[] {FileExtensions.Dae};
                case Dwf:
					return new[] {FileExtensions.Dwf};
                case Gdl:
					return new[] {FileExtensions.Gdl};
                case Gtw:
					return new[] {FileExtensions.Gtw};
                case Mts:
					return new[] {FileExtensions.Mts};
                case Ogex:
					return new[] {FileExtensions.Ogex};
                case Xb:
					return new[] {FileExtensions.X_b};
                case Xt:
					return new[] {FileExtensions.X_t};
                case Vds:
					return new[] {FileExtensions.Vds};
                case Usdz:
					return new[] {FileExtensions.Usdz};
                case Bsp:
					return new[] {FileExtensions.Bsp};
                case Vtu:
					return new[] {FileExtensions.Vtu};
                case Wrl:
                //case Vrml:
					return new[] {FileExtensions.Wrl, FileExtensions.Vrml};
                case X3db:
                //case X3dbz:
					return new[] {FileExtensions.X3db, FileExtensions.X3dbz};
                case X3dv:
                //case X3dvz:
					return new[] {FileExtensions.X3dv, FileExtensions.X3dvz};
                case X3d:
                //case X3dz:
					return new[] {FileExtensions.X3d, FileExtensions.X3dz};
                case Appcache:
                //case Manifest:
					return new[] {FileExtensions.Appcache, FileExtensions.Manifest};
                case Ics:
                //case Ifb:
					return new[] {FileExtensions.Ics, FileExtensions.Ifb};
                case Coffee:
                //case Litcoffee:
					return new[] {FileExtensions.Coffee, FileExtensions.Litcoffee};
                case Css:
					return new[] {FileExtensions.Css};
                case Csv:
					return new[] {FileExtensions.Csv};
                case Html:
                //case Htm:
                //case Shtml:
					return new[] {FileExtensions.Html, FileExtensions.Htm, FileExtensions.Shtml};
                case Jade:
					return new[] {FileExtensions.Jade};
                case Jsx:
					return new[] {FileExtensions.Jsx};
                case Less:
					return new[] {FileExtensions.Less};
                case Markdown:
                //case Md:
					return new[] {FileExtensions.Markdown, FileExtensions.Md};
                case Mml:
					return new[] {FileExtensions.Mml};
                case Mdx:
					return new[] {FileExtensions.Mdx};
                case N3:
					return new[] {FileExtensions.N3};
                case Txt:
                //case Text:
                //case Conf:
                //case Def:
                //case List:
                //case Log:
                //case In:
                //case Ini:
					return new[] {FileExtensions.Txt, FileExtensions.Text, FileExtensions.Conf, FileExtensions.Def, FileExtensions.List, FileExtensions.Log, FileExtensions.In, FileExtensions.Ini};
                case Dsc:
					return new[] {FileExtensions.Dsc};
                case Rtx:
					return new[] {FileExtensions.Rtx};
                case Sgml:
                //case Sgm:
					return new[] {FileExtensions.Sgml, FileExtensions.Sgm};
                case Shex:
					return new[] {FileExtensions.Shex};
                case Slim:
                //case Slm:
					return new[] {FileExtensions.Slim, FileExtensions.Slm};
                case Spdx:
					return new[] {FileExtensions.Spdx};
                case Stylus:
                //case Styl:
					return new[] {FileExtensions.Stylus, FileExtensions.Styl};
                case Tsv:
					return new[] {FileExtensions.Tsv};
                case T:
                //case Tr:
                //case Roff:
                //case Man:
                //case Me:
                //case Ms:
					return new[] {FileExtensions.T, FileExtensions.Tr, FileExtensions.Roff, FileExtensions.Man, FileExtensions.Me, FileExtensions.Ms};
                case Ttl:
					return new[] {FileExtensions.Ttl};
                case Uri:
                //case Uris:
                //case Urls:
					return new[] {FileExtensions.Uri, FileExtensions.Uris, FileExtensions.Urls};
                case Vcard:
					return new[] {FileExtensions.Vcard};
                case Curl:
					return new[] {FileExtensions.Curl};
                case Dcurl:
					return new[] {FileExtensions.Dcurl};
                case Mcurl:
					return new[] {FileExtensions.Mcurl};
                case Scurl:
					return new[] {FileExtensions.Scurl};
                case Ged:
					return new[] {FileExtensions.Ged};
                case Fly:
					return new[] {FileExtensions.Fly};
                case Flx:
					return new[] {FileExtensions.Flx};
                case Gv:
					return new[] {FileExtensions.Gv};
                case _3dml:
					return new[] {FileExtensions._3dml};
                case Spot:
					return new[] {FileExtensions.Spot};
                case Jad:
					return new[] {FileExtensions.Jad};
                case Wml:
					return new[] {FileExtensions.Wml};
                case Wmls:
					return new[] {FileExtensions.Wmls};
                case Vtt:
					return new[] {FileExtensions.Vtt};
                case S:
                //case Asm:
					return new[] {FileExtensions.S, FileExtensions.Asm};
                case C:
                //case Cc:
                //case Cxx:
                //case Cpp:
                //case H:
                //case Hh:
                //case Dic:
					return new[] {FileExtensions.C, FileExtensions.Cc, FileExtensions.Cxx, FileExtensions.Cpp, FileExtensions.H, FileExtensions.Hh, FileExtensions.Dic};
                case Htc:
					return new[] {FileExtensions.Htc};
                case F:
                //case For:
                //case F77:
                //case F90:
					return new[] {FileExtensions.F, FileExtensions.For, FileExtensions.F77, FileExtensions.F90};
                case Hbs:
					return new[] {FileExtensions.Hbs};
                case Java:
					return new[] {FileExtensions.Java};
                case Lua:
					return new[] {FileExtensions.Lua};
                case Mkd:
					return new[] {FileExtensions.Mkd};
                case Nfo:
					return new[] {FileExtensions.Nfo};
                case Opml:
					return new[] {FileExtensions.Opml};
                case P:
                //case Pas:
					return new[] {FileExtensions.P, FileExtensions.Pas};
                case Pde:
					return new[] {FileExtensions.Pde};
                case Sass:
					return new[] {FileExtensions.Sass};
                case Scss:
					return new[] {FileExtensions.Scss};
                case Etx:
					return new[] {FileExtensions.Etx};
                case Sfv:
					return new[] {FileExtensions.Sfv};
                case Ymp:
					return new[] {FileExtensions.Ymp};
                case Uu:
					return new[] {FileExtensions.Uu};
                case Vcs:
					return new[] {FileExtensions.Vcs};
                case Vcf:
					return new[] {FileExtensions.Vcf};
                case Yaml:
                //case Yml:
					return new[] {FileExtensions.Yaml, FileExtensions.Yml};
                case _3gp:
					return new[] {FileExtensions._3gp};
                case _3g2:
					return new[] {FileExtensions._3g2};
                case H261:
					return new[] {FileExtensions.H261};
                case H263:
					return new[] {FileExtensions.H263};
                case H264:
					return new[] {FileExtensions.H264};
                case M4s:
					return new[] {FileExtensions.M4s};
                case Jpgv:
					return new[] {FileExtensions.Jpgv};
                case Jpgm:
					return new[] {FileExtensions.Jpgm};
                case Mj2:
                //case Mjp2:
					return new[] {FileExtensions.Mj2, FileExtensions.Mjp2};
                case Ts:
					return new[] {FileExtensions.Ts};
                case Mp4:
                //case Mp4v:
                //case Mpg4:
					return new[] {FileExtensions.Mp4, FileExtensions.Mp4v, FileExtensions.Mpg4};
                case Mpeg:
                //case Mpg:
                //case Mpe:
                //case M1v:
                //case M2v:
					return new[] {FileExtensions.Mpeg, FileExtensions.Mpg, FileExtensions.Mpe, FileExtensions.M1v, FileExtensions.M2v};
                case Ogv:
					return new[] {FileExtensions.Ogv};
                case Qt:
                //case Mov:
					return new[] {FileExtensions.Qt, FileExtensions.Mov};
                case Uvh:
                //case Uvvh:
					return new[] {FileExtensions.Uvh, FileExtensions.Uvvh};
                case Uvm:
                //case Uvvm:
					return new[] {FileExtensions.Uvm, FileExtensions.Uvvm};
                case Uvp:
                //case Uvvp:
					return new[] {FileExtensions.Uvp, FileExtensions.Uvvp};
                case Uvs:
                //case Uvvs:
					return new[] {FileExtensions.Uvs, FileExtensions.Uvvs};
                case Uvv:
                //case Uvvv:
					return new[] {FileExtensions.Uvv, FileExtensions.Uvvv};
                case Dvb:
					return new[] {FileExtensions.Dvb};
                case Fvt:
					return new[] {FileExtensions.Fvt};
                case Mxu:
                //case M4u:
					return new[] {FileExtensions.Mxu, FileExtensions.M4u};
                case Pyv:
					return new[] {FileExtensions.Pyv};
                case Uvu:
                //case Uvvu:
					return new[] {FileExtensions.Uvu, FileExtensions.Uvvu};
                case Viv:
					return new[] {FileExtensions.Viv};
                case Webm:
					return new[] {FileExtensions.Webm};
                case F4v:
					return new[] {FileExtensions.F4v};
                case Fli:
					return new[] {FileExtensions.Fli};
                case Flv:
					return new[] {FileExtensions.Flv};
                case M4v:
					return new[] {FileExtensions.M4v};
                case Mkv:
                //case Mk3d:
                //case Mks:
					return new[] {FileExtensions.Mkv, FileExtensions.Mk3d, FileExtensions.Mks};
                case Mng:
					return new[] {FileExtensions.Mng};
                case Asf:
                //case Asx:
					return new[] {FileExtensions.Asf, FileExtensions.Asx};
                case Vob:
					return new[] {FileExtensions.Vob};
                case Wm:
					return new[] {FileExtensions.Wm};
                case Wmv:
					return new[] {FileExtensions.Wmv};
                case Wmx:
					return new[] {FileExtensions.Wmx};
                case Wvx:
					return new[] {FileExtensions.Wvx};
                case Avi:
					return new[] {FileExtensions.Avi};
                case Movie:
					return new[] {FileExtensions.Movie};
                case Smv:
					return new[] {FileExtensions.Smv};
                case Ice:
					return new[] {FileExtensions.Ice};
                default: 
                    return null;
            }
        }
    }
}