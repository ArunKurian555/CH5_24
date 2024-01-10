using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
{
    public interface ILoads
    {
        object UserObject { get; set; }

        event EventHandler<UIEventArgs> Press0;
        event EventHandler<UIEventArgs> Press1;
        event EventHandler<UIEventArgs> Press2;
        event EventHandler<UIEventArgs> Press3;
        event EventHandler<UIEventArgs> Press4;
        event EventHandler<UIEventArgs> Press5;
        event EventHandler<UIEventArgs> Press6;
        event EventHandler<UIEventArgs> Press7;
        event EventHandler<UIEventArgs> Press8;
        event EventHandler<UIEventArgs> Press9;
        event EventHandler<UIEventArgs> Press10;
        event EventHandler<UIEventArgs> Press11;
        event EventHandler<UIEventArgs> Press12;
        event EventHandler<UIEventArgs> Press13;
        event EventHandler<UIEventArgs> Press14;
        event EventHandler<UIEventArgs> Press15;
        event EventHandler<UIEventArgs> Press16;
        event EventHandler<UIEventArgs> Press17;
        event EventHandler<UIEventArgs> Press18;
        event EventHandler<UIEventArgs> Press19;
        event EventHandler<UIEventArgs> Press20;
        event EventHandler<UIEventArgs> Press21;
        event EventHandler<UIEventArgs> Press22;
        event EventHandler<UIEventArgs> Press23;
        event EventHandler<UIEventArgs> Press24;
        event EventHandler<UIEventArgs> Press25;
        event EventHandler<UIEventArgs> Press26;
        event EventHandler<UIEventArgs> Press27;
        event EventHandler<UIEventArgs> Press28;
        event EventHandler<UIEventArgs> Press29;
        event EventHandler<UIEventArgs> Press30;
        event EventHandler<UIEventArgs> Press31;
        event EventHandler<UIEventArgs> Press32;
        event EventHandler<UIEventArgs> Press33;
        event EventHandler<UIEventArgs> Press34;
        event EventHandler<UIEventArgs> Press35;
        event EventHandler<UIEventArgs> Press36;
        event EventHandler<UIEventArgs> Press37;
        event EventHandler<UIEventArgs> Press38;
        event EventHandler<UIEventArgs> Press39;
        event EventHandler<UIEventArgs> Press40;
        event EventHandler<UIEventArgs> Press41;
        event EventHandler<UIEventArgs> Press42;
        event EventHandler<UIEventArgs> Press43;
        event EventHandler<UIEventArgs> Press44;
        event EventHandler<UIEventArgs> Press45;
        event EventHandler<UIEventArgs> Press46;
        event EventHandler<UIEventArgs> Press47;
        event EventHandler<UIEventArgs> Press48;
        event EventHandler<UIEventArgs> Press49;
        event EventHandler<UIEventArgs> Press50;
        event EventHandler<UIEventArgs> Press51;
        event EventHandler<UIEventArgs> Press52;
        event EventHandler<UIEventArgs> Press53;
        event EventHandler<UIEventArgs> Press54;
        event EventHandler<UIEventArgs> Press55;
        event EventHandler<UIEventArgs> Press56;
        event EventHandler<UIEventArgs> Press57;
        event EventHandler<UIEventArgs> Press58;
        event EventHandler<UIEventArgs> Press59;
        event EventHandler<UIEventArgs> Press60;
        event EventHandler<UIEventArgs> Press61;
        event EventHandler<UIEventArgs> Press62;
        event EventHandler<UIEventArgs> Press63;
        event EventHandler<UIEventArgs> Press64;
        event EventHandler<UIEventArgs> Press65;
        event EventHandler<UIEventArgs> Press66;
        event EventHandler<UIEventArgs> Press67;
        event EventHandler<UIEventArgs> Press68;
        event EventHandler<UIEventArgs> Press69;
        event EventHandler<UIEventArgs> Press70;
        event EventHandler<UIEventArgs> Press71;
        event EventHandler<UIEventArgs> Press72;
        event EventHandler<UIEventArgs> Press73;
        event EventHandler<UIEventArgs> Press74;
        event EventHandler<UIEventArgs> Press75;
        event EventHandler<UIEventArgs> Press76;
        event EventHandler<UIEventArgs> Press77;
        event EventHandler<UIEventArgs> Press78;
        event EventHandler<UIEventArgs> Press79;
        event EventHandler<UIEventArgs> Press80;
        event EventHandler<UIEventArgs> Press81;
        event EventHandler<UIEventArgs> Press82;
        event EventHandler<UIEventArgs> Press83;
        event EventHandler<UIEventArgs> Press84;
        event EventHandler<UIEventArgs> Press85;
        event EventHandler<UIEventArgs> Press86;
        event EventHandler<UIEventArgs> Press87;
        event EventHandler<UIEventArgs> Press88;
        event EventHandler<UIEventArgs> Press89;
        event EventHandler<UIEventArgs> Press90;
        event EventHandler<UIEventArgs> Press91;
        event EventHandler<UIEventArgs> Press92;
        event EventHandler<UIEventArgs> Press93;
        event EventHandler<UIEventArgs> Press94;
        event EventHandler<UIEventArgs> Press95;
        event EventHandler<UIEventArgs> Press96;
        event EventHandler<UIEventArgs> Press97;
        event EventHandler<UIEventArgs> Press98;
        event EventHandler<UIEventArgs> Press99;
        event EventHandler<UIEventArgs> Press100;
        event EventHandler<UIEventArgs> Press101;
        event EventHandler<UIEventArgs> Press102;
        event EventHandler<UIEventArgs> Press103;
        event EventHandler<UIEventArgs> Press104;
        event EventHandler<UIEventArgs> Press105;
        event EventHandler<UIEventArgs> Press106;
        event EventHandler<UIEventArgs> Press107;
        event EventHandler<UIEventArgs> Press108;
        event EventHandler<UIEventArgs> Press109;
        event EventHandler<UIEventArgs> Press110;
        event EventHandler<UIEventArgs> Press111;
        event EventHandler<UIEventArgs> Press112;
        event EventHandler<UIEventArgs> Press113;
        event EventHandler<UIEventArgs> Press114;
        event EventHandler<UIEventArgs> Press115;
        event EventHandler<UIEventArgs> Press116;
        event EventHandler<UIEventArgs> Press117;
        event EventHandler<UIEventArgs> Press118;
        event EventHandler<UIEventArgs> Press119;
        event EventHandler<UIEventArgs> Press120;
        event EventHandler<UIEventArgs> Press121;
        event EventHandler<UIEventArgs> Press122;
        event EventHandler<UIEventArgs> Press123;
        event EventHandler<UIEventArgs> Press124;
        event EventHandler<UIEventArgs> Press125;
        event EventHandler<UIEventArgs> Press126;
        event EventHandler<UIEventArgs> Press127;
        event EventHandler<UIEventArgs> Press128;
        event EventHandler<UIEventArgs> Press129;
        event EventHandler<UIEventArgs> Press130;
        event EventHandler<UIEventArgs> Press131;
        event EventHandler<UIEventArgs> Press132;
        event EventHandler<UIEventArgs> Press133;
        event EventHandler<UIEventArgs> Press134;
        event EventHandler<UIEventArgs> Press135;
        event EventHandler<UIEventArgs> Press136;
        event EventHandler<UIEventArgs> Press137;
        event EventHandler<UIEventArgs> Press138;
        event EventHandler<UIEventArgs> Press139;
        event EventHandler<UIEventArgs> Press140;
        event EventHandler<UIEventArgs> Press141;
        event EventHandler<UIEventArgs> Press142;
        event EventHandler<UIEventArgs> Press143;
        event EventHandler<UIEventArgs> Press144;
        event EventHandler<UIEventArgs> Press145;
        event EventHandler<UIEventArgs> Press146;
        event EventHandler<UIEventArgs> Press147;
        event EventHandler<UIEventArgs> Press148;
        event EventHandler<UIEventArgs> Press149;
        event EventHandler<UIEventArgs> Press150;
        event EventHandler<UIEventArgs> Press151;
        event EventHandler<UIEventArgs> Press152;
        event EventHandler<UIEventArgs> Press153;
        event EventHandler<UIEventArgs> Press154;
        event EventHandler<UIEventArgs> Press155;
        event EventHandler<UIEventArgs> Press156;
        event EventHandler<UIEventArgs> Press157;
        event EventHandler<UIEventArgs> Press158;
        event EventHandler<UIEventArgs> Press159;
        event EventHandler<UIEventArgs> Press160;
        event EventHandler<UIEventArgs> Press161;
        event EventHandler<UIEventArgs> Press162;
        event EventHandler<UIEventArgs> Press163;
        event EventHandler<UIEventArgs> Press164;
        event EventHandler<UIEventArgs> Press165;
        event EventHandler<UIEventArgs> Press166;
        event EventHandler<UIEventArgs> Press167;
        event EventHandler<UIEventArgs> Press168;
        event EventHandler<UIEventArgs> Press169;
        event EventHandler<UIEventArgs> Press170;
        event EventHandler<UIEventArgs> Press171;
        event EventHandler<UIEventArgs> Press172;
        event EventHandler<UIEventArgs> Press173;
        event EventHandler<UIEventArgs> Press174;
        event EventHandler<UIEventArgs> Press175;
        event EventHandler<UIEventArgs> Press176;
        event EventHandler<UIEventArgs> Press177;
        event EventHandler<UIEventArgs> Press178;
        event EventHandler<UIEventArgs> Press179;
        event EventHandler<UIEventArgs> Press180;
        event EventHandler<UIEventArgs> Press181;
        event EventHandler<UIEventArgs> Press182;
        event EventHandler<UIEventArgs> Press183;
        event EventHandler<UIEventArgs> Press184;
        event EventHandler<UIEventArgs> Press185;
        event EventHandler<UIEventArgs> Press186;
        event EventHandler<UIEventArgs> Press187;
        event EventHandler<UIEventArgs> Press188;
        event EventHandler<UIEventArgs> Press190;
        event EventHandler<UIEventArgs> Press191;
        event EventHandler<UIEventArgs> Press192;
        event EventHandler<UIEventArgs> Press193;
        event EventHandler<UIEventArgs> Press194;
        event EventHandler<UIEventArgs> Press195;
        event EventHandler<UIEventArgs> Press196;
        event EventHandler<UIEventArgs> Press197;
        event EventHandler<UIEventArgs> Press198;
        event EventHandler<UIEventArgs> Press199;
        event EventHandler<UIEventArgs> Press200;
        event EventHandler<UIEventArgs> Press201;
        event EventHandler<UIEventArgs> Press202;
        event EventHandler<UIEventArgs> Press203;
        event EventHandler<UIEventArgs> Press204;
        event EventHandler<UIEventArgs> Press205;
        event EventHandler<UIEventArgs> Press206;
        event EventHandler<UIEventArgs> Press207;
        event EventHandler<UIEventArgs> Press208;
        event EventHandler<UIEventArgs> Press209;
        event EventHandler<UIEventArgs> Press210;
        event EventHandler<UIEventArgs> Press211;
        event EventHandler<UIEventArgs> Press212;
        event EventHandler<UIEventArgs> Press213;
        event EventHandler<UIEventArgs> Press214;
        event EventHandler<UIEventArgs> Press215;
        event EventHandler<UIEventArgs> Press216;
        event EventHandler<UIEventArgs> Press217;
        event EventHandler<UIEventArgs> Press218;
        event EventHandler<UIEventArgs> Press219;
        event EventHandler<UIEventArgs> Press220;
        event EventHandler<UIEventArgs> Press221;
        event EventHandler<UIEventArgs> Press222;
        event EventHandler<UIEventArgs> Press223;
        event EventHandler<UIEventArgs> Press224;
        event EventHandler<UIEventArgs> Press225;
        event EventHandler<UIEventArgs> Press226;
        event EventHandler<UIEventArgs> Press227;
        event EventHandler<UIEventArgs> Press228;
        event EventHandler<UIEventArgs> Press229;
        event EventHandler<UIEventArgs> Press230;
        event EventHandler<UIEventArgs> Press231;
        event EventHandler<UIEventArgs> Press232;
        event EventHandler<UIEventArgs> Press233;
        event EventHandler<UIEventArgs> Press234;
        event EventHandler<UIEventArgs> Press235;
        event EventHandler<UIEventArgs> Press236;
        event EventHandler<UIEventArgs> Press237;
        event EventHandler<UIEventArgs> Press238;
        event EventHandler<UIEventArgs> Press239;
        event EventHandler<UIEventArgs> Press240;
        event EventHandler<UIEventArgs> Press241;
        event EventHandler<UIEventArgs> Press242;
        event EventHandler<UIEventArgs> Press243;
        event EventHandler<UIEventArgs> Press244;
        event EventHandler<UIEventArgs> Press245;
        event EventHandler<UIEventArgs> Press246;
        event EventHandler<UIEventArgs> Press247;
        event EventHandler<UIEventArgs> Press248;
        event EventHandler<UIEventArgs> Press249;
        event EventHandler<UIEventArgs> Press250;
        event EventHandler<UIEventArgs> Press189;

        void Pressed0(LoadsBoolInputSigDelegate callback);
        void Pressed1(LoadsBoolInputSigDelegate callback);
        void Pressed2(LoadsBoolInputSigDelegate callback);
        void Pressed3(LoadsBoolInputSigDelegate callback);
        void Pressed4(LoadsBoolInputSigDelegate callback);
        void Pressed5(LoadsBoolInputSigDelegate callback);
        void Pressed6(LoadsBoolInputSigDelegate callback);
        void Pressed7(LoadsBoolInputSigDelegate callback);
        void Pressed8(LoadsBoolInputSigDelegate callback);
        void Pressed9(LoadsBoolInputSigDelegate callback);
        void Pressed10(LoadsBoolInputSigDelegate callback);
        void Pressed11(LoadsBoolInputSigDelegate callback);
        void Pressed12(LoadsBoolInputSigDelegate callback);
        void Pressed13(LoadsBoolInputSigDelegate callback);
        void Pressed14(LoadsBoolInputSigDelegate callback);
        void Pressed15(LoadsBoolInputSigDelegate callback);
        void Pressed16(LoadsBoolInputSigDelegate callback);
        void Pressed17(LoadsBoolInputSigDelegate callback);
        void Pressed18(LoadsBoolInputSigDelegate callback);
        void Pressed19(LoadsBoolInputSigDelegate callback);
        void Pressed20(LoadsBoolInputSigDelegate callback);
        void Pressed21(LoadsBoolInputSigDelegate callback);
        void Pressed22(LoadsBoolInputSigDelegate callback);
        void Pressed23(LoadsBoolInputSigDelegate callback);
        void Pressed24(LoadsBoolInputSigDelegate callback);
        void Pressed25(LoadsBoolInputSigDelegate callback);
        void Pressed26(LoadsBoolInputSigDelegate callback);
        void Pressed27(LoadsBoolInputSigDelegate callback);
        void Pressed28(LoadsBoolInputSigDelegate callback);
        void Pressed29(LoadsBoolInputSigDelegate callback);
        void Pressed30(LoadsBoolInputSigDelegate callback);
        void Pressed31(LoadsBoolInputSigDelegate callback);
        void Pressed32(LoadsBoolInputSigDelegate callback);
        void Pressed33(LoadsBoolInputSigDelegate callback);
        void Pressed34(LoadsBoolInputSigDelegate callback);
        void Pressed35(LoadsBoolInputSigDelegate callback);
        void Pressed36(LoadsBoolInputSigDelegate callback);
        void Pressed37(LoadsBoolInputSigDelegate callback);
        void Pressed38(LoadsBoolInputSigDelegate callback);
        void Pressed39(LoadsBoolInputSigDelegate callback);
        void Pressed40(LoadsBoolInputSigDelegate callback);
        void Pressed41(LoadsBoolInputSigDelegate callback);
        void Pressed42(LoadsBoolInputSigDelegate callback);
        void Pressed43(LoadsBoolInputSigDelegate callback);
        void Pressed44(LoadsBoolInputSigDelegate callback);
        void Pressed45(LoadsBoolInputSigDelegate callback);
        void Pressed46(LoadsBoolInputSigDelegate callback);
        void Pressed47(LoadsBoolInputSigDelegate callback);
        void Pressed48(LoadsBoolInputSigDelegate callback);
        void Pressed49(LoadsBoolInputSigDelegate callback);
        void Pressed50(LoadsBoolInputSigDelegate callback);
        void Pressed51(LoadsBoolInputSigDelegate callback);
        void Pressed52(LoadsBoolInputSigDelegate callback);
        void Pressed53(LoadsBoolInputSigDelegate callback);
        void Pressed54(LoadsBoolInputSigDelegate callback);
        void Pressed55(LoadsBoolInputSigDelegate callback);
        void Pressed56(LoadsBoolInputSigDelegate callback);
        void Pressed57(LoadsBoolInputSigDelegate callback);
        void Pressed58(LoadsBoolInputSigDelegate callback);
        void Pressed59(LoadsBoolInputSigDelegate callback);
        void Pressed60(LoadsBoolInputSigDelegate callback);
        void Pressed61(LoadsBoolInputSigDelegate callback);
        void Pressed62(LoadsBoolInputSigDelegate callback);
        void Pressed63(LoadsBoolInputSigDelegate callback);
        void Pressed64(LoadsBoolInputSigDelegate callback);
        void Pressed65(LoadsBoolInputSigDelegate callback);
        void Pressed66(LoadsBoolInputSigDelegate callback);
        void Pressed67(LoadsBoolInputSigDelegate callback);
        void Pressed68(LoadsBoolInputSigDelegate callback);
        void Pressed69(LoadsBoolInputSigDelegate callback);
        void Pressed70(LoadsBoolInputSigDelegate callback);
        void Pressed71(LoadsBoolInputSigDelegate callback);
        void Pressed72(LoadsBoolInputSigDelegate callback);
        void Pressed73(LoadsBoolInputSigDelegate callback);
        void Pressed74(LoadsBoolInputSigDelegate callback);
        void Pressed75(LoadsBoolInputSigDelegate callback);
        void Pressed76(LoadsBoolInputSigDelegate callback);
        void Pressed77(LoadsBoolInputSigDelegate callback);
        void Pressed78(LoadsBoolInputSigDelegate callback);
        void Pressed79(LoadsBoolInputSigDelegate callback);
        void Pressed80(LoadsBoolInputSigDelegate callback);
        void Pressed81(LoadsBoolInputSigDelegate callback);
        void Pressed82(LoadsBoolInputSigDelegate callback);
        void Pressed83(LoadsBoolInputSigDelegate callback);
        void Pressed84(LoadsBoolInputSigDelegate callback);
        void Pressed85(LoadsBoolInputSigDelegate callback);
        void Pressed86(LoadsBoolInputSigDelegate callback);
        void Pressed87(LoadsBoolInputSigDelegate callback);
        void Pressed88(LoadsBoolInputSigDelegate callback);
        void Pressed89(LoadsBoolInputSigDelegate callback);
        void Pressed90(LoadsBoolInputSigDelegate callback);
        void Pressed91(LoadsBoolInputSigDelegate callback);
        void Pressed92(LoadsBoolInputSigDelegate callback);
        void Pressed93(LoadsBoolInputSigDelegate callback);
        void Pressed94(LoadsBoolInputSigDelegate callback);
        void Pressed95(LoadsBoolInputSigDelegate callback);
        void Pressed96(LoadsBoolInputSigDelegate callback);
        void Pressed97(LoadsBoolInputSigDelegate callback);
        void Pressed98(LoadsBoolInputSigDelegate callback);
        void Pressed99(LoadsBoolInputSigDelegate callback);
        void Pressed100(LoadsBoolInputSigDelegate callback);
        void Pressed101(LoadsBoolInputSigDelegate callback);
        void Pressed102(LoadsBoolInputSigDelegate callback);
        void Pressed103(LoadsBoolInputSigDelegate callback);
        void Pressed104(LoadsBoolInputSigDelegate callback);
        void Pressed105(LoadsBoolInputSigDelegate callback);
        void Pressed106(LoadsBoolInputSigDelegate callback);
        void Pressed107(LoadsBoolInputSigDelegate callback);
        void Pressed108(LoadsBoolInputSigDelegate callback);
        void Pressed109(LoadsBoolInputSigDelegate callback);
        void Pressed110(LoadsBoolInputSigDelegate callback);
        void Pressed111(LoadsBoolInputSigDelegate callback);
        void Pressed112(LoadsBoolInputSigDelegate callback);
        void Pressed113(LoadsBoolInputSigDelegate callback);
        void Pressed114(LoadsBoolInputSigDelegate callback);
        void Pressed115(LoadsBoolInputSigDelegate callback);
        void Pressed116(LoadsBoolInputSigDelegate callback);
        void Pressed117(LoadsBoolInputSigDelegate callback);
        void Pressed118(LoadsBoolInputSigDelegate callback);
        void Pressed119(LoadsBoolInputSigDelegate callback);
        void Pressed120(LoadsBoolInputSigDelegate callback);
        void Pressed121(LoadsBoolInputSigDelegate callback);
        void Pressed122(LoadsBoolInputSigDelegate callback);
        void Pressed123(LoadsBoolInputSigDelegate callback);
        void Pressed124(LoadsBoolInputSigDelegate callback);
        void Pressed125(LoadsBoolInputSigDelegate callback);
        void Pressed126(LoadsBoolInputSigDelegate callback);
        void Pressed127(LoadsBoolInputSigDelegate callback);
        void Pressed128(LoadsBoolInputSigDelegate callback);
        void Pressed129(LoadsBoolInputSigDelegate callback);
        void Pressed130(LoadsBoolInputSigDelegate callback);
        void Pressed131(LoadsBoolInputSigDelegate callback);
        void Pressed132(LoadsBoolInputSigDelegate callback);
        void Pressed133(LoadsBoolInputSigDelegate callback);
        void Pressed134(LoadsBoolInputSigDelegate callback);
        void Pressed135(LoadsBoolInputSigDelegate callback);
        void Pressed136(LoadsBoolInputSigDelegate callback);
        void Pressed137(LoadsBoolInputSigDelegate callback);
        void Pressed138(LoadsBoolInputSigDelegate callback);
        void Pressed139(LoadsBoolInputSigDelegate callback);
        void Pressed140(LoadsBoolInputSigDelegate callback);
        void Pressed141(LoadsBoolInputSigDelegate callback);
        void Pressed142(LoadsBoolInputSigDelegate callback);
        void Pressed143(LoadsBoolInputSigDelegate callback);
        void Pressed144(LoadsBoolInputSigDelegate callback);
        void Pressed145(LoadsBoolInputSigDelegate callback);
        void Pressed146(LoadsBoolInputSigDelegate callback);
        void Pressed147(LoadsBoolInputSigDelegate callback);
        void Pressed148(LoadsBoolInputSigDelegate callback);
        void Pressed149(LoadsBoolInputSigDelegate callback);
        void Pressed150(LoadsBoolInputSigDelegate callback);
        void Pressed151(LoadsBoolInputSigDelegate callback);
        void Pressed152(LoadsBoolInputSigDelegate callback);
        void Pressed153(LoadsBoolInputSigDelegate callback);
        void Pressed154(LoadsBoolInputSigDelegate callback);
        void Pressed155(LoadsBoolInputSigDelegate callback);
        void Pressed156(LoadsBoolInputSigDelegate callback);
        void Pressed157(LoadsBoolInputSigDelegate callback);
        void Pressed158(LoadsBoolInputSigDelegate callback);
        void Pressed159(LoadsBoolInputSigDelegate callback);
        void Pressed160(LoadsBoolInputSigDelegate callback);
        void Pressed161(LoadsBoolInputSigDelegate callback);
        void Pressed162(LoadsBoolInputSigDelegate callback);
        void Pressed163(LoadsBoolInputSigDelegate callback);
        void Pressed164(LoadsBoolInputSigDelegate callback);
        void Pressed165(LoadsBoolInputSigDelegate callback);
        void Pressed166(LoadsBoolInputSigDelegate callback);
        void Pressed167(LoadsBoolInputSigDelegate callback);
        void Pressed168(LoadsBoolInputSigDelegate callback);
        void Pressed169(LoadsBoolInputSigDelegate callback);
        void Pressed170(LoadsBoolInputSigDelegate callback);
        void Pressed171(LoadsBoolInputSigDelegate callback);
        void Pressed172(LoadsBoolInputSigDelegate callback);
        void Pressed173(LoadsBoolInputSigDelegate callback);
        void Pressed174(LoadsBoolInputSigDelegate callback);
        void Pressed175(LoadsBoolInputSigDelegate callback);
        void Pressed176(LoadsBoolInputSigDelegate callback);
        void Pressed177(LoadsBoolInputSigDelegate callback);
        void Pressed178(LoadsBoolInputSigDelegate callback);
        void Pressed179(LoadsBoolInputSigDelegate callback);
        void Pressed180(LoadsBoolInputSigDelegate callback);
        void Pressed181(LoadsBoolInputSigDelegate callback);
        void Pressed182(LoadsBoolInputSigDelegate callback);
        void Pressed183(LoadsBoolInputSigDelegate callback);
        void Pressed184(LoadsBoolInputSigDelegate callback);
        void Pressed185(LoadsBoolInputSigDelegate callback);
        void Pressed186(LoadsBoolInputSigDelegate callback);
        void Pressed187(LoadsBoolInputSigDelegate callback);
        void Pressed188(LoadsBoolInputSigDelegate callback);
        void Pressed189(LoadsBoolInputSigDelegate callback);
        void Pressed190(LoadsBoolInputSigDelegate callback);
        void Pressed191(LoadsBoolInputSigDelegate callback);
        void Pressed192(LoadsBoolInputSigDelegate callback);
        void Pressed193(LoadsBoolInputSigDelegate callback);
        void Pressed194(LoadsBoolInputSigDelegate callback);
        void Pressed195(LoadsBoolInputSigDelegate callback);
        void Pressed196(LoadsBoolInputSigDelegate callback);
        void Pressed197(LoadsBoolInputSigDelegate callback);
        void Pressed198(LoadsBoolInputSigDelegate callback);
        void Pressed199(LoadsBoolInputSigDelegate callback);
        void Pressed200(LoadsBoolInputSigDelegate callback);
        void Pressed201(LoadsBoolInputSigDelegate callback);
        void Pressed202(LoadsBoolInputSigDelegate callback);
        void Pressed203(LoadsBoolInputSigDelegate callback);
        void Pressed204(LoadsBoolInputSigDelegate callback);
        void Pressed205(LoadsBoolInputSigDelegate callback);
        void Pressed206(LoadsBoolInputSigDelegate callback);
        void Pressed207(LoadsBoolInputSigDelegate callback);
        void Pressed208(LoadsBoolInputSigDelegate callback);
        void Pressed209(LoadsBoolInputSigDelegate callback);
        void Pressed210(LoadsBoolInputSigDelegate callback);
        void Pressed211(LoadsBoolInputSigDelegate callback);
        void Pressed212(LoadsBoolInputSigDelegate callback);
        void Pressed213(LoadsBoolInputSigDelegate callback);
        void Pressed214(LoadsBoolInputSigDelegate callback);
        void Pressed215(LoadsBoolInputSigDelegate callback);
        void Pressed216(LoadsBoolInputSigDelegate callback);
        void Pressed217(LoadsBoolInputSigDelegate callback);
        void Pressed218(LoadsBoolInputSigDelegate callback);
        void Pressed219(LoadsBoolInputSigDelegate callback);
        void Pressed220(LoadsBoolInputSigDelegate callback);
        void Pressed221(LoadsBoolInputSigDelegate callback);
        void Pressed222(LoadsBoolInputSigDelegate callback);
        void Pressed223(LoadsBoolInputSigDelegate callback);
        void Pressed224(LoadsBoolInputSigDelegate callback);
        void Pressed225(LoadsBoolInputSigDelegate callback);
        void Pressed226(LoadsBoolInputSigDelegate callback);
        void Pressed227(LoadsBoolInputSigDelegate callback);
        void Pressed228(LoadsBoolInputSigDelegate callback);
        void Pressed229(LoadsBoolInputSigDelegate callback);
        void Pressed230(LoadsBoolInputSigDelegate callback);
        void Pressed231(LoadsBoolInputSigDelegate callback);
        void Pressed232(LoadsBoolInputSigDelegate callback);
        void Pressed233(LoadsBoolInputSigDelegate callback);
        void Pressed234(LoadsBoolInputSigDelegate callback);
        void Pressed235(LoadsBoolInputSigDelegate callback);
        void Pressed236(LoadsBoolInputSigDelegate callback);
        void Pressed237(LoadsBoolInputSigDelegate callback);
        void Pressed238(LoadsBoolInputSigDelegate callback);
        void Pressed239(LoadsBoolInputSigDelegate callback);
        void Pressed240(LoadsBoolInputSigDelegate callback);
        void Pressed241(LoadsBoolInputSigDelegate callback);
        void Pressed242(LoadsBoolInputSigDelegate callback);
        void Pressed243(LoadsBoolInputSigDelegate callback);
        void Pressed244(LoadsBoolInputSigDelegate callback);
        void Pressed245(LoadsBoolInputSigDelegate callback);
        void Pressed246(LoadsBoolInputSigDelegate callback);
        void Pressed247(LoadsBoolInputSigDelegate callback);
        void Pressed248(LoadsBoolInputSigDelegate callback);
        void Pressed249(LoadsBoolInputSigDelegate callback);
        void Pressed250(LoadsBoolInputSigDelegate callback);

    }

    public delegate void LoadsBoolInputSigDelegate(BoolInputSig boolInputSig, ILoads loads);

    internal class Loads : ILoads, IDisposable
    {
        #region Standard CH5 Component members

        private ComponentMediator ComponentMediator { get; set; }

        public object UserObject { get; set; }

        public uint ControlJoinId { get; private set; }

        private IList<BasicTriListWithSmartObject> _devices;
        public IList<BasicTriListWithSmartObject> Devices { get { return _devices; } }

        #endregion

        #region Joins

        private static class Joins
        {
            internal static class Booleans
            {
                public const uint Press0 = 1;
                public const uint Press1 = 2;
                public const uint Press2 = 3;
                public const uint Press3 = 4;
                public const uint Press4 = 5;
                public const uint Press5 = 6;
                public const uint Press6 = 7;
                public const uint Press7 = 8;
                public const uint Press8 = 9;
                public const uint Press9 = 10;
                public const uint Press10 = 11;
                public const uint Press11 = 12;
                public const uint Press12 = 13;
                public const uint Press13 = 14;
                public const uint Press14 = 15;
                public const uint Press15 = 16;
                public const uint Press16 = 17;
                public const uint Press17 = 18;
                public const uint Press18 = 19;
                public const uint Press19 = 20;
                public const uint Press20 = 21;
                public const uint Press21 = 22;
                public const uint Press22 = 23;
                public const uint Press23 = 24;
                public const uint Press24 = 25;
                public const uint Press25 = 26;
                public const uint Press26 = 27;
                public const uint Press27 = 28;
                public const uint Press28 = 29;
                public const uint Press29 = 30;
                public const uint Press30 = 31;
                public const uint Press31 = 32;
                public const uint Press32 = 33;
                public const uint Press33 = 34;
                public const uint Press34 = 35;
                public const uint Press35 = 36;
                public const uint Press36 = 37;
                public const uint Press37 = 38;
                public const uint Press38 = 39;
                public const uint Press39 = 40;
                public const uint Press40 = 41;
                public const uint Press41 = 42;
                public const uint Press42 = 43;
                public const uint Press43 = 44;
                public const uint Press44 = 45;
                public const uint Press45 = 46;
                public const uint Press46 = 47;
                public const uint Press47 = 48;
                public const uint Press48 = 49;
                public const uint Press49 = 50;
                public const uint Press50 = 51;
                public const uint Press51 = 52;
                public const uint Press52 = 53;
                public const uint Press53 = 54;
                public const uint Press54 = 55;
                public const uint Press55 = 56;
                public const uint Press56 = 57;
                public const uint Press57 = 58;
                public const uint Press58 = 59;
                public const uint Press59 = 60;
                public const uint Press60 = 61;
                public const uint Press61 = 62;
                public const uint Press62 = 63;
                public const uint Press63 = 64;
                public const uint Press64 = 65;
                public const uint Press65 = 66;
                public const uint Press66 = 67;
                public const uint Press67 = 68;
                public const uint Press68 = 69;
                public const uint Press69 = 70;
                public const uint Press70 = 71;
                public const uint Press71 = 72;
                public const uint Press72 = 73;
                public const uint Press73 = 74;
                public const uint Press74 = 75;
                public const uint Press75 = 76;
                public const uint Press76 = 77;
                public const uint Press77 = 78;
                public const uint Press78 = 79;
                public const uint Press79 = 80;
                public const uint Press80 = 81;
                public const uint Press81 = 82;
                public const uint Press82 = 83;
                public const uint Press83 = 84;
                public const uint Press84 = 85;
                public const uint Press85 = 86;
                public const uint Press86 = 87;
                public const uint Press87 = 88;
                public const uint Press88 = 89;
                public const uint Press89 = 90;
                public const uint Press90 = 91;
                public const uint Press91 = 92;
                public const uint Press92 = 93;
                public const uint Press93 = 94;
                public const uint Press94 = 95;
                public const uint Press95 = 96;
                public const uint Press96 = 97;
                public const uint Press97 = 98;
                public const uint Press98 = 99;
                public const uint Press99 = 100;
                public const uint Press100 = 101;
                public const uint Press101 = 102;
                public const uint Press102 = 103;
                public const uint Press103 = 104;
                public const uint Press104 = 105;
                public const uint Press105 = 106;
                public const uint Press106 = 107;
                public const uint Press107 = 108;
                public const uint Press108 = 109;
                public const uint Press109 = 110;
                public const uint Press110 = 111;
                public const uint Press111 = 112;
                public const uint Press112 = 113;
                public const uint Press113 = 114;
                public const uint Press114 = 115;
                public const uint Press115 = 116;
                public const uint Press116 = 117;
                public const uint Press117 = 118;
                public const uint Press118 = 119;
                public const uint Press119 = 120;
                public const uint Press120 = 121;
                public const uint Press121 = 122;
                public const uint Press122 = 123;
                public const uint Press123 = 124;
                public const uint Press124 = 125;
                public const uint Press125 = 126;
                public const uint Press126 = 127;
                public const uint Press127 = 128;
                public const uint Press128 = 129;
                public const uint Press129 = 130;
                public const uint Press130 = 131;
                public const uint Press131 = 132;
                public const uint Press132 = 133;
                public const uint Press133 = 134;
                public const uint Press134 = 135;
                public const uint Press135 = 136;
                public const uint Press136 = 137;
                public const uint Press137 = 138;
                public const uint Press138 = 139;
                public const uint Press139 = 140;
                public const uint Press140 = 141;
                public const uint Press141 = 142;
                public const uint Press142 = 143;
                public const uint Press143 = 144;
                public const uint Press144 = 145;
                public const uint Press145 = 146;
                public const uint Press146 = 147;
                public const uint Press147 = 148;
                public const uint Press148 = 149;
                public const uint Press149 = 150;
                public const uint Press150 = 151;
                public const uint Press151 = 152;
                public const uint Press152 = 153;
                public const uint Press153 = 154;
                public const uint Press154 = 155;
                public const uint Press155 = 156;
                public const uint Press156 = 157;
                public const uint Press157 = 158;
                public const uint Press158 = 159;
                public const uint Press159 = 160;
                public const uint Press160 = 161;
                public const uint Press161 = 162;
                public const uint Press162 = 163;
                public const uint Press163 = 164;
                public const uint Press164 = 165;
                public const uint Press165 = 166;
                public const uint Press166 = 167;
                public const uint Press167 = 168;
                public const uint Press168 = 169;
                public const uint Press169 = 170;
                public const uint Press170 = 171;
                public const uint Press171 = 172;
                public const uint Press172 = 173;
                public const uint Press173 = 174;
                public const uint Press174 = 175;
                public const uint Press175 = 176;
                public const uint Press176 = 177;
                public const uint Press177 = 178;
                public const uint Press178 = 179;
                public const uint Press179 = 180;
                public const uint Press180 = 181;
                public const uint Press181 = 182;
                public const uint Press182 = 183;
                public const uint Press183 = 184;
                public const uint Press184 = 185;
                public const uint Press185 = 186;
                public const uint Press186 = 187;
                public const uint Press187 = 188;
                public const uint Press188 = 189;
                public const uint Press190 = 190;
                public const uint Press191 = 191;
                public const uint Press192 = 192;
                public const uint Press193 = 193;
                public const uint Press194 = 194;
                public const uint Press195 = 195;
                public const uint Press196 = 196;
                public const uint Press197 = 197;
                public const uint Press198 = 198;
                public const uint Press199 = 199;
                public const uint Press200 = 200;
                public const uint Press201 = 201;
                public const uint Press202 = 202;
                public const uint Press203 = 203;
                public const uint Press204 = 204;
                public const uint Press205 = 205;
                public const uint Press206 = 206;
                public const uint Press207 = 207;
                public const uint Press208 = 208;
                public const uint Press209 = 209;
                public const uint Press210 = 210;
                public const uint Press211 = 211;
                public const uint Press212 = 212;
                public const uint Press213 = 213;
                public const uint Press214 = 214;
                public const uint Press215 = 215;
                public const uint Press216 = 216;
                public const uint Press217 = 217;
                public const uint Press218 = 218;
                public const uint Press219 = 219;
                public const uint Press220 = 220;
                public const uint Press221 = 221;
                public const uint Press222 = 222;
                public const uint Press223 = 223;
                public const uint Press224 = 224;
                public const uint Press225 = 225;
                public const uint Press226 = 226;
                public const uint Press227 = 227;
                public const uint Press228 = 228;
                public const uint Press229 = 229;
                public const uint Press230 = 230;
                public const uint Press231 = 231;
                public const uint Press232 = 232;
                public const uint Press233 = 233;
                public const uint Press234 = 234;
                public const uint Press235 = 235;
                public const uint Press236 = 236;
                public const uint Press237 = 237;
                public const uint Press238 = 238;
                public const uint Press239 = 239;
                public const uint Press240 = 240;
                public const uint Press241 = 241;
                public const uint Press242 = 242;
                public const uint Press243 = 243;
                public const uint Press244 = 244;
                public const uint Press245 = 245;
                public const uint Press246 = 246;
                public const uint Press247 = 247;
                public const uint Press248 = 248;
                public const uint Press249 = 249;
                public const uint Press250 = 250;
                public const uint Press189 = 251;

                public const uint Pressed0 = 1;
                public const uint Pressed1 = 2;
                public const uint Pressed2 = 3;
                public const uint Pressed3 = 4;
                public const uint Pressed4 = 5;
                public const uint Pressed5 = 6;
                public const uint Pressed6 = 7;
                public const uint Pressed7 = 8;
                public const uint Pressed8 = 9;
                public const uint Pressed9 = 10;
                public const uint Pressed10 = 11;
                public const uint Pressed11 = 12;
                public const uint Pressed12 = 13;
                public const uint Pressed13 = 14;
                public const uint Pressed14 = 15;
                public const uint Pressed15 = 16;
                public const uint Pressed16 = 17;
                public const uint Pressed17 = 18;
                public const uint Pressed18 = 19;
                public const uint Pressed19 = 20;
                public const uint Pressed20 = 21;
                public const uint Pressed21 = 22;
                public const uint Pressed22 = 23;
                public const uint Pressed23 = 24;
                public const uint Pressed24 = 25;
                public const uint Pressed25 = 26;
                public const uint Pressed26 = 27;
                public const uint Pressed27 = 28;
                public const uint Pressed28 = 29;
                public const uint Pressed29 = 30;
                public const uint Pressed30 = 31;
                public const uint Pressed31 = 32;
                public const uint Pressed32 = 33;
                public const uint Pressed33 = 34;
                public const uint Pressed34 = 35;
                public const uint Pressed35 = 36;
                public const uint Pressed36 = 37;
                public const uint Pressed37 = 38;
                public const uint Pressed38 = 39;
                public const uint Pressed39 = 40;
                public const uint Pressed40 = 41;
                public const uint Pressed41 = 42;
                public const uint Pressed42 = 43;
                public const uint Pressed43 = 44;
                public const uint Pressed44 = 45;
                public const uint Pressed45 = 46;
                public const uint Pressed46 = 47;
                public const uint Pressed47 = 48;
                public const uint Pressed48 = 49;
                public const uint Pressed49 = 50;
                public const uint Pressed50 = 51;
                public const uint Pressed51 = 52;
                public const uint Pressed52 = 53;
                public const uint Pressed53 = 54;
                public const uint Pressed54 = 55;
                public const uint Pressed55 = 56;
                public const uint Pressed56 = 57;
                public const uint Pressed57 = 58;
                public const uint Pressed58 = 59;
                public const uint Pressed59 = 60;
                public const uint Pressed60 = 61;
                public const uint Pressed61 = 62;
                public const uint Pressed62 = 63;
                public const uint Pressed63 = 64;
                public const uint Pressed64 = 65;
                public const uint Pressed65 = 66;
                public const uint Pressed66 = 67;
                public const uint Pressed67 = 68;
                public const uint Pressed68 = 69;
                public const uint Pressed69 = 70;
                public const uint Pressed70 = 71;
                public const uint Pressed71 = 72;
                public const uint Pressed72 = 73;
                public const uint Pressed73 = 74;
                public const uint Pressed74 = 75;
                public const uint Pressed75 = 76;
                public const uint Pressed76 = 77;
                public const uint Pressed77 = 78;
                public const uint Pressed78 = 79;
                public const uint Pressed79 = 80;
                public const uint Pressed80 = 81;
                public const uint Pressed81 = 82;
                public const uint Pressed82 = 83;
                public const uint Pressed83 = 84;
                public const uint Pressed84 = 85;
                public const uint Pressed85 = 86;
                public const uint Pressed86 = 87;
                public const uint Pressed87 = 88;
                public const uint Pressed88 = 89;
                public const uint Pressed89 = 90;
                public const uint Pressed90 = 91;
                public const uint Pressed91 = 92;
                public const uint Pressed92 = 93;
                public const uint Pressed93 = 94;
                public const uint Pressed94 = 95;
                public const uint Pressed95 = 96;
                public const uint Pressed96 = 97;
                public const uint Pressed97 = 98;
                public const uint Pressed98 = 99;
                public const uint Pressed99 = 100;
                public const uint Pressed100 = 101;
                public const uint Pressed101 = 102;
                public const uint Pressed102 = 103;
                public const uint Pressed103 = 104;
                public const uint Pressed104 = 105;
                public const uint Pressed105 = 106;
                public const uint Pressed106 = 107;
                public const uint Pressed107 = 108;
                public const uint Pressed108 = 109;
                public const uint Pressed109 = 110;
                public const uint Pressed110 = 111;
                public const uint Pressed111 = 112;
                public const uint Pressed112 = 113;
                public const uint Pressed113 = 114;
                public const uint Pressed114 = 115;
                public const uint Pressed115 = 116;
                public const uint Pressed116 = 117;
                public const uint Pressed117 = 118;
                public const uint Pressed118 = 119;
                public const uint Pressed119 = 120;
                public const uint Pressed120 = 121;
                public const uint Pressed121 = 122;
                public const uint Pressed122 = 123;
                public const uint Pressed123 = 124;
                public const uint Pressed124 = 125;
                public const uint Pressed125 = 126;
                public const uint Pressed126 = 127;
                public const uint Pressed127 = 128;
                public const uint Pressed128 = 129;
                public const uint Pressed129 = 130;
                public const uint Pressed130 = 131;
                public const uint Pressed131 = 132;
                public const uint Pressed132 = 133;
                public const uint Pressed133 = 134;
                public const uint Pressed134 = 135;
                public const uint Pressed135 = 136;
                public const uint Pressed136 = 137;
                public const uint Pressed137 = 138;
                public const uint Pressed138 = 139;
                public const uint Pressed139 = 140;
                public const uint Pressed140 = 141;
                public const uint Pressed141 = 142;
                public const uint Pressed142 = 143;
                public const uint Pressed143 = 144;
                public const uint Pressed144 = 145;
                public const uint Pressed145 = 146;
                public const uint Pressed146 = 147;
                public const uint Pressed147 = 148;
                public const uint Pressed148 = 149;
                public const uint Pressed149 = 150;
                public const uint Pressed150 = 151;
                public const uint Pressed151 = 152;
                public const uint Pressed152 = 153;
                public const uint Pressed153 = 154;
                public const uint Pressed154 = 155;
                public const uint Pressed155 = 156;
                public const uint Pressed156 = 157;
                public const uint Pressed157 = 158;
                public const uint Pressed158 = 159;
                public const uint Pressed159 = 160;
                public const uint Pressed160 = 161;
                public const uint Pressed161 = 162;
                public const uint Pressed162 = 163;
                public const uint Pressed163 = 164;
                public const uint Pressed164 = 165;
                public const uint Pressed165 = 166;
                public const uint Pressed166 = 167;
                public const uint Pressed167 = 168;
                public const uint Pressed168 = 169;
                public const uint Pressed169 = 170;
                public const uint Pressed170 = 171;
                public const uint Pressed171 = 172;
                public const uint Pressed172 = 173;
                public const uint Pressed173 = 174;
                public const uint Pressed174 = 175;
                public const uint Pressed175 = 176;
                public const uint Pressed176 = 177;
                public const uint Pressed177 = 178;
                public const uint Pressed178 = 179;
                public const uint Pressed179 = 180;
                public const uint Pressed180 = 181;
                public const uint Pressed181 = 182;
                public const uint Pressed182 = 183;
                public const uint Pressed183 = 184;
                public const uint Pressed184 = 185;
                public const uint Pressed185 = 186;
                public const uint Pressed186 = 187;
                public const uint Pressed187 = 188;
                public const uint Pressed188 = 189;
                public const uint Pressed189 = 190;
                public const uint Pressed190 = 191;
                public const uint Pressed191 = 192;
                public const uint Pressed192 = 193;
                public const uint Pressed193 = 194;
                public const uint Pressed194 = 195;
                public const uint Pressed195 = 196;
                public const uint Pressed196 = 197;
                public const uint Pressed197 = 198;
                public const uint Pressed198 = 199;
                public const uint Pressed199 = 200;
                public const uint Pressed200 = 201;
                public const uint Pressed201 = 202;
                public const uint Pressed202 = 203;
                public const uint Pressed203 = 204;
                public const uint Pressed204 = 205;
                public const uint Pressed205 = 206;
                public const uint Pressed206 = 207;
                public const uint Pressed207 = 208;
                public const uint Pressed208 = 209;
                public const uint Pressed209 = 210;
                public const uint Pressed210 = 211;
                public const uint Pressed211 = 212;
                public const uint Pressed212 = 213;
                public const uint Pressed213 = 214;
                public const uint Pressed214 = 215;
                public const uint Pressed215 = 216;
                public const uint Pressed216 = 217;
                public const uint Pressed217 = 218;
                public const uint Pressed218 = 219;
                public const uint Pressed219 = 220;
                public const uint Pressed220 = 221;
                public const uint Pressed221 = 222;
                public const uint Pressed222 = 223;
                public const uint Pressed223 = 224;
                public const uint Pressed224 = 225;
                public const uint Pressed225 = 226;
                public const uint Pressed226 = 227;
                public const uint Pressed227 = 228;
                public const uint Pressed228 = 229;
                public const uint Pressed229 = 230;
                public const uint Pressed230 = 231;
                public const uint Pressed231 = 232;
                public const uint Pressed232 = 233;
                public const uint Pressed233 = 234;
                public const uint Pressed234 = 235;
                public const uint Pressed235 = 236;
                public const uint Pressed236 = 237;
                public const uint Pressed237 = 238;
                public const uint Pressed238 = 239;
                public const uint Pressed239 = 240;
                public const uint Pressed240 = 241;
                public const uint Pressed241 = 242;
                public const uint Pressed242 = 243;
                public const uint Pressed243 = 244;
                public const uint Pressed244 = 245;
                public const uint Pressed245 = 246;
                public const uint Pressed246 = 247;
                public const uint Pressed247 = 248;
                public const uint Pressed248 = 249;
                public const uint Pressed249 = 250;
                public const uint Pressed250 = 251;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Loads(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press0, onPress0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press1, onPress1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press2, onPress2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press3, onPress3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press4, onPress4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press5, onPress5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press6, onPress6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press7, onPress7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press8, onPress8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press9, onPress9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press10, onPress10);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press11, onPress11);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press12, onPress12);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press13, onPress13);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press14, onPress14);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press15, onPress15);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press16, onPress16);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press17, onPress17);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press18, onPress18);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press19, onPress19);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press20, onPress20);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press21, onPress21);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press22, onPress22);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press23, onPress23);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press24, onPress24);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press25, onPress25);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press26, onPress26);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press27, onPress27);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press28, onPress28);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press29, onPress29);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press30, onPress30);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press31, onPress31);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press32, onPress32);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press33, onPress33);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press34, onPress34);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press35, onPress35);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press36, onPress36);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press37, onPress37);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press38, onPress38);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press39, onPress39);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press40, onPress40);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press41, onPress41);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press42, onPress42);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press43, onPress43);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press44, onPress44);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press45, onPress45);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press46, onPress46);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press47, onPress47);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press48, onPress48);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press49, onPress49);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press50, onPress50);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press51, onPress51);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press52, onPress52);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press53, onPress53);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press54, onPress54);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press55, onPress55);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press56, onPress56);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press57, onPress57);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press58, onPress58);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press59, onPress59);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press60, onPress60);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press61, onPress61);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press62, onPress62);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press63, onPress63);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press64, onPress64);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press65, onPress65);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press66, onPress66);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press67, onPress67);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press68, onPress68);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press69, onPress69);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press70, onPress70);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press71, onPress71);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press72, onPress72);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press73, onPress73);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press74, onPress74);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press75, onPress75);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press76, onPress76);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press77, onPress77);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press78, onPress78);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press79, onPress79);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press80, onPress80);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press81, onPress81);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press82, onPress82);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press83, onPress83);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press84, onPress84);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press85, onPress85);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press86, onPress86);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press87, onPress87);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press88, onPress88);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press89, onPress89);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press90, onPress90);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press91, onPress91);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press92, onPress92);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press93, onPress93);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press94, onPress94);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press95, onPress95);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press96, onPress96);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press97, onPress97);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press98, onPress98);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press99, onPress99);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press100, onPress100);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press101, onPress101);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press102, onPress102);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press103, onPress103);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press104, onPress104);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press105, onPress105);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press106, onPress106);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press107, onPress107);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press108, onPress108);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press109, onPress109);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press110, onPress110);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press111, onPress111);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press112, onPress112);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press113, onPress113);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press114, onPress114);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press115, onPress115);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press116, onPress116);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press117, onPress117);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press118, onPress118);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press119, onPress119);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press120, onPress120);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press121, onPress121);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press122, onPress122);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press123, onPress123);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press124, onPress124);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press125, onPress125);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press126, onPress126);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press127, onPress127);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press128, onPress128);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press129, onPress129);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press130, onPress130);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press131, onPress131);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press132, onPress132);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press133, onPress133);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press134, onPress134);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press135, onPress135);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press136, onPress136);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press137, onPress137);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press138, onPress138);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press139, onPress139);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press140, onPress140);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press141, onPress141);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press142, onPress142);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press143, onPress143);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press144, onPress144);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press145, onPress145);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press146, onPress146);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press147, onPress147);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press148, onPress148);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press149, onPress149);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press150, onPress150);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press151, onPress151);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press152, onPress152);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press153, onPress153);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press154, onPress154);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press155, onPress155);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press156, onPress156);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press157, onPress157);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press158, onPress158);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press159, onPress159);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press160, onPress160);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press161, onPress161);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press162, onPress162);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press163, onPress163);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press164, onPress164);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press165, onPress165);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press166, onPress166);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press167, onPress167);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press168, onPress168);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press169, onPress169);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press170, onPress170);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press171, onPress171);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press172, onPress172);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press173, onPress173);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press174, onPress174);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press175, onPress175);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press176, onPress176);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press177, onPress177);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press178, onPress178);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press179, onPress179);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press180, onPress180);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press181, onPress181);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press182, onPress182);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press183, onPress183);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press184, onPress184);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press185, onPress185);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press186, onPress186);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press187, onPress187);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press188, onPress188);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press190, onPress190);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press191, onPress191);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press192, onPress192);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press193, onPress193);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press194, onPress194);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press195, onPress195);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press196, onPress196);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press197, onPress197);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press198, onPress198);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press199, onPress199);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press200, onPress200);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press201, onPress201);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press202, onPress202);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press203, onPress203);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press204, onPress204);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press205, onPress205);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press206, onPress206);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press207, onPress207);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press208, onPress208);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press209, onPress209);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press210, onPress210);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press211, onPress211);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press212, onPress212);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press213, onPress213);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press214, onPress214);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press215, onPress215);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press216, onPress216);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press217, onPress217);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press218, onPress218);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press219, onPress219);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press220, onPress220);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press221, onPress221);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press222, onPress222);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press223, onPress223);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press224, onPress224);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press225, onPress225);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press226, onPress226);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press227, onPress227);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press228, onPress228);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press229, onPress229);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press230, onPress230);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press231, onPress231);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press232, onPress232);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press233, onPress233);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press234, onPress234);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press235, onPress235);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press236, onPress236);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press237, onPress237);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press238, onPress238);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press239, onPress239);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press240, onPress240);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press241, onPress241);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press242, onPress242);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press243, onPress243);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press244, onPress244);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press245, onPress245);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press246, onPress246);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press247, onPress247);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press248, onPress248);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press249, onPress249);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press250, onPress250);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press189, onPress189);

        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        #endregion

        #region CH5 Contract

        public event EventHandler<UIEventArgs> Press0;
        private void onPress0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press1;
        private void onPress1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press1;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press2;
        private void onPress2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press2;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press3;
        private void onPress3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press3;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press4;
        private void onPress4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press4;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press5;
        private void onPress5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press5;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press6;
        private void onPress6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press6;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press7;
        private void onPress7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press7;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press8;
        private void onPress8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press8;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press9;
        private void onPress9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press9;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press10;
        private void onPress10(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press10;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press11;
        private void onPress11(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press11;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press12;
        private void onPress12(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press12;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press13;
        private void onPress13(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press13;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press14;
        private void onPress14(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press14;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press15;
        private void onPress15(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press15;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press16;
        private void onPress16(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press16;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press17;
        private void onPress17(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press17;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press18;
        private void onPress18(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press18;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press19;
        private void onPress19(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press19;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press20;
        private void onPress20(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press20;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press21;
        private void onPress21(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press21;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press22;
        private void onPress22(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press22;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press23;
        private void onPress23(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press23;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press24;
        private void onPress24(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press24;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press25;
        private void onPress25(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press25;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press26;
        private void onPress26(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press26;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press27;
        private void onPress27(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press27;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press28;
        private void onPress28(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press28;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press29;
        private void onPress29(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press29;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press30;
        private void onPress30(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press30;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press31;
        private void onPress31(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press31;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press32;
        private void onPress32(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press32;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press33;
        private void onPress33(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press33;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press34;
        private void onPress34(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press34;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press35;
        private void onPress35(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press35;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press36;
        private void onPress36(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press36;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press37;
        private void onPress37(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press37;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press38;
        private void onPress38(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press38;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press39;
        private void onPress39(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press39;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press40;
        private void onPress40(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press40;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press41;
        private void onPress41(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press41;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press42;
        private void onPress42(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press42;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press43;
        private void onPress43(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press43;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press44;
        private void onPress44(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press44;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press45;
        private void onPress45(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press45;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press46;
        private void onPress46(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press46;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press47;
        private void onPress47(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press47;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press48;
        private void onPress48(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press48;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press49;
        private void onPress49(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press49;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press50;
        private void onPress50(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press50;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press51;
        private void onPress51(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press51;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press52;
        private void onPress52(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press52;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press53;
        private void onPress53(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press53;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press54;
        private void onPress54(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press54;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press55;
        private void onPress55(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press55;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press56;
        private void onPress56(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press56;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press57;
        private void onPress57(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press57;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press58;
        private void onPress58(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press58;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press59;
        private void onPress59(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press59;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press60;
        private void onPress60(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press60;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press61;
        private void onPress61(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press61;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press62;
        private void onPress62(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press62;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press63;
        private void onPress63(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press63;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press64;
        private void onPress64(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press64;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press65;
        private void onPress65(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press65;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press66;
        private void onPress66(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press66;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press67;
        private void onPress67(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press67;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press68;
        private void onPress68(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press68;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press69;
        private void onPress69(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press69;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press70;
        private void onPress70(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press70;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press71;
        private void onPress71(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press71;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press72;
        private void onPress72(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press72;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press73;
        private void onPress73(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press73;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press74;
        private void onPress74(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press74;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press75;
        private void onPress75(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press75;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press76;
        private void onPress76(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press76;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press77;
        private void onPress77(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press77;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press78;
        private void onPress78(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press78;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press79;
        private void onPress79(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press79;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press80;
        private void onPress80(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press80;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press81;
        private void onPress81(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press81;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press82;
        private void onPress82(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press82;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press83;
        private void onPress83(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press83;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press84;
        private void onPress84(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press84;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press85;
        private void onPress85(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press85;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press86;
        private void onPress86(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press86;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press87;
        private void onPress87(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press87;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press88;
        private void onPress88(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press88;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press89;
        private void onPress89(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press89;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press90;
        private void onPress90(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press90;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press91;
        private void onPress91(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press91;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press92;
        private void onPress92(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press92;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press93;
        private void onPress93(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press93;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press94;
        private void onPress94(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press94;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press95;
        private void onPress95(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press95;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press96;
        private void onPress96(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press96;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press97;
        private void onPress97(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press97;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press98;
        private void onPress98(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press98;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press99;
        private void onPress99(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press99;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press100;
        private void onPress100(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press100;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press101;
        private void onPress101(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press101;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press102;
        private void onPress102(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press102;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press103;
        private void onPress103(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press103;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press104;
        private void onPress104(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press104;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press105;
        private void onPress105(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press105;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press106;
        private void onPress106(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press106;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press107;
        private void onPress107(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press107;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press108;
        private void onPress108(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press108;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press109;
        private void onPress109(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press109;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press110;
        private void onPress110(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press110;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press111;
        private void onPress111(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press111;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press112;
        private void onPress112(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press112;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press113;
        private void onPress113(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press113;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press114;
        private void onPress114(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press114;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press115;
        private void onPress115(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press115;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press116;
        private void onPress116(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press116;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press117;
        private void onPress117(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press117;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press118;
        private void onPress118(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press118;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press119;
        private void onPress119(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press119;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press120;
        private void onPress120(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press120;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press121;
        private void onPress121(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press121;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press122;
        private void onPress122(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press122;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press123;
        private void onPress123(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press123;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press124;
        private void onPress124(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press124;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press125;
        private void onPress125(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press125;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press126;
        private void onPress126(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press126;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press127;
        private void onPress127(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press127;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press128;
        private void onPress128(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press128;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press129;
        private void onPress129(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press129;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press130;
        private void onPress130(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press130;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press131;
        private void onPress131(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press131;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press132;
        private void onPress132(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press132;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press133;
        private void onPress133(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press133;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press134;
        private void onPress134(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press134;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press135;
        private void onPress135(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press135;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press136;
        private void onPress136(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press136;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press137;
        private void onPress137(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press137;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press138;
        private void onPress138(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press138;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press139;
        private void onPress139(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press139;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press140;
        private void onPress140(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press140;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press141;
        private void onPress141(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press141;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press142;
        private void onPress142(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press142;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press143;
        private void onPress143(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press143;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press144;
        private void onPress144(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press144;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press145;
        private void onPress145(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press145;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press146;
        private void onPress146(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press146;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press147;
        private void onPress147(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press147;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press148;
        private void onPress148(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press148;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press149;
        private void onPress149(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press149;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press150;
        private void onPress150(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press150;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press151;
        private void onPress151(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press151;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press152;
        private void onPress152(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press152;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press153;
        private void onPress153(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press153;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press154;
        private void onPress154(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press154;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press155;
        private void onPress155(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press155;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press156;
        private void onPress156(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press156;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press157;
        private void onPress157(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press157;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press158;
        private void onPress158(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press158;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press159;
        private void onPress159(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press159;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press160;
        private void onPress160(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press160;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press161;
        private void onPress161(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press161;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press162;
        private void onPress162(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press162;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press163;
        private void onPress163(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press163;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press164;
        private void onPress164(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press164;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press165;
        private void onPress165(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press165;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press166;
        private void onPress166(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press166;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press167;
        private void onPress167(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press167;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press168;
        private void onPress168(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press168;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press169;
        private void onPress169(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press169;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press170;
        private void onPress170(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press170;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press171;
        private void onPress171(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press171;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press172;
        private void onPress172(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press172;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press173;
        private void onPress173(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press173;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press174;
        private void onPress174(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press174;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press175;
        private void onPress175(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press175;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press176;
        private void onPress176(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press176;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press177;
        private void onPress177(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press177;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press178;
        private void onPress178(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press178;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press179;
        private void onPress179(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press179;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press180;
        private void onPress180(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press180;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press181;
        private void onPress181(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press181;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press182;
        private void onPress182(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press182;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press183;
        private void onPress183(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press183;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press184;
        private void onPress184(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press184;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press185;
        private void onPress185(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press185;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press186;
        private void onPress186(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press186;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press187;
        private void onPress187(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press187;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press188;
        private void onPress188(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press188;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press190;
        private void onPress190(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press190;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press191;
        private void onPress191(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press191;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press192;
        private void onPress192(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press192;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press193;
        private void onPress193(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press193;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press194;
        private void onPress194(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press194;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press195;
        private void onPress195(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press195;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press196;
        private void onPress196(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press196;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press197;
        private void onPress197(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press197;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press198;
        private void onPress198(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press198;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press199;
        private void onPress199(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press199;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press200;
        private void onPress200(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press200;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press201;
        private void onPress201(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press201;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press202;
        private void onPress202(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press202;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press203;
        private void onPress203(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press203;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press204;
        private void onPress204(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press204;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press205;
        private void onPress205(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press205;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press206;
        private void onPress206(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press206;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press207;
        private void onPress207(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press207;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press208;
        private void onPress208(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press208;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press209;
        private void onPress209(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press209;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press210;
        private void onPress210(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press210;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press211;
        private void onPress211(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press211;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press212;
        private void onPress212(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press212;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press213;
        private void onPress213(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press213;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press214;
        private void onPress214(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press214;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press215;
        private void onPress215(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press215;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press216;
        private void onPress216(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press216;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press217;
        private void onPress217(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press217;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press218;
        private void onPress218(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press218;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press219;
        private void onPress219(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press219;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press220;
        private void onPress220(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press220;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press221;
        private void onPress221(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press221;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press222;
        private void onPress222(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press222;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press223;
        private void onPress223(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press223;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press224;
        private void onPress224(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press224;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press225;
        private void onPress225(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press225;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press226;
        private void onPress226(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press226;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press227;
        private void onPress227(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press227;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press228;
        private void onPress228(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press228;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press229;
        private void onPress229(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press229;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press230;
        private void onPress230(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press230;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press231;
        private void onPress231(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press231;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press232;
        private void onPress232(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press232;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press233;
        private void onPress233(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press233;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press234;
        private void onPress234(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press234;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press235;
        private void onPress235(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press235;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press236;
        private void onPress236(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press236;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press237;
        private void onPress237(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press237;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press238;
        private void onPress238(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press238;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press239;
        private void onPress239(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press239;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press240;
        private void onPress240(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press240;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press241;
        private void onPress241(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press241;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press242;
        private void onPress242(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press242;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press243;
        private void onPress243(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press243;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press244;
        private void onPress244(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press244;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press245;
        private void onPress245(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press245;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press246;
        private void onPress246(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press246;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press247;
        private void onPress247(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press247;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press248;
        private void onPress248(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press248;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press249;
        private void onPress249(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press249;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press250;
        private void onPress250(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press250;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Press189;
        private void onPress189(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press189;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void Pressed0(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed0], this);
            }
        }

        public void Pressed1(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed1], this);
            }
        }

        public void Pressed2(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed2], this);
            }
        }

        public void Pressed3(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed3], this);
            }
        }

        public void Pressed4(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed4], this);
            }
        }

        public void Pressed5(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed5], this);
            }
        }

        public void Pressed6(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed6], this);
            }
        }

        public void Pressed7(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed7], this);
            }
        }

        public void Pressed8(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed8], this);
            }
        }

        public void Pressed9(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed9], this);
            }
        }

        public void Pressed10(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed10], this);
            }
        }

        public void Pressed11(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed11], this);
            }
        }

        public void Pressed12(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed12], this);
            }
        }

        public void Pressed13(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed13], this);
            }
        }

        public void Pressed14(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed14], this);
            }
        }

        public void Pressed15(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed15], this);
            }
        }

        public void Pressed16(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed16], this);
            }
        }

        public void Pressed17(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed17], this);
            }
        }

        public void Pressed18(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed18], this);
            }
        }

        public void Pressed19(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed19], this);
            }
        }

        public void Pressed20(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed20], this);
            }
        }

        public void Pressed21(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed21], this);
            }
        }

        public void Pressed22(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed22], this);
            }
        }

        public void Pressed23(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed23], this);
            }
        }

        public void Pressed24(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed24], this);
            }
        }

        public void Pressed25(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed25], this);
            }
        }

        public void Pressed26(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed26], this);
            }
        }

        public void Pressed27(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed27], this);
            }
        }

        public void Pressed28(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed28], this);
            }
        }

        public void Pressed29(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed29], this);
            }
        }

        public void Pressed30(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed30], this);
            }
        }

        public void Pressed31(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed31], this);
            }
        }

        public void Pressed32(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed32], this);
            }
        }

        public void Pressed33(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed33], this);
            }
        }

        public void Pressed34(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed34], this);
            }
        }

        public void Pressed35(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed35], this);
            }
        }

        public void Pressed36(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed36], this);
            }
        }

        public void Pressed37(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed37], this);
            }
        }

        public void Pressed38(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed38], this);
            }
        }

        public void Pressed39(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed39], this);
            }
        }

        public void Pressed40(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed40], this);
            }
        }

        public void Pressed41(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed41], this);
            }
        }

        public void Pressed42(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed42], this);
            }
        }

        public void Pressed43(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed43], this);
            }
        }

        public void Pressed44(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed44], this);
            }
        }

        public void Pressed45(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed45], this);
            }
        }

        public void Pressed46(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed46], this);
            }
        }

        public void Pressed47(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed47], this);
            }
        }

        public void Pressed48(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed48], this);
            }
        }

        public void Pressed49(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed49], this);
            }
        }

        public void Pressed50(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed50], this);
            }
        }

        public void Pressed51(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed51], this);
            }
        }

        public void Pressed52(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed52], this);
            }
        }

        public void Pressed53(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed53], this);
            }
        }

        public void Pressed54(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed54], this);
            }
        }

        public void Pressed55(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed55], this);
            }
        }

        public void Pressed56(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed56], this);
            }
        }

        public void Pressed57(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed57], this);
            }
        }

        public void Pressed58(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed58], this);
            }
        }

        public void Pressed59(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed59], this);
            }
        }

        public void Pressed60(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed60], this);
            }
        }

        public void Pressed61(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed61], this);
            }
        }

        public void Pressed62(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed62], this);
            }
        }

        public void Pressed63(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed63], this);
            }
        }

        public void Pressed64(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed64], this);
            }
        }

        public void Pressed65(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed65], this);
            }
        }

        public void Pressed66(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed66], this);
            }
        }

        public void Pressed67(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed67], this);
            }
        }

        public void Pressed68(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed68], this);
            }
        }

        public void Pressed69(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed69], this);
            }
        }

        public void Pressed70(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed70], this);
            }
        }

        public void Pressed71(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed71], this);
            }
        }

        public void Pressed72(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed72], this);
            }
        }

        public void Pressed73(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed73], this);
            }
        }

        public void Pressed74(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed74], this);
            }
        }

        public void Pressed75(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed75], this);
            }
        }

        public void Pressed76(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed76], this);
            }
        }

        public void Pressed77(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed77], this);
            }
        }

        public void Pressed78(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed78], this);
            }
        }

        public void Pressed79(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed79], this);
            }
        }

        public void Pressed80(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed80], this);
            }
        }

        public void Pressed81(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed81], this);
            }
        }

        public void Pressed82(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed82], this);
            }
        }

        public void Pressed83(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed83], this);
            }
        }

        public void Pressed84(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed84], this);
            }
        }

        public void Pressed85(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed85], this);
            }
        }

        public void Pressed86(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed86], this);
            }
        }

        public void Pressed87(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed87], this);
            }
        }

        public void Pressed88(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed88], this);
            }
        }

        public void Pressed89(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed89], this);
            }
        }

        public void Pressed90(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed90], this);
            }
        }

        public void Pressed91(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed91], this);
            }
        }

        public void Pressed92(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed92], this);
            }
        }

        public void Pressed93(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed93], this);
            }
        }

        public void Pressed94(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed94], this);
            }
        }

        public void Pressed95(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed95], this);
            }
        }

        public void Pressed96(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed96], this);
            }
        }

        public void Pressed97(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed97], this);
            }
        }

        public void Pressed98(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed98], this);
            }
        }

        public void Pressed99(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed99], this);
            }
        }

        public void Pressed100(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed100], this);
            }
        }

        public void Pressed101(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed101], this);
            }
        }

        public void Pressed102(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed102], this);
            }
        }

        public void Pressed103(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed103], this);
            }
        }

        public void Pressed104(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed104], this);
            }
        }

        public void Pressed105(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed105], this);
            }
        }

        public void Pressed106(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed106], this);
            }
        }

        public void Pressed107(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed107], this);
            }
        }

        public void Pressed108(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed108], this);
            }
        }

        public void Pressed109(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed109], this);
            }
        }

        public void Pressed110(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed110], this);
            }
        }

        public void Pressed111(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed111], this);
            }
        }

        public void Pressed112(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed112], this);
            }
        }

        public void Pressed113(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed113], this);
            }
        }

        public void Pressed114(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed114], this);
            }
        }

        public void Pressed115(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed115], this);
            }
        }

        public void Pressed116(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed116], this);
            }
        }

        public void Pressed117(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed117], this);
            }
        }

        public void Pressed118(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed118], this);
            }
        }

        public void Pressed119(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed119], this);
            }
        }

        public void Pressed120(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed120], this);
            }
        }

        public void Pressed121(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed121], this);
            }
        }

        public void Pressed122(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed122], this);
            }
        }

        public void Pressed123(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed123], this);
            }
        }

        public void Pressed124(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed124], this);
            }
        }

        public void Pressed125(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed125], this);
            }
        }

        public void Pressed126(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed126], this);
            }
        }

        public void Pressed127(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed127], this);
            }
        }

        public void Pressed128(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed128], this);
            }
        }

        public void Pressed129(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed129], this);
            }
        }

        public void Pressed130(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed130], this);
            }
        }

        public void Pressed131(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed131], this);
            }
        }

        public void Pressed132(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed132], this);
            }
        }

        public void Pressed133(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed133], this);
            }
        }

        public void Pressed134(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed134], this);
            }
        }

        public void Pressed135(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed135], this);
            }
        }

        public void Pressed136(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed136], this);
            }
        }

        public void Pressed137(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed137], this);
            }
        }

        public void Pressed138(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed138], this);
            }
        }

        public void Pressed139(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed139], this);
            }
        }

        public void Pressed140(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed140], this);
            }
        }

        public void Pressed141(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed141], this);
            }
        }

        public void Pressed142(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed142], this);
            }
        }

        public void Pressed143(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed143], this);
            }
        }

        public void Pressed144(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed144], this);
            }
        }

        public void Pressed145(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed145], this);
            }
        }

        public void Pressed146(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed146], this);
            }
        }

        public void Pressed147(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed147], this);
            }
        }

        public void Pressed148(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed148], this);
            }
        }

        public void Pressed149(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed149], this);
            }
        }

        public void Pressed150(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed150], this);
            }
        }

        public void Pressed151(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed151], this);
            }
        }

        public void Pressed152(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed152], this);
            }
        }

        public void Pressed153(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed153], this);
            }
        }

        public void Pressed154(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed154], this);
            }
        }

        public void Pressed155(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed155], this);
            }
        }

        public void Pressed156(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed156], this);
            }
        }

        public void Pressed157(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed157], this);
            }
        }

        public void Pressed158(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed158], this);
            }
        }

        public void Pressed159(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed159], this);
            }
        }

        public void Pressed160(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed160], this);
            }
        }

        public void Pressed161(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed161], this);
            }
        }

        public void Pressed162(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed162], this);
            }
        }

        public void Pressed163(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed163], this);
            }
        }

        public void Pressed164(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed164], this);
            }
        }

        public void Pressed165(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed165], this);
            }
        }

        public void Pressed166(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed166], this);
            }
        }

        public void Pressed167(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed167], this);
            }
        }

        public void Pressed168(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed168], this);
            }
        }

        public void Pressed169(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed169], this);
            }
        }

        public void Pressed170(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed170], this);
            }
        }

        public void Pressed171(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed171], this);
            }
        }

        public void Pressed172(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed172], this);
            }
        }

        public void Pressed173(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed173], this);
            }
        }

        public void Pressed174(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed174], this);
            }
        }

        public void Pressed175(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed175], this);
            }
        }

        public void Pressed176(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed176], this);
            }
        }

        public void Pressed177(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed177], this);
            }
        }

        public void Pressed178(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed178], this);
            }
        }

        public void Pressed179(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed179], this);
            }
        }

        public void Pressed180(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed180], this);
            }
        }

        public void Pressed181(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed181], this);
            }
        }

        public void Pressed182(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed182], this);
            }
        }

        public void Pressed183(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed183], this);
            }
        }

        public void Pressed184(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed184], this);
            }
        }

        public void Pressed185(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed185], this);
            }
        }

        public void Pressed186(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed186], this);
            }
        }

        public void Pressed187(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed187], this);
            }
        }

        public void Pressed188(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed188], this);
            }
        }

        public void Pressed189(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed189], this);
            }
        }

        public void Pressed190(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed190], this);
            }
        }

        public void Pressed191(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed191], this);
            }
        }

        public void Pressed192(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed192], this);
            }
        }

        public void Pressed193(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed193], this);
            }
        }

        public void Pressed194(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed194], this);
            }
        }

        public void Pressed195(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed195], this);
            }
        }

        public void Pressed196(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed196], this);
            }
        }

        public void Pressed197(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed197], this);
            }
        }

        public void Pressed198(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed198], this);
            }
        }

        public void Pressed199(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed199], this);
            }
        }

        public void Pressed200(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed200], this);
            }
        }

        public void Pressed201(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed201], this);
            }
        }

        public void Pressed202(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed202], this);
            }
        }

        public void Pressed203(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed203], this);
            }
        }

        public void Pressed204(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed204], this);
            }
        }

        public void Pressed205(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed205], this);
            }
        }

        public void Pressed206(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed206], this);
            }
        }

        public void Pressed207(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed207], this);
            }
        }

        public void Pressed208(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed208], this);
            }
        }

        public void Pressed209(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed209], this);
            }
        }

        public void Pressed210(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed210], this);
            }
        }

        public void Pressed211(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed211], this);
            }
        }

        public void Pressed212(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed212], this);
            }
        }

        public void Pressed213(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed213], this);
            }
        }

        public void Pressed214(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed214], this);
            }
        }

        public void Pressed215(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed215], this);
            }
        }

        public void Pressed216(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed216], this);
            }
        }

        public void Pressed217(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed217], this);
            }
        }

        public void Pressed218(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed218], this);
            }
        }

        public void Pressed219(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed219], this);
            }
        }

        public void Pressed220(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed220], this);
            }
        }

        public void Pressed221(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed221], this);
            }
        }

        public void Pressed222(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed222], this);
            }
        }

        public void Pressed223(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed223], this);
            }
        }

        public void Pressed224(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed224], this);
            }
        }

        public void Pressed225(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed225], this);
            }
        }

        public void Pressed226(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed226], this);
            }
        }

        public void Pressed227(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed227], this);
            }
        }

        public void Pressed228(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed228], this);
            }
        }

        public void Pressed229(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed229], this);
            }
        }

        public void Pressed230(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed230], this);
            }
        }

        public void Pressed231(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed231], this);
            }
        }

        public void Pressed232(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed232], this);
            }
        }

        public void Pressed233(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed233], this);
            }
        }

        public void Pressed234(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed234], this);
            }
        }

        public void Pressed235(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed235], this);
            }
        }

        public void Pressed236(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed236], this);
            }
        }

        public void Pressed237(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed237], this);
            }
        }

        public void Pressed238(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed238], this);
            }
        }

        public void Pressed239(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed239], this);
            }
        }

        public void Pressed240(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed240], this);
            }
        }

        public void Pressed241(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed241], this);
            }
        }

        public void Pressed242(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed242], this);
            }
        }

        public void Pressed243(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed243], this);
            }
        }

        public void Pressed244(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed244], this);
            }
        }

        public void Pressed245(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed245], this);
            }
        }

        public void Pressed246(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed246], this);
            }
        }

        public void Pressed247(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed247], this);
            }
        }

        public void Pressed248(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed248], this);
            }
        }

        public void Pressed249(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed249], this);
            }
        }

        public void Pressed250(LoadsBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed250], this);
            }
        }

        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Loads", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Press0 = null;
            Press1 = null;
            Press2 = null;
            Press3 = null;
            Press4 = null;
            Press5 = null;
            Press6 = null;
            Press7 = null;
            Press8 = null;
            Press9 = null;
            Press10 = null;
            Press11 = null;
            Press12 = null;
            Press13 = null;
            Press14 = null;
            Press15 = null;
            Press16 = null;
            Press17 = null;
            Press18 = null;
            Press19 = null;
            Press20 = null;
            Press21 = null;
            Press22 = null;
            Press23 = null;
            Press24 = null;
            Press25 = null;
            Press26 = null;
            Press27 = null;
            Press28 = null;
            Press29 = null;
            Press30 = null;
            Press31 = null;
            Press32 = null;
            Press33 = null;
            Press34 = null;
            Press35 = null;
            Press36 = null;
            Press37 = null;
            Press38 = null;
            Press39 = null;
            Press40 = null;
            Press41 = null;
            Press42 = null;
            Press43 = null;
            Press44 = null;
            Press45 = null;
            Press46 = null;
            Press47 = null;
            Press48 = null;
            Press49 = null;
            Press50 = null;
            Press51 = null;
            Press52 = null;
            Press53 = null;
            Press54 = null;
            Press55 = null;
            Press56 = null;
            Press57 = null;
            Press58 = null;
            Press59 = null;
            Press60 = null;
            Press61 = null;
            Press62 = null;
            Press63 = null;
            Press64 = null;
            Press65 = null;
            Press66 = null;
            Press67 = null;
            Press68 = null;
            Press69 = null;
            Press70 = null;
            Press71 = null;
            Press72 = null;
            Press73 = null;
            Press74 = null;
            Press75 = null;
            Press76 = null;
            Press77 = null;
            Press78 = null;
            Press79 = null;
            Press80 = null;
            Press81 = null;
            Press82 = null;
            Press83 = null;
            Press84 = null;
            Press85 = null;
            Press86 = null;
            Press87 = null;
            Press88 = null;
            Press89 = null;
            Press90 = null;
            Press91 = null;
            Press92 = null;
            Press93 = null;
            Press94 = null;
            Press95 = null;
            Press96 = null;
            Press97 = null;
            Press98 = null;
            Press99 = null;
            Press100 = null;
            Press101 = null;
            Press102 = null;
            Press103 = null;
            Press104 = null;
            Press105 = null;
            Press106 = null;
            Press107 = null;
            Press108 = null;
            Press109 = null;
            Press110 = null;
            Press111 = null;
            Press112 = null;
            Press113 = null;
            Press114 = null;
            Press115 = null;
            Press116 = null;
            Press117 = null;
            Press118 = null;
            Press119 = null;
            Press120 = null;
            Press121 = null;
            Press122 = null;
            Press123 = null;
            Press124 = null;
            Press125 = null;
            Press126 = null;
            Press127 = null;
            Press128 = null;
            Press129 = null;
            Press130 = null;
            Press131 = null;
            Press132 = null;
            Press133 = null;
            Press134 = null;
            Press135 = null;
            Press136 = null;
            Press137 = null;
            Press138 = null;
            Press139 = null;
            Press140 = null;
            Press141 = null;
            Press142 = null;
            Press143 = null;
            Press144 = null;
            Press145 = null;
            Press146 = null;
            Press147 = null;
            Press148 = null;
            Press149 = null;
            Press150 = null;
            Press151 = null;
            Press152 = null;
            Press153 = null;
            Press154 = null;
            Press155 = null;
            Press156 = null;
            Press157 = null;
            Press158 = null;
            Press159 = null;
            Press160 = null;
            Press161 = null;
            Press162 = null;
            Press163 = null;
            Press164 = null;
            Press165 = null;
            Press166 = null;
            Press167 = null;
            Press168 = null;
            Press169 = null;
            Press170 = null;
            Press171 = null;
            Press172 = null;
            Press173 = null;
            Press174 = null;
            Press175 = null;
            Press176 = null;
            Press177 = null;
            Press178 = null;
            Press179 = null;
            Press180 = null;
            Press181 = null;
            Press182 = null;
            Press183 = null;
            Press184 = null;
            Press185 = null;
            Press186 = null;
            Press187 = null;
            Press188 = null;
            Press190 = null;
            Press191 = null;
            Press192 = null;
            Press193 = null;
            Press194 = null;
            Press195 = null;
            Press196 = null;
            Press197 = null;
            Press198 = null;
            Press199 = null;
            Press200 = null;
            Press201 = null;
            Press202 = null;
            Press203 = null;
            Press204 = null;
            Press205 = null;
            Press206 = null;
            Press207 = null;
            Press208 = null;
            Press209 = null;
            Press210 = null;
            Press211 = null;
            Press212 = null;
            Press213 = null;
            Press214 = null;
            Press215 = null;
            Press216 = null;
            Press217 = null;
            Press218 = null;
            Press219 = null;
            Press220 = null;
            Press221 = null;
            Press222 = null;
            Press223 = null;
            Press224 = null;
            Press225 = null;
            Press226 = null;
            Press227 = null;
            Press228 = null;
            Press229 = null;
            Press230 = null;
            Press231 = null;
            Press232 = null;
            Press233 = null;
            Press234 = null;
            Press235 = null;
            Press236 = null;
            Press237 = null;
            Press238 = null;
            Press239 = null;
            Press240 = null;
            Press241 = null;
            Press242 = null;
            Press243 = null;
            Press244 = null;
            Press245 = null;
            Press246 = null;
            Press247 = null;
            Press248 = null;
            Press249 = null;
            Press250 = null;
            Press189 = null;
        }

        #endregion

    }
}
