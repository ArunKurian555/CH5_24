using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;

namespace CBlink
{
    public interface IZones
    {
        object UserObject { get; set; }

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
        event EventHandler<UIEventArgs> Press189;
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
        event EventHandler<UIEventArgs> Press0;
        event EventHandler<UIEventArgs> Save_Area;

        void Pressed1(ZonesBoolInputSigDelegate callback);
        void Pressed2(ZonesBoolInputSigDelegate callback);
        void Pressed3(ZonesBoolInputSigDelegate callback);
        void Pressed4(ZonesBoolInputSigDelegate callback);
        void Pressed5(ZonesBoolInputSigDelegate callback);
        void Pressed6(ZonesBoolInputSigDelegate callback);
        void Pressed7(ZonesBoolInputSigDelegate callback);
        void Pressed8(ZonesBoolInputSigDelegate callback);
        void Pressed9(ZonesBoolInputSigDelegate callback);
        void Pressed10(ZonesBoolInputSigDelegate callback);
        void Pressed11(ZonesBoolInputSigDelegate callback);
        void Pressed12(ZonesBoolInputSigDelegate callback);
        void Pressed13(ZonesBoolInputSigDelegate callback);
        void Pressed14(ZonesBoolInputSigDelegate callback);
        void Pressed15(ZonesBoolInputSigDelegate callback);
        void Pressed16(ZonesBoolInputSigDelegate callback);
        void Pressed17(ZonesBoolInputSigDelegate callback);
        void Pressed18(ZonesBoolInputSigDelegate callback);
        void Pressed19(ZonesBoolInputSigDelegate callback);
        void Pressed20(ZonesBoolInputSigDelegate callback);
        void Pressed21(ZonesBoolInputSigDelegate callback);
        void Pressed22(ZonesBoolInputSigDelegate callback);
        void Pressed23(ZonesBoolInputSigDelegate callback);
        void Pressed24(ZonesBoolInputSigDelegate callback);
        void Pressed25(ZonesBoolInputSigDelegate callback);
        void Pressed26(ZonesBoolInputSigDelegate callback);
        void Pressed27(ZonesBoolInputSigDelegate callback);
        void Pressed28(ZonesBoolInputSigDelegate callback);
        void Pressed29(ZonesBoolInputSigDelegate callback);
        void Pressed30(ZonesBoolInputSigDelegate callback);
        void Pressed31(ZonesBoolInputSigDelegate callback);
        void Pressed32(ZonesBoolInputSigDelegate callback);
        void Pressed33(ZonesBoolInputSigDelegate callback);
        void Pressed34(ZonesBoolInputSigDelegate callback);
        void Pressed35(ZonesBoolInputSigDelegate callback);
        void Pressed36(ZonesBoolInputSigDelegate callback);
        void Pressed37(ZonesBoolInputSigDelegate callback);
        void Pressed38(ZonesBoolInputSigDelegate callback);
        void Pressed39(ZonesBoolInputSigDelegate callback);
        void Pressed40(ZonesBoolInputSigDelegate callback);
        void Pressed41(ZonesBoolInputSigDelegate callback);
        void Pressed42(ZonesBoolInputSigDelegate callback);
        void Pressed43(ZonesBoolInputSigDelegate callback);
        void Pressed44(ZonesBoolInputSigDelegate callback);
        void Pressed45(ZonesBoolInputSigDelegate callback);
        void Pressed46(ZonesBoolInputSigDelegate callback);
        void Pressed47(ZonesBoolInputSigDelegate callback);
        void Pressed48(ZonesBoolInputSigDelegate callback);
        void Pressed49(ZonesBoolInputSigDelegate callback);
        void Pressed50(ZonesBoolInputSigDelegate callback);
        void Pressed51(ZonesBoolInputSigDelegate callback);
        void Pressed52(ZonesBoolInputSigDelegate callback);
        void Pressed53(ZonesBoolInputSigDelegate callback);
        void Pressed54(ZonesBoolInputSigDelegate callback);
        void Pressed55(ZonesBoolInputSigDelegate callback);
        void Pressed56(ZonesBoolInputSigDelegate callback);
        void Pressed57(ZonesBoolInputSigDelegate callback);
        void Pressed58(ZonesBoolInputSigDelegate callback);
        void Pressed59(ZonesBoolInputSigDelegate callback);
        void Pressed60(ZonesBoolInputSigDelegate callback);
        void Pressed61(ZonesBoolInputSigDelegate callback);
        void Pressed62(ZonesBoolInputSigDelegate callback);
        void Pressed63(ZonesBoolInputSigDelegate callback);
        void Pressed64(ZonesBoolInputSigDelegate callback);
        void Pressed65(ZonesBoolInputSigDelegate callback);
        void Pressed66(ZonesBoolInputSigDelegate callback);
        void Pressed67(ZonesBoolInputSigDelegate callback);
        void Pressed68(ZonesBoolInputSigDelegate callback);
        void Pressed69(ZonesBoolInputSigDelegate callback);
        void Pressed70(ZonesBoolInputSigDelegate callback);
        void Pressed71(ZonesBoolInputSigDelegate callback);
        void Pressed72(ZonesBoolInputSigDelegate callback);
        void Pressed73(ZonesBoolInputSigDelegate callback);
        void Pressed74(ZonesBoolInputSigDelegate callback);
        void Pressed75(ZonesBoolInputSigDelegate callback);
        void Pressed76(ZonesBoolInputSigDelegate callback);
        void Pressed77(ZonesBoolInputSigDelegate callback);
        void Pressed78(ZonesBoolInputSigDelegate callback);
        void Pressed79(ZonesBoolInputSigDelegate callback);
        void Pressed80(ZonesBoolInputSigDelegate callback);
        void Pressed81(ZonesBoolInputSigDelegate callback);
        void Pressed82(ZonesBoolInputSigDelegate callback);
        void Pressed83(ZonesBoolInputSigDelegate callback);
        void Pressed84(ZonesBoolInputSigDelegate callback);
        void Pressed85(ZonesBoolInputSigDelegate callback);
        void Pressed86(ZonesBoolInputSigDelegate callback);
        void Pressed87(ZonesBoolInputSigDelegate callback);
        void Pressed88(ZonesBoolInputSigDelegate callback);
        void Pressed89(ZonesBoolInputSigDelegate callback);
        void Pressed90(ZonesBoolInputSigDelegate callback);
        void Pressed91(ZonesBoolInputSigDelegate callback);
        void Pressed92(ZonesBoolInputSigDelegate callback);
        void Pressed93(ZonesBoolInputSigDelegate callback);
        void Pressed94(ZonesBoolInputSigDelegate callback);
        void Pressed95(ZonesBoolInputSigDelegate callback);
        void Pressed96(ZonesBoolInputSigDelegate callback);
        void Pressed97(ZonesBoolInputSigDelegate callback);
        void Pressed98(ZonesBoolInputSigDelegate callback);
        void Pressed99(ZonesBoolInputSigDelegate callback);
        void Pressed100(ZonesBoolInputSigDelegate callback);
        void Pressed101(ZonesBoolInputSigDelegate callback);
        void Pressed102(ZonesBoolInputSigDelegate callback);
        void Pressed103(ZonesBoolInputSigDelegate callback);
        void Pressed104(ZonesBoolInputSigDelegate callback);
        void Pressed105(ZonesBoolInputSigDelegate callback);
        void Pressed106(ZonesBoolInputSigDelegate callback);
        void Pressed107(ZonesBoolInputSigDelegate callback);
        void Pressed108(ZonesBoolInputSigDelegate callback);
        void Pressed109(ZonesBoolInputSigDelegate callback);
        void Pressed110(ZonesBoolInputSigDelegate callback);
        void Pressed111(ZonesBoolInputSigDelegate callback);
        void Pressed112(ZonesBoolInputSigDelegate callback);
        void Pressed113(ZonesBoolInputSigDelegate callback);
        void Pressed114(ZonesBoolInputSigDelegate callback);
        void Pressed115(ZonesBoolInputSigDelegate callback);
        void Pressed116(ZonesBoolInputSigDelegate callback);
        void Pressed117(ZonesBoolInputSigDelegate callback);
        void Pressed118(ZonesBoolInputSigDelegate callback);
        void Pressed119(ZonesBoolInputSigDelegate callback);
        void Pressed120(ZonesBoolInputSigDelegate callback);
        void Pressed121(ZonesBoolInputSigDelegate callback);
        void Pressed122(ZonesBoolInputSigDelegate callback);
        void Pressed123(ZonesBoolInputSigDelegate callback);
        void Pressed124(ZonesBoolInputSigDelegate callback);
        void Pressed125(ZonesBoolInputSigDelegate callback);
        void Pressed126(ZonesBoolInputSigDelegate callback);
        void Pressed127(ZonesBoolInputSigDelegate callback);
        void Pressed128(ZonesBoolInputSigDelegate callback);
        void Pressed129(ZonesBoolInputSigDelegate callback);
        void Pressed130(ZonesBoolInputSigDelegate callback);
        void Pressed131(ZonesBoolInputSigDelegate callback);
        void Pressed132(ZonesBoolInputSigDelegate callback);
        void Pressed133(ZonesBoolInputSigDelegate callback);
        void Pressed134(ZonesBoolInputSigDelegate callback);
        void Pressed135(ZonesBoolInputSigDelegate callback);
        void Pressed136(ZonesBoolInputSigDelegate callback);
        void Pressed137(ZonesBoolInputSigDelegate callback);
        void Pressed138(ZonesBoolInputSigDelegate callback);
        void Pressed139(ZonesBoolInputSigDelegate callback);
        void Pressed140(ZonesBoolInputSigDelegate callback);
        void Pressed141(ZonesBoolInputSigDelegate callback);
        void Pressed142(ZonesBoolInputSigDelegate callback);
        void Pressed143(ZonesBoolInputSigDelegate callback);
        void Pressed144(ZonesBoolInputSigDelegate callback);
        void Pressed145(ZonesBoolInputSigDelegate callback);
        void Pressed146(ZonesBoolInputSigDelegate callback);
        void Pressed147(ZonesBoolInputSigDelegate callback);
        void Pressed148(ZonesBoolInputSigDelegate callback);
        void Pressed149(ZonesBoolInputSigDelegate callback);
        void Pressed150(ZonesBoolInputSigDelegate callback);
        void Pressed151(ZonesBoolInputSigDelegate callback);
        void Pressed152(ZonesBoolInputSigDelegate callback);
        void Pressed153(ZonesBoolInputSigDelegate callback);
        void Pressed154(ZonesBoolInputSigDelegate callback);
        void Pressed155(ZonesBoolInputSigDelegate callback);
        void Pressed156(ZonesBoolInputSigDelegate callback);
        void Pressed157(ZonesBoolInputSigDelegate callback);
        void Pressed158(ZonesBoolInputSigDelegate callback);
        void Pressed159(ZonesBoolInputSigDelegate callback);
        void Pressed160(ZonesBoolInputSigDelegate callback);
        void Pressed161(ZonesBoolInputSigDelegate callback);
        void Pressed162(ZonesBoolInputSigDelegate callback);
        void Pressed163(ZonesBoolInputSigDelegate callback);
        void Pressed164(ZonesBoolInputSigDelegate callback);
        void Pressed165(ZonesBoolInputSigDelegate callback);
        void Pressed166(ZonesBoolInputSigDelegate callback);
        void Pressed167(ZonesBoolInputSigDelegate callback);
        void Pressed168(ZonesBoolInputSigDelegate callback);
        void Pressed169(ZonesBoolInputSigDelegate callback);
        void Pressed170(ZonesBoolInputSigDelegate callback);
        void Pressed171(ZonesBoolInputSigDelegate callback);
        void Pressed172(ZonesBoolInputSigDelegate callback);
        void Pressed173(ZonesBoolInputSigDelegate callback);
        void Pressed174(ZonesBoolInputSigDelegate callback);
        void Pressed175(ZonesBoolInputSigDelegate callback);
        void Pressed176(ZonesBoolInputSigDelegate callback);
        void Pressed177(ZonesBoolInputSigDelegate callback);
        void Pressed178(ZonesBoolInputSigDelegate callback);
        void Pressed179(ZonesBoolInputSigDelegate callback);
        void Pressed180(ZonesBoolInputSigDelegate callback);
        void Pressed181(ZonesBoolInputSigDelegate callback);
        void Pressed182(ZonesBoolInputSigDelegate callback);
        void Pressed183(ZonesBoolInputSigDelegate callback);
        void Pressed184(ZonesBoolInputSigDelegate callback);
        void Pressed185(ZonesBoolInputSigDelegate callback);
        void Pressed186(ZonesBoolInputSigDelegate callback);
        void Pressed187(ZonesBoolInputSigDelegate callback);
        void Pressed188(ZonesBoolInputSigDelegate callback);
        void Pressed189(ZonesBoolInputSigDelegate callback);
        void Pressed190(ZonesBoolInputSigDelegate callback);
        void Pressed191(ZonesBoolInputSigDelegate callback);
        void Pressed192(ZonesBoolInputSigDelegate callback);
        void Pressed193(ZonesBoolInputSigDelegate callback);
        void Pressed194(ZonesBoolInputSigDelegate callback);
        void Pressed195(ZonesBoolInputSigDelegate callback);
        void Pressed196(ZonesBoolInputSigDelegate callback);
        void Pressed197(ZonesBoolInputSigDelegate callback);
        void Pressed198(ZonesBoolInputSigDelegate callback);
        void Pressed199(ZonesBoolInputSigDelegate callback);
        void Pressed200(ZonesBoolInputSigDelegate callback);
        void Pressed201(ZonesBoolInputSigDelegate callback);
        void Pressed202(ZonesBoolInputSigDelegate callback);
        void Pressed203(ZonesBoolInputSigDelegate callback);
        void Pressed204(ZonesBoolInputSigDelegate callback);
        void Pressed205(ZonesBoolInputSigDelegate callback);
        void Pressed206(ZonesBoolInputSigDelegate callback);
        void Pressed207(ZonesBoolInputSigDelegate callback);
        void Pressed208(ZonesBoolInputSigDelegate callback);
        void Pressed209(ZonesBoolInputSigDelegate callback);
        void Pressed210(ZonesBoolInputSigDelegate callback);
        void Pressed211(ZonesBoolInputSigDelegate callback);
        void Pressed212(ZonesBoolInputSigDelegate callback);
        void Pressed213(ZonesBoolInputSigDelegate callback);
        void Pressed214(ZonesBoolInputSigDelegate callback);
        void Pressed215(ZonesBoolInputSigDelegate callback);
        void Pressed216(ZonesBoolInputSigDelegate callback);
        void Pressed217(ZonesBoolInputSigDelegate callback);
        void Pressed218(ZonesBoolInputSigDelegate callback);
        void Pressed219(ZonesBoolInputSigDelegate callback);
        void Pressed220(ZonesBoolInputSigDelegate callback);
        void Pressed221(ZonesBoolInputSigDelegate callback);
        void Pressed222(ZonesBoolInputSigDelegate callback);
        void Pressed223(ZonesBoolInputSigDelegate callback);
        void Pressed224(ZonesBoolInputSigDelegate callback);
        void Pressed225(ZonesBoolInputSigDelegate callback);
        void Pressed226(ZonesBoolInputSigDelegate callback);
        void Pressed227(ZonesBoolInputSigDelegate callback);
        void Pressed228(ZonesBoolInputSigDelegate callback);
        void Pressed229(ZonesBoolInputSigDelegate callback);
        void Pressed230(ZonesBoolInputSigDelegate callback);
        void Pressed231(ZonesBoolInputSigDelegate callback);
        void Pressed232(ZonesBoolInputSigDelegate callback);
        void Pressed233(ZonesBoolInputSigDelegate callback);
        void Pressed234(ZonesBoolInputSigDelegate callback);
        void Pressed235(ZonesBoolInputSigDelegate callback);
        void Pressed236(ZonesBoolInputSigDelegate callback);
        void Pressed237(ZonesBoolInputSigDelegate callback);
        void Pressed238(ZonesBoolInputSigDelegate callback);
        void Pressed239(ZonesBoolInputSigDelegate callback);
        void Pressed240(ZonesBoolInputSigDelegate callback);
        void Pressed241(ZonesBoolInputSigDelegate callback);
        void Pressed242(ZonesBoolInputSigDelegate callback);
        void Pressed243(ZonesBoolInputSigDelegate callback);
        void Pressed244(ZonesBoolInputSigDelegate callback);
        void Pressed245(ZonesBoolInputSigDelegate callback);
        void Pressed246(ZonesBoolInputSigDelegate callback);
        void Pressed247(ZonesBoolInputSigDelegate callback);
        void Pressed248(ZonesBoolInputSigDelegate callback);
        void Pressed249(ZonesBoolInputSigDelegate callback);
        void Pressed0(ZonesBoolInputSigDelegate callback);
        void Zone1(ZonesStringInputSigDelegate callback);
        void Zone2(ZonesStringInputSigDelegate callback);
        void Zone3(ZonesStringInputSigDelegate callback);
        void Zone4(ZonesStringInputSigDelegate callback);
        void Zone5(ZonesStringInputSigDelegate callback);
        void Zone6(ZonesStringInputSigDelegate callback);
        void Zone7(ZonesStringInputSigDelegate callback);
        void Zone8(ZonesStringInputSigDelegate callback);
        void Zone9(ZonesStringInputSigDelegate callback);
        void Zone10(ZonesStringInputSigDelegate callback);
        void Zone11(ZonesStringInputSigDelegate callback);
        void Zone12(ZonesStringInputSigDelegate callback);
        void Zone13(ZonesStringInputSigDelegate callback);
        void Zone14(ZonesStringInputSigDelegate callback);
        void Zone15(ZonesStringInputSigDelegate callback);
        void Zone16(ZonesStringInputSigDelegate callback);
        void Zone17(ZonesStringInputSigDelegate callback);
        void Zone18(ZonesStringInputSigDelegate callback);
        void Zone19(ZonesStringInputSigDelegate callback);
        void Zone20(ZonesStringInputSigDelegate callback);
        void Zone21(ZonesStringInputSigDelegate callback);
        void Zone22(ZonesStringInputSigDelegate callback);
        void Zone23(ZonesStringInputSigDelegate callback);
        void Zone24(ZonesStringInputSigDelegate callback);
        void Zone25(ZonesStringInputSigDelegate callback);
        void Zone26(ZonesStringInputSigDelegate callback);
        void Zone27(ZonesStringInputSigDelegate callback);
        void Zone28(ZonesStringInputSigDelegate callback);
        void Zone29(ZonesStringInputSigDelegate callback);
        void Zone30(ZonesStringInputSigDelegate callback);
        void Zone31(ZonesStringInputSigDelegate callback);
        void Zone32(ZonesStringInputSigDelegate callback);
        void Zone33(ZonesStringInputSigDelegate callback);
        void Zone34(ZonesStringInputSigDelegate callback);
        void Zone35(ZonesStringInputSigDelegate callback);
        void Zone36(ZonesStringInputSigDelegate callback);
        void Zone37(ZonesStringInputSigDelegate callback);
        void Zone38(ZonesStringInputSigDelegate callback);
        void Zone39(ZonesStringInputSigDelegate callback);
        void Zone40(ZonesStringInputSigDelegate callback);
        void Zone41(ZonesStringInputSigDelegate callback);
        void Zone42(ZonesStringInputSigDelegate callback);
        void Zone43(ZonesStringInputSigDelegate callback);
        void Zone44(ZonesStringInputSigDelegate callback);
        void Zone45(ZonesStringInputSigDelegate callback);
        void Zone46(ZonesStringInputSigDelegate callback);
        void Zone47(ZonesStringInputSigDelegate callback);
        void Zone48(ZonesStringInputSigDelegate callback);
        void Zone49(ZonesStringInputSigDelegate callback);
        void Zone50(ZonesStringInputSigDelegate callback);
        void Zone51(ZonesStringInputSigDelegate callback);
        void Zone52(ZonesStringInputSigDelegate callback);
        void Zone53(ZonesStringInputSigDelegate callback);
        void Zone54(ZonesStringInputSigDelegate callback);
        void Zone55(ZonesStringInputSigDelegate callback);
        void Zone56(ZonesStringInputSigDelegate callback);
        void Zone57(ZonesStringInputSigDelegate callback);
        void Zone58(ZonesStringInputSigDelegate callback);
        void Zone59(ZonesStringInputSigDelegate callback);
        void Zone60(ZonesStringInputSigDelegate callback);
        void Zone61(ZonesStringInputSigDelegate callback);
        void Zone62(ZonesStringInputSigDelegate callback);
        void Zone63(ZonesStringInputSigDelegate callback);
        void Zone64(ZonesStringInputSigDelegate callback);
        void Zone65(ZonesStringInputSigDelegate callback);
        void Zone66(ZonesStringInputSigDelegate callback);
        void Zone67(ZonesStringInputSigDelegate callback);
        void Zone68(ZonesStringInputSigDelegate callback);
        void Zone69(ZonesStringInputSigDelegate callback);
        void Zone70(ZonesStringInputSigDelegate callback);
        void Zone71(ZonesStringInputSigDelegate callback);
        void Zone72(ZonesStringInputSigDelegate callback);
        void Zone73(ZonesStringInputSigDelegate callback);
        void Zone74(ZonesStringInputSigDelegate callback);
        void Zone75(ZonesStringInputSigDelegate callback);
        void Zone76(ZonesStringInputSigDelegate callback);
        void Zone77(ZonesStringInputSigDelegate callback);
        void Zone78(ZonesStringInputSigDelegate callback);
        void Zone79(ZonesStringInputSigDelegate callback);
        void Zone80(ZonesStringInputSigDelegate callback);
        void Zone81(ZonesStringInputSigDelegate callback);
        void Zone82(ZonesStringInputSigDelegate callback);
        void Zone83(ZonesStringInputSigDelegate callback);
        void Zone84(ZonesStringInputSigDelegate callback);
        void Zone85(ZonesStringInputSigDelegate callback);
        void Zone86(ZonesStringInputSigDelegate callback);
        void Zone87(ZonesStringInputSigDelegate callback);
        void Zone88(ZonesStringInputSigDelegate callback);
        void Zone89(ZonesStringInputSigDelegate callback);
        void Zone90(ZonesStringInputSigDelegate callback);
        void Zone91(ZonesStringInputSigDelegate callback);
        void Zone92(ZonesStringInputSigDelegate callback);
        void Zone93(ZonesStringInputSigDelegate callback);
        void Zone94(ZonesStringInputSigDelegate callback);
        void Zone95(ZonesStringInputSigDelegate callback);
        void Zone96(ZonesStringInputSigDelegate callback);
        void Zone97(ZonesStringInputSigDelegate callback);
        void Zone98(ZonesStringInputSigDelegate callback);
        void Zone99(ZonesStringInputSigDelegate callback);
        void Zone100(ZonesStringInputSigDelegate callback);
        void Zone101(ZonesStringInputSigDelegate callback);
        void Zone102(ZonesStringInputSigDelegate callback);
        void Zone103(ZonesStringInputSigDelegate callback);
        void Zone104(ZonesStringInputSigDelegate callback);
        void Zone105(ZonesStringInputSigDelegate callback);
        void Zone106(ZonesStringInputSigDelegate callback);
        void Zone107(ZonesStringInputSigDelegate callback);
        void Zone108(ZonesStringInputSigDelegate callback);
        void Zone109(ZonesStringInputSigDelegate callback);
        void Zone110(ZonesStringInputSigDelegate callback);
        void Zone111(ZonesStringInputSigDelegate callback);
        void Zone112(ZonesStringInputSigDelegate callback);
        void Zone113(ZonesStringInputSigDelegate callback);
        void Zone114(ZonesStringInputSigDelegate callback);
        void Zone115(ZonesStringInputSigDelegate callback);
        void Zone116(ZonesStringInputSigDelegate callback);
        void Zone117(ZonesStringInputSigDelegate callback);
        void Zone118(ZonesStringInputSigDelegate callback);
        void Zone119(ZonesStringInputSigDelegate callback);
        void Zone120(ZonesStringInputSigDelegate callback);
        void Zone121(ZonesStringInputSigDelegate callback);
        void Zone122(ZonesStringInputSigDelegate callback);
        void Zone123(ZonesStringInputSigDelegate callback);
        void Zone124(ZonesStringInputSigDelegate callback);
        void Zone125(ZonesStringInputSigDelegate callback);
        void Zone126(ZonesStringInputSigDelegate callback);
        void Zone127(ZonesStringInputSigDelegate callback);
        void Zone128(ZonesStringInputSigDelegate callback);
        void Zone129(ZonesStringInputSigDelegate callback);
        void Zone130(ZonesStringInputSigDelegate callback);
        void Zone131(ZonesStringInputSigDelegate callback);
        void Zone132(ZonesStringInputSigDelegate callback);
        void Zone133(ZonesStringInputSigDelegate callback);
        void Zone134(ZonesStringInputSigDelegate callback);
        void Zone135(ZonesStringInputSigDelegate callback);
        void Zone136(ZonesStringInputSigDelegate callback);
        void Zone137(ZonesStringInputSigDelegate callback);
        void Zone138(ZonesStringInputSigDelegate callback);
        void Zone139(ZonesStringInputSigDelegate callback);
        void Zone140(ZonesStringInputSigDelegate callback);
        void Zone141(ZonesStringInputSigDelegate callback);
        void Zone142(ZonesStringInputSigDelegate callback);
        void Zone143(ZonesStringInputSigDelegate callback);
        void Zone144(ZonesStringInputSigDelegate callback);
        void Zone145(ZonesStringInputSigDelegate callback);
        void Zone146(ZonesStringInputSigDelegate callback);
        void Zone147(ZonesStringInputSigDelegate callback);
        void Zone148(ZonesStringInputSigDelegate callback);
        void Zone149(ZonesStringInputSigDelegate callback);
        void Zone150(ZonesStringInputSigDelegate callback);
        void Zone151(ZonesStringInputSigDelegate callback);
        void Zone152(ZonesStringInputSigDelegate callback);
        void Zone153(ZonesStringInputSigDelegate callback);
        void Zone154(ZonesStringInputSigDelegate callback);
        void Zone155(ZonesStringInputSigDelegate callback);
        void Zone156(ZonesStringInputSigDelegate callback);
        void Zone157(ZonesStringInputSigDelegate callback);
        void Zone158(ZonesStringInputSigDelegate callback);
        void Zone159(ZonesStringInputSigDelegate callback);
        void Zone160(ZonesStringInputSigDelegate callback);
        void Zone161(ZonesStringInputSigDelegate callback);
        void Zone162(ZonesStringInputSigDelegate callback);
        void Zone163(ZonesStringInputSigDelegate callback);
        void Zone164(ZonesStringInputSigDelegate callback);
        void Zone165(ZonesStringInputSigDelegate callback);
        void Zone166(ZonesStringInputSigDelegate callback);
        void Zone167(ZonesStringInputSigDelegate callback);
        void Zone168(ZonesStringInputSigDelegate callback);
        void Zone169(ZonesStringInputSigDelegate callback);
        void Zone170(ZonesStringInputSigDelegate callback);
        void Zone171(ZonesStringInputSigDelegate callback);
        void Zone172(ZonesStringInputSigDelegate callback);
        void Zone173(ZonesStringInputSigDelegate callback);
        void Zone174(ZonesStringInputSigDelegate callback);
        void Zone175(ZonesStringInputSigDelegate callback);
        void Zone176(ZonesStringInputSigDelegate callback);
        void Zone177(ZonesStringInputSigDelegate callback);
        void Zone178(ZonesStringInputSigDelegate callback);
        void Zone179(ZonesStringInputSigDelegate callback);
        void Zone180(ZonesStringInputSigDelegate callback);
        void Zone181(ZonesStringInputSigDelegate callback);
        void Zone182(ZonesStringInputSigDelegate callback);
        void Zone183(ZonesStringInputSigDelegate callback);
        void Zone184(ZonesStringInputSigDelegate callback);
        void Zone185(ZonesStringInputSigDelegate callback);
        void Zone186(ZonesStringInputSigDelegate callback);
        void Zone187(ZonesStringInputSigDelegate callback);
        void Zone188(ZonesStringInputSigDelegate callback);
        void Zone189(ZonesStringInputSigDelegate callback);
        void Zone190(ZonesStringInputSigDelegate callback);
        void Zone191(ZonesStringInputSigDelegate callback);
        void Zone192(ZonesStringInputSigDelegate callback);
        void Zone193(ZonesStringInputSigDelegate callback);
        void Zone194(ZonesStringInputSigDelegate callback);
        void Zone195(ZonesStringInputSigDelegate callback);
        void Zone196(ZonesStringInputSigDelegate callback);
        void Zone197(ZonesStringInputSigDelegate callback);
        void Zone198(ZonesStringInputSigDelegate callback);
        void Zone199(ZonesStringInputSigDelegate callback);
        void Zone200(ZonesStringInputSigDelegate callback);
        void Zone201(ZonesStringInputSigDelegate callback);
        void Zone202(ZonesStringInputSigDelegate callback);
        void Zone203(ZonesStringInputSigDelegate callback);
        void Zone204(ZonesStringInputSigDelegate callback);
        void Zone205(ZonesStringInputSigDelegate callback);
        void Zone206(ZonesStringInputSigDelegate callback);
        void Zone207(ZonesStringInputSigDelegate callback);
        void Zone208(ZonesStringInputSigDelegate callback);
        void Zone209(ZonesStringInputSigDelegate callback);
        void Zone210(ZonesStringInputSigDelegate callback);
        void Zone211(ZonesStringInputSigDelegate callback);
        void Zone212(ZonesStringInputSigDelegate callback);
        void Zone213(ZonesStringInputSigDelegate callback);
        void Zone214(ZonesStringInputSigDelegate callback);
        void Zone215(ZonesStringInputSigDelegate callback);
        void Zone216(ZonesStringInputSigDelegate callback);
        void Zone217(ZonesStringInputSigDelegate callback);
        void Zone218(ZonesStringInputSigDelegate callback);
        void Zone219(ZonesStringInputSigDelegate callback);
        void Zone220(ZonesStringInputSigDelegate callback);
        void Zone221(ZonesStringInputSigDelegate callback);
        void Zone222(ZonesStringInputSigDelegate callback);
        void Zone223(ZonesStringInputSigDelegate callback);
        void Zone224(ZonesStringInputSigDelegate callback);
        void Zone225(ZonesStringInputSigDelegate callback);
        void Zone226(ZonesStringInputSigDelegate callback);
        void Zone227(ZonesStringInputSigDelegate callback);
        void Zone228(ZonesStringInputSigDelegate callback);
        void Zone229(ZonesStringInputSigDelegate callback);
        void Zone230(ZonesStringInputSigDelegate callback);
        void Zone231(ZonesStringInputSigDelegate callback);
        void Zone232(ZonesStringInputSigDelegate callback);
        void Zone233(ZonesStringInputSigDelegate callback);
        void Zone234(ZonesStringInputSigDelegate callback);
        void Zone235(ZonesStringInputSigDelegate callback);
        void Zone236(ZonesStringInputSigDelegate callback);
        void Zone237(ZonesStringInputSigDelegate callback);
        void Zone238(ZonesStringInputSigDelegate callback);
        void Zone239(ZonesStringInputSigDelegate callback);
        void Zone240(ZonesStringInputSigDelegate callback);
        void Zone241(ZonesStringInputSigDelegate callback);
        void Zone242(ZonesStringInputSigDelegate callback);
        void Zone243(ZonesStringInputSigDelegate callback);
        void Zone244(ZonesStringInputSigDelegate callback);
        void Zone245(ZonesStringInputSigDelegate callback);
        void Zone246(ZonesStringInputSigDelegate callback);
        void Zone247(ZonesStringInputSigDelegate callback);
        void Zone248(ZonesStringInputSigDelegate callback);
        void Zone249(ZonesStringInputSigDelegate callback);
        void Zone0(ZonesStringInputSigDelegate callback);

    }

    public delegate void ZonesBoolInputSigDelegate(BoolInputSig boolInputSig, IZones zones);
    public delegate void ZonesStringInputSigDelegate(StringInputSig stringInputSig, IZones zones);

    internal class Zones : IZones, IDisposable
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
                public const uint Press1 = 1;
                public const uint Press2 = 2;
                public const uint Press3 = 3;
                public const uint Press4 = 4;
                public const uint Press5 = 5;
                public const uint Press6 = 6;
                public const uint Press7 = 7;
                public const uint Press8 = 8;
                public const uint Press9 = 9;
                public const uint Press10 = 10;
                public const uint Press11 = 11;
                public const uint Press12 = 12;
                public const uint Press13 = 13;
                public const uint Press14 = 14;
                public const uint Press15 = 15;
                public const uint Press16 = 16;
                public const uint Press17 = 17;
                public const uint Press18 = 18;
                public const uint Press19 = 19;
                public const uint Press20 = 20;
                public const uint Press21 = 21;
                public const uint Press22 = 22;
                public const uint Press23 = 23;
                public const uint Press24 = 24;
                public const uint Press25 = 25;
                public const uint Press26 = 26;
                public const uint Press27 = 27;
                public const uint Press28 = 28;
                public const uint Press29 = 29;
                public const uint Press30 = 30;
                public const uint Press31 = 31;
                public const uint Press32 = 32;
                public const uint Press33 = 33;
                public const uint Press34 = 34;
                public const uint Press35 = 35;
                public const uint Press36 = 36;
                public const uint Press37 = 37;
                public const uint Press38 = 38;
                public const uint Press39 = 39;
                public const uint Press40 = 40;
                public const uint Press41 = 41;
                public const uint Press42 = 42;
                public const uint Press43 = 43;
                public const uint Press44 = 44;
                public const uint Press45 = 45;
                public const uint Press46 = 46;
                public const uint Press47 = 47;
                public const uint Press48 = 48;
                public const uint Press49 = 49;
                public const uint Press50 = 50;
                public const uint Press51 = 51;
                public const uint Press52 = 52;
                public const uint Press53 = 53;
                public const uint Press54 = 54;
                public const uint Press55 = 55;
                public const uint Press56 = 56;
                public const uint Press57 = 57;
                public const uint Press58 = 58;
                public const uint Press59 = 59;
                public const uint Press60 = 60;
                public const uint Press61 = 61;
                public const uint Press62 = 62;
                public const uint Press63 = 63;
                public const uint Press64 = 64;
                public const uint Press65 = 65;
                public const uint Press66 = 66;
                public const uint Press67 = 67;
                public const uint Press68 = 68;
                public const uint Press69 = 69;
                public const uint Press70 = 70;
                public const uint Press71 = 71;
                public const uint Press72 = 72;
                public const uint Press73 = 73;
                public const uint Press74 = 74;
                public const uint Press75 = 75;
                public const uint Press76 = 76;
                public const uint Press77 = 77;
                public const uint Press78 = 78;
                public const uint Press79 = 79;
                public const uint Press80 = 80;
                public const uint Press81 = 81;
                public const uint Press82 = 82;
                public const uint Press83 = 83;
                public const uint Press84 = 84;
                public const uint Press85 = 85;
                public const uint Press86 = 86;
                public const uint Press87 = 87;
                public const uint Press88 = 88;
                public const uint Press89 = 89;
                public const uint Press90 = 90;
                public const uint Press91 = 91;
                public const uint Press92 = 92;
                public const uint Press93 = 93;
                public const uint Press94 = 94;
                public const uint Press95 = 95;
                public const uint Press96 = 96;
                public const uint Press97 = 97;
                public const uint Press98 = 98;
                public const uint Press99 = 99;
                public const uint Press100 = 100;
                public const uint Press101 = 101;
                public const uint Press102 = 102;
                public const uint Press103 = 103;
                public const uint Press104 = 104;
                public const uint Press105 = 105;
                public const uint Press106 = 106;
                public const uint Press107 = 107;
                public const uint Press108 = 108;
                public const uint Press109 = 109;
                public const uint Press110 = 110;
                public const uint Press111 = 111;
                public const uint Press112 = 112;
                public const uint Press113 = 113;
                public const uint Press114 = 114;
                public const uint Press115 = 115;
                public const uint Press116 = 116;
                public const uint Press117 = 117;
                public const uint Press118 = 118;
                public const uint Press119 = 119;
                public const uint Press120 = 120;
                public const uint Press121 = 121;
                public const uint Press122 = 122;
                public const uint Press123 = 123;
                public const uint Press124 = 124;
                public const uint Press125 = 125;
                public const uint Press126 = 126;
                public const uint Press127 = 127;
                public const uint Press128 = 128;
                public const uint Press129 = 129;
                public const uint Press130 = 130;
                public const uint Press131 = 131;
                public const uint Press132 = 132;
                public const uint Press133 = 133;
                public const uint Press134 = 134;
                public const uint Press135 = 135;
                public const uint Press136 = 136;
                public const uint Press137 = 137;
                public const uint Press138 = 138;
                public const uint Press139 = 139;
                public const uint Press140 = 140;
                public const uint Press141 = 141;
                public const uint Press142 = 142;
                public const uint Press143 = 143;
                public const uint Press144 = 144;
                public const uint Press145 = 145;
                public const uint Press146 = 146;
                public const uint Press147 = 147;
                public const uint Press148 = 148;
                public const uint Press149 = 149;
                public const uint Press150 = 150;
                public const uint Press151 = 151;
                public const uint Press152 = 152;
                public const uint Press153 = 153;
                public const uint Press154 = 154;
                public const uint Press155 = 155;
                public const uint Press156 = 156;
                public const uint Press157 = 157;
                public const uint Press158 = 158;
                public const uint Press159 = 159;
                public const uint Press160 = 160;
                public const uint Press161 = 161;
                public const uint Press162 = 162;
                public const uint Press163 = 163;
                public const uint Press164 = 164;
                public const uint Press165 = 165;
                public const uint Press166 = 166;
                public const uint Press167 = 167;
                public const uint Press168 = 168;
                public const uint Press169 = 169;
                public const uint Press170 = 170;
                public const uint Press171 = 171;
                public const uint Press172 = 172;
                public const uint Press173 = 173;
                public const uint Press174 = 174;
                public const uint Press175 = 175;
                public const uint Press176 = 176;
                public const uint Press177 = 177;
                public const uint Press178 = 178;
                public const uint Press179 = 179;
                public const uint Press180 = 180;
                public const uint Press181 = 181;
                public const uint Press182 = 182;
                public const uint Press183 = 183;
                public const uint Press184 = 184;
                public const uint Press185 = 185;
                public const uint Press186 = 186;
                public const uint Press187 = 187;
                public const uint Press188 = 188;
                public const uint Press189 = 189;
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
                public const uint Press0 = 250;
                public const uint Save_Area = 251;

                public const uint Pressed1 = 1;
                public const uint Pressed2 = 2;
                public const uint Pressed3 = 3;
                public const uint Pressed4 = 4;
                public const uint Pressed5 = 5;
                public const uint Pressed6 = 6;
                public const uint Pressed7 = 7;
                public const uint Pressed8 = 8;
                public const uint Pressed9 = 9;
                public const uint Pressed10 = 10;
                public const uint Pressed11 = 11;
                public const uint Pressed12 = 12;
                public const uint Pressed13 = 13;
                public const uint Pressed14 = 14;
                public const uint Pressed15 = 15;
                public const uint Pressed16 = 16;
                public const uint Pressed17 = 17;
                public const uint Pressed18 = 18;
                public const uint Pressed19 = 19;
                public const uint Pressed20 = 20;
                public const uint Pressed21 = 21;
                public const uint Pressed22 = 22;
                public const uint Pressed23 = 23;
                public const uint Pressed24 = 24;
                public const uint Pressed25 = 25;
                public const uint Pressed26 = 26;
                public const uint Pressed27 = 27;
                public const uint Pressed28 = 28;
                public const uint Pressed29 = 29;
                public const uint Pressed30 = 30;
                public const uint Pressed31 = 31;
                public const uint Pressed32 = 32;
                public const uint Pressed33 = 33;
                public const uint Pressed34 = 34;
                public const uint Pressed35 = 35;
                public const uint Pressed36 = 36;
                public const uint Pressed37 = 37;
                public const uint Pressed38 = 38;
                public const uint Pressed39 = 39;
                public const uint Pressed40 = 40;
                public const uint Pressed41 = 41;
                public const uint Pressed42 = 42;
                public const uint Pressed43 = 43;
                public const uint Pressed44 = 44;
                public const uint Pressed45 = 45;
                public const uint Pressed46 = 46;
                public const uint Pressed47 = 47;
                public const uint Pressed48 = 48;
                public const uint Pressed49 = 49;
                public const uint Pressed50 = 50;
                public const uint Pressed51 = 51;
                public const uint Pressed52 = 52;
                public const uint Pressed53 = 53;
                public const uint Pressed54 = 54;
                public const uint Pressed55 = 55;
                public const uint Pressed56 = 56;
                public const uint Pressed57 = 57;
                public const uint Pressed58 = 58;
                public const uint Pressed59 = 59;
                public const uint Pressed60 = 60;
                public const uint Pressed61 = 61;
                public const uint Pressed62 = 62;
                public const uint Pressed63 = 63;
                public const uint Pressed64 = 64;
                public const uint Pressed65 = 65;
                public const uint Pressed66 = 66;
                public const uint Pressed67 = 67;
                public const uint Pressed68 = 68;
                public const uint Pressed69 = 69;
                public const uint Pressed70 = 70;
                public const uint Pressed71 = 71;
                public const uint Pressed72 = 72;
                public const uint Pressed73 = 73;
                public const uint Pressed74 = 74;
                public const uint Pressed75 = 75;
                public const uint Pressed76 = 76;
                public const uint Pressed77 = 77;
                public const uint Pressed78 = 78;
                public const uint Pressed79 = 79;
                public const uint Pressed80 = 80;
                public const uint Pressed81 = 81;
                public const uint Pressed82 = 82;
                public const uint Pressed83 = 83;
                public const uint Pressed84 = 84;
                public const uint Pressed85 = 85;
                public const uint Pressed86 = 86;
                public const uint Pressed87 = 87;
                public const uint Pressed88 = 88;
                public const uint Pressed89 = 89;
                public const uint Pressed90 = 90;
                public const uint Pressed91 = 91;
                public const uint Pressed92 = 92;
                public const uint Pressed93 = 93;
                public const uint Pressed94 = 94;
                public const uint Pressed95 = 95;
                public const uint Pressed96 = 96;
                public const uint Pressed97 = 97;
                public const uint Pressed98 = 98;
                public const uint Pressed99 = 99;
                public const uint Pressed100 = 100;
                public const uint Pressed101 = 101;
                public const uint Pressed102 = 102;
                public const uint Pressed103 = 103;
                public const uint Pressed104 = 104;
                public const uint Pressed105 = 105;
                public const uint Pressed106 = 106;
                public const uint Pressed107 = 107;
                public const uint Pressed108 = 108;
                public const uint Pressed109 = 109;
                public const uint Pressed110 = 110;
                public const uint Pressed111 = 111;
                public const uint Pressed112 = 112;
                public const uint Pressed113 = 113;
                public const uint Pressed114 = 114;
                public const uint Pressed115 = 115;
                public const uint Pressed116 = 116;
                public const uint Pressed117 = 117;
                public const uint Pressed118 = 118;
                public const uint Pressed119 = 119;
                public const uint Pressed120 = 120;
                public const uint Pressed121 = 121;
                public const uint Pressed122 = 122;
                public const uint Pressed123 = 123;
                public const uint Pressed124 = 124;
                public const uint Pressed125 = 125;
                public const uint Pressed126 = 126;
                public const uint Pressed127 = 127;
                public const uint Pressed128 = 128;
                public const uint Pressed129 = 129;
                public const uint Pressed130 = 130;
                public const uint Pressed131 = 131;
                public const uint Pressed132 = 132;
                public const uint Pressed133 = 133;
                public const uint Pressed134 = 134;
                public const uint Pressed135 = 135;
                public const uint Pressed136 = 136;
                public const uint Pressed137 = 137;
                public const uint Pressed138 = 138;
                public const uint Pressed139 = 139;
                public const uint Pressed140 = 140;
                public const uint Pressed141 = 141;
                public const uint Pressed142 = 142;
                public const uint Pressed143 = 143;
                public const uint Pressed144 = 144;
                public const uint Pressed145 = 145;
                public const uint Pressed146 = 146;
                public const uint Pressed147 = 147;
                public const uint Pressed148 = 148;
                public const uint Pressed149 = 149;
                public const uint Pressed150 = 150;
                public const uint Pressed151 = 151;
                public const uint Pressed152 = 152;
                public const uint Pressed153 = 153;
                public const uint Pressed154 = 154;
                public const uint Pressed155 = 155;
                public const uint Pressed156 = 156;
                public const uint Pressed157 = 157;
                public const uint Pressed158 = 158;
                public const uint Pressed159 = 159;
                public const uint Pressed160 = 160;
                public const uint Pressed161 = 161;
                public const uint Pressed162 = 162;
                public const uint Pressed163 = 163;
                public const uint Pressed164 = 164;
                public const uint Pressed165 = 165;
                public const uint Pressed166 = 166;
                public const uint Pressed167 = 167;
                public const uint Pressed168 = 168;
                public const uint Pressed169 = 169;
                public const uint Pressed170 = 170;
                public const uint Pressed171 = 171;
                public const uint Pressed172 = 172;
                public const uint Pressed173 = 173;
                public const uint Pressed174 = 174;
                public const uint Pressed175 = 175;
                public const uint Pressed176 = 176;
                public const uint Pressed177 = 177;
                public const uint Pressed178 = 178;
                public const uint Pressed179 = 179;
                public const uint Pressed180 = 180;
                public const uint Pressed181 = 181;
                public const uint Pressed182 = 182;
                public const uint Pressed183 = 183;
                public const uint Pressed184 = 184;
                public const uint Pressed185 = 185;
                public const uint Pressed186 = 186;
                public const uint Pressed187 = 187;
                public const uint Pressed188 = 188;
                public const uint Pressed189 = 189;
                public const uint Pressed190 = 190;
                public const uint Pressed191 = 191;
                public const uint Pressed192 = 192;
                public const uint Pressed193 = 193;
                public const uint Pressed194 = 194;
                public const uint Pressed195 = 195;
                public const uint Pressed196 = 196;
                public const uint Pressed197 = 197;
                public const uint Pressed198 = 198;
                public const uint Pressed199 = 199;
                public const uint Pressed200 = 200;
                public const uint Pressed201 = 201;
                public const uint Pressed202 = 202;
                public const uint Pressed203 = 203;
                public const uint Pressed204 = 204;
                public const uint Pressed205 = 205;
                public const uint Pressed206 = 206;
                public const uint Pressed207 = 207;
                public const uint Pressed208 = 208;
                public const uint Pressed209 = 209;
                public const uint Pressed210 = 210;
                public const uint Pressed211 = 211;
                public const uint Pressed212 = 212;
                public const uint Pressed213 = 213;
                public const uint Pressed214 = 214;
                public const uint Pressed215 = 215;
                public const uint Pressed216 = 216;
                public const uint Pressed217 = 217;
                public const uint Pressed218 = 218;
                public const uint Pressed219 = 219;
                public const uint Pressed220 = 220;
                public const uint Pressed221 = 221;
                public const uint Pressed222 = 222;
                public const uint Pressed223 = 223;
                public const uint Pressed224 = 224;
                public const uint Pressed225 = 225;
                public const uint Pressed226 = 226;
                public const uint Pressed227 = 227;
                public const uint Pressed228 = 228;
                public const uint Pressed229 = 229;
                public const uint Pressed230 = 230;
                public const uint Pressed231 = 231;
                public const uint Pressed232 = 232;
                public const uint Pressed233 = 233;
                public const uint Pressed234 = 234;
                public const uint Pressed235 = 235;
                public const uint Pressed236 = 236;
                public const uint Pressed237 = 237;
                public const uint Pressed238 = 238;
                public const uint Pressed239 = 239;
                public const uint Pressed240 = 240;
                public const uint Pressed241 = 241;
                public const uint Pressed242 = 242;
                public const uint Pressed243 = 243;
                public const uint Pressed244 = 244;
                public const uint Pressed245 = 245;
                public const uint Pressed246 = 246;
                public const uint Pressed247 = 247;
                public const uint Pressed248 = 248;
                public const uint Pressed249 = 249;
                public const uint Pressed0 = 250;
            }
            internal static class Strings
            {

                public const uint Zone1 = 1;
                public const uint Zone2 = 2;
                public const uint Zone3 = 3;
                public const uint Zone4 = 4;
                public const uint Zone5 = 5;
                public const uint Zone6 = 6;
                public const uint Zone7 = 7;
                public const uint Zone8 = 8;
                public const uint Zone9 = 9;
                public const uint Zone10 = 10;
                public const uint Zone11 = 11;
                public const uint Zone12 = 12;
                public const uint Zone13 = 13;
                public const uint Zone14 = 14;
                public const uint Zone15 = 15;
                public const uint Zone16 = 16;
                public const uint Zone17 = 17;
                public const uint Zone18 = 18;
                public const uint Zone19 = 19;
                public const uint Zone20 = 20;
                public const uint Zone21 = 21;
                public const uint Zone22 = 22;
                public const uint Zone23 = 23;
                public const uint Zone24 = 24;
                public const uint Zone25 = 25;
                public const uint Zone26 = 26;
                public const uint Zone27 = 27;
                public const uint Zone28 = 28;
                public const uint Zone29 = 29;
                public const uint Zone30 = 30;
                public const uint Zone31 = 31;
                public const uint Zone32 = 32;
                public const uint Zone33 = 33;
                public const uint Zone34 = 34;
                public const uint Zone35 = 35;
                public const uint Zone36 = 36;
                public const uint Zone37 = 37;
                public const uint Zone38 = 38;
                public const uint Zone39 = 39;
                public const uint Zone40 = 40;
                public const uint Zone41 = 41;
                public const uint Zone42 = 42;
                public const uint Zone43 = 43;
                public const uint Zone44 = 44;
                public const uint Zone45 = 45;
                public const uint Zone46 = 46;
                public const uint Zone47 = 47;
                public const uint Zone48 = 48;
                public const uint Zone49 = 49;
                public const uint Zone50 = 50;
                public const uint Zone51 = 51;
                public const uint Zone52 = 52;
                public const uint Zone53 = 53;
                public const uint Zone54 = 54;
                public const uint Zone55 = 55;
                public const uint Zone56 = 56;
                public const uint Zone57 = 57;
                public const uint Zone58 = 58;
                public const uint Zone59 = 59;
                public const uint Zone60 = 60;
                public const uint Zone61 = 61;
                public const uint Zone62 = 62;
                public const uint Zone63 = 63;
                public const uint Zone64 = 64;
                public const uint Zone65 = 65;
                public const uint Zone66 = 66;
                public const uint Zone67 = 67;
                public const uint Zone68 = 68;
                public const uint Zone69 = 69;
                public const uint Zone70 = 70;
                public const uint Zone71 = 71;
                public const uint Zone72 = 72;
                public const uint Zone73 = 73;
                public const uint Zone74 = 74;
                public const uint Zone75 = 75;
                public const uint Zone76 = 76;
                public const uint Zone77 = 77;
                public const uint Zone78 = 78;
                public const uint Zone79 = 79;
                public const uint Zone80 = 80;
                public const uint Zone81 = 81;
                public const uint Zone82 = 82;
                public const uint Zone83 = 83;
                public const uint Zone84 = 84;
                public const uint Zone85 = 85;
                public const uint Zone86 = 86;
                public const uint Zone87 = 87;
                public const uint Zone88 = 88;
                public const uint Zone89 = 89;
                public const uint Zone90 = 90;
                public const uint Zone91 = 91;
                public const uint Zone92 = 92;
                public const uint Zone93 = 93;
                public const uint Zone94 = 94;
                public const uint Zone95 = 95;
                public const uint Zone96 = 96;
                public const uint Zone97 = 97;
                public const uint Zone98 = 98;
                public const uint Zone99 = 99;
                public const uint Zone100 = 100;
                public const uint Zone101 = 101;
                public const uint Zone102 = 102;
                public const uint Zone103 = 103;
                public const uint Zone104 = 104;
                public const uint Zone105 = 105;
                public const uint Zone106 = 106;
                public const uint Zone107 = 107;
                public const uint Zone108 = 108;
                public const uint Zone109 = 109;
                public const uint Zone110 = 110;
                public const uint Zone111 = 111;
                public const uint Zone112 = 112;
                public const uint Zone113 = 113;
                public const uint Zone114 = 114;
                public const uint Zone115 = 115;
                public const uint Zone116 = 116;
                public const uint Zone117 = 117;
                public const uint Zone118 = 118;
                public const uint Zone119 = 119;
                public const uint Zone120 = 120;
                public const uint Zone121 = 121;
                public const uint Zone122 = 122;
                public const uint Zone123 = 123;
                public const uint Zone124 = 124;
                public const uint Zone125 = 125;
                public const uint Zone126 = 126;
                public const uint Zone127 = 127;
                public const uint Zone128 = 128;
                public const uint Zone129 = 129;
                public const uint Zone130 = 130;
                public const uint Zone131 = 131;
                public const uint Zone132 = 132;
                public const uint Zone133 = 133;
                public const uint Zone134 = 134;
                public const uint Zone135 = 135;
                public const uint Zone136 = 136;
                public const uint Zone137 = 137;
                public const uint Zone138 = 138;
                public const uint Zone139 = 139;
                public const uint Zone140 = 140;
                public const uint Zone141 = 141;
                public const uint Zone142 = 142;
                public const uint Zone143 = 143;
                public const uint Zone144 = 144;
                public const uint Zone145 = 145;
                public const uint Zone146 = 146;
                public const uint Zone147 = 147;
                public const uint Zone148 = 148;
                public const uint Zone149 = 149;
                public const uint Zone150 = 150;
                public const uint Zone151 = 151;
                public const uint Zone152 = 152;
                public const uint Zone153 = 153;
                public const uint Zone154 = 154;
                public const uint Zone155 = 155;
                public const uint Zone156 = 156;
                public const uint Zone157 = 157;
                public const uint Zone158 = 158;
                public const uint Zone159 = 159;
                public const uint Zone160 = 160;
                public const uint Zone161 = 161;
                public const uint Zone162 = 162;
                public const uint Zone163 = 163;
                public const uint Zone164 = 164;
                public const uint Zone165 = 165;
                public const uint Zone166 = 166;
                public const uint Zone167 = 167;
                public const uint Zone168 = 168;
                public const uint Zone169 = 169;
                public const uint Zone170 = 170;
                public const uint Zone171 = 171;
                public const uint Zone172 = 172;
                public const uint Zone173 = 173;
                public const uint Zone174 = 174;
                public const uint Zone175 = 175;
                public const uint Zone176 = 176;
                public const uint Zone177 = 177;
                public const uint Zone178 = 178;
                public const uint Zone179 = 179;
                public const uint Zone180 = 180;
                public const uint Zone181 = 181;
                public const uint Zone182 = 182;
                public const uint Zone183 = 183;
                public const uint Zone184 = 184;
                public const uint Zone185 = 185;
                public const uint Zone186 = 186;
                public const uint Zone187 = 187;
                public const uint Zone188 = 188;
                public const uint Zone189 = 189;
                public const uint Zone190 = 190;
                public const uint Zone191 = 191;
                public const uint Zone192 = 192;
                public const uint Zone193 = 193;
                public const uint Zone194 = 194;
                public const uint Zone195 = 195;
                public const uint Zone196 = 196;
                public const uint Zone197 = 197;
                public const uint Zone198 = 198;
                public const uint Zone199 = 199;
                public const uint Zone200 = 200;
                public const uint Zone201 = 201;
                public const uint Zone202 = 202;
                public const uint Zone203 = 203;
                public const uint Zone204 = 204;
                public const uint Zone205 = 205;
                public const uint Zone206 = 206;
                public const uint Zone207 = 207;
                public const uint Zone208 = 208;
                public const uint Zone209 = 209;
                public const uint Zone210 = 210;
                public const uint Zone211 = 211;
                public const uint Zone212 = 212;
                public const uint Zone213 = 213;
                public const uint Zone214 = 214;
                public const uint Zone215 = 215;
                public const uint Zone216 = 216;
                public const uint Zone217 = 217;
                public const uint Zone218 = 218;
                public const uint Zone219 = 219;
                public const uint Zone220 = 220;
                public const uint Zone221 = 221;
                public const uint Zone222 = 222;
                public const uint Zone223 = 223;
                public const uint Zone224 = 224;
                public const uint Zone225 = 225;
                public const uint Zone226 = 226;
                public const uint Zone227 = 227;
                public const uint Zone228 = 228;
                public const uint Zone229 = 229;
                public const uint Zone230 = 230;
                public const uint Zone231 = 231;
                public const uint Zone232 = 232;
                public const uint Zone233 = 233;
                public const uint Zone234 = 234;
                public const uint Zone235 = 235;
                public const uint Zone236 = 236;
                public const uint Zone237 = 237;
                public const uint Zone238 = 238;
                public const uint Zone239 = 239;
                public const uint Zone240 = 240;
                public const uint Zone241 = 241;
                public const uint Zone242 = 242;
                public const uint Zone243 = 243;
                public const uint Zone244 = 244;
                public const uint Zone245 = 245;
                public const uint Zone246 = 246;
                public const uint Zone247 = 247;
                public const uint Zone248 = 248;
                public const uint Zone249 = 249;
                public const uint Zone0 = 250;
            }
        }

        #endregion

        #region Construction and Initialization

        internal Zones(ComponentMediator componentMediator, uint controlJoinId)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId);
        }

        private void Initialize(uint controlJoinId)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
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
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press189, onPress189);
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
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press0, onPress0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Save_Area, onSave_Area);

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

        public event EventHandler<UIEventArgs> Press189;
        private void onPress189(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press189;
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

        public event EventHandler<UIEventArgs> Press0;
        private void onPress0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press0;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        public event EventHandler<UIEventArgs> Save_Area;
        private void onSave_Area(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Save_Area;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        public void Pressed1(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed1], this);
            }
        }

        public void Pressed2(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed2], this);
            }
        }

        public void Pressed3(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed3], this);
            }
        }

        public void Pressed4(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed4], this);
            }
        }

        public void Pressed5(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed5], this);
            }
        }

        public void Pressed6(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed6], this);
            }
        }

        public void Pressed7(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed7], this);
            }
        }

        public void Pressed8(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed8], this);
            }
        }

        public void Pressed9(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed9], this);
            }
        }

        public void Pressed10(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed10], this);
            }
        }

        public void Pressed11(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed11], this);
            }
        }

        public void Pressed12(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed12], this);
            }
        }

        public void Pressed13(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed13], this);
            }
        }

        public void Pressed14(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed14], this);
            }
        }

        public void Pressed15(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed15], this);
            }
        }

        public void Pressed16(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed16], this);
            }
        }

        public void Pressed17(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed17], this);
            }
        }

        public void Pressed18(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed18], this);
            }
        }

        public void Pressed19(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed19], this);
            }
        }

        public void Pressed20(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed20], this);
            }
        }

        public void Pressed21(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed21], this);
            }
        }

        public void Pressed22(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed22], this);
            }
        }

        public void Pressed23(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed23], this);
            }
        }

        public void Pressed24(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed24], this);
            }
        }

        public void Pressed25(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed25], this);
            }
        }

        public void Pressed26(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed26], this);
            }
        }

        public void Pressed27(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed27], this);
            }
        }

        public void Pressed28(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed28], this);
            }
        }

        public void Pressed29(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed29], this);
            }
        }

        public void Pressed30(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed30], this);
            }
        }

        public void Pressed31(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed31], this);
            }
        }

        public void Pressed32(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed32], this);
            }
        }

        public void Pressed33(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed33], this);
            }
        }

        public void Pressed34(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed34], this);
            }
        }

        public void Pressed35(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed35], this);
            }
        }

        public void Pressed36(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed36], this);
            }
        }

        public void Pressed37(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed37], this);
            }
        }

        public void Pressed38(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed38], this);
            }
        }

        public void Pressed39(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed39], this);
            }
        }

        public void Pressed40(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed40], this);
            }
        }

        public void Pressed41(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed41], this);
            }
        }

        public void Pressed42(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed42], this);
            }
        }

        public void Pressed43(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed43], this);
            }
        }

        public void Pressed44(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed44], this);
            }
        }

        public void Pressed45(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed45], this);
            }
        }

        public void Pressed46(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed46], this);
            }
        }

        public void Pressed47(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed47], this);
            }
        }

        public void Pressed48(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed48], this);
            }
        }

        public void Pressed49(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed49], this);
            }
        }

        public void Pressed50(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed50], this);
            }
        }

        public void Pressed51(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed51], this);
            }
        }

        public void Pressed52(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed52], this);
            }
        }

        public void Pressed53(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed53], this);
            }
        }

        public void Pressed54(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed54], this);
            }
        }

        public void Pressed55(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed55], this);
            }
        }

        public void Pressed56(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed56], this);
            }
        }

        public void Pressed57(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed57], this);
            }
        }

        public void Pressed58(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed58], this);
            }
        }

        public void Pressed59(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed59], this);
            }
        }

        public void Pressed60(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed60], this);
            }
        }

        public void Pressed61(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed61], this);
            }
        }

        public void Pressed62(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed62], this);
            }
        }

        public void Pressed63(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed63], this);
            }
        }

        public void Pressed64(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed64], this);
            }
        }

        public void Pressed65(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed65], this);
            }
        }

        public void Pressed66(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed66], this);
            }
        }

        public void Pressed67(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed67], this);
            }
        }

        public void Pressed68(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed68], this);
            }
        }

        public void Pressed69(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed69], this);
            }
        }

        public void Pressed70(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed70], this);
            }
        }

        public void Pressed71(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed71], this);
            }
        }

        public void Pressed72(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed72], this);
            }
        }

        public void Pressed73(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed73], this);
            }
        }

        public void Pressed74(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed74], this);
            }
        }

        public void Pressed75(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed75], this);
            }
        }

        public void Pressed76(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed76], this);
            }
        }

        public void Pressed77(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed77], this);
            }
        }

        public void Pressed78(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed78], this);
            }
        }

        public void Pressed79(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed79], this);
            }
        }

        public void Pressed80(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed80], this);
            }
        }

        public void Pressed81(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed81], this);
            }
        }

        public void Pressed82(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed82], this);
            }
        }

        public void Pressed83(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed83], this);
            }
        }

        public void Pressed84(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed84], this);
            }
        }

        public void Pressed85(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed85], this);
            }
        }

        public void Pressed86(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed86], this);
            }
        }

        public void Pressed87(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed87], this);
            }
        }

        public void Pressed88(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed88], this);
            }
        }

        public void Pressed89(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed89], this);
            }
        }

        public void Pressed90(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed90], this);
            }
        }

        public void Pressed91(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed91], this);
            }
        }

        public void Pressed92(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed92], this);
            }
        }

        public void Pressed93(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed93], this);
            }
        }

        public void Pressed94(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed94], this);
            }
        }

        public void Pressed95(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed95], this);
            }
        }

        public void Pressed96(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed96], this);
            }
        }

        public void Pressed97(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed97], this);
            }
        }

        public void Pressed98(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed98], this);
            }
        }

        public void Pressed99(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed99], this);
            }
        }

        public void Pressed100(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed100], this);
            }
        }

        public void Pressed101(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed101], this);
            }
        }

        public void Pressed102(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed102], this);
            }
        }

        public void Pressed103(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed103], this);
            }
        }

        public void Pressed104(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed104], this);
            }
        }

        public void Pressed105(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed105], this);
            }
        }

        public void Pressed106(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed106], this);
            }
        }

        public void Pressed107(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed107], this);
            }
        }

        public void Pressed108(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed108], this);
            }
        }

        public void Pressed109(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed109], this);
            }
        }

        public void Pressed110(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed110], this);
            }
        }

        public void Pressed111(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed111], this);
            }
        }

        public void Pressed112(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed112], this);
            }
        }

        public void Pressed113(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed113], this);
            }
        }

        public void Pressed114(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed114], this);
            }
        }

        public void Pressed115(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed115], this);
            }
        }

        public void Pressed116(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed116], this);
            }
        }

        public void Pressed117(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed117], this);
            }
        }

        public void Pressed118(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed118], this);
            }
        }

        public void Pressed119(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed119], this);
            }
        }

        public void Pressed120(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed120], this);
            }
        }

        public void Pressed121(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed121], this);
            }
        }

        public void Pressed122(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed122], this);
            }
        }

        public void Pressed123(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed123], this);
            }
        }

        public void Pressed124(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed124], this);
            }
        }

        public void Pressed125(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed125], this);
            }
        }

        public void Pressed126(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed126], this);
            }
        }

        public void Pressed127(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed127], this);
            }
        }

        public void Pressed128(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed128], this);
            }
        }

        public void Pressed129(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed129], this);
            }
        }

        public void Pressed130(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed130], this);
            }
        }

        public void Pressed131(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed131], this);
            }
        }

        public void Pressed132(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed132], this);
            }
        }

        public void Pressed133(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed133], this);
            }
        }

        public void Pressed134(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed134], this);
            }
        }

        public void Pressed135(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed135], this);
            }
        }

        public void Pressed136(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed136], this);
            }
        }

        public void Pressed137(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed137], this);
            }
        }

        public void Pressed138(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed138], this);
            }
        }

        public void Pressed139(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed139], this);
            }
        }

        public void Pressed140(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed140], this);
            }
        }

        public void Pressed141(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed141], this);
            }
        }

        public void Pressed142(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed142], this);
            }
        }

        public void Pressed143(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed143], this);
            }
        }

        public void Pressed144(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed144], this);
            }
        }

        public void Pressed145(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed145], this);
            }
        }

        public void Pressed146(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed146], this);
            }
        }

        public void Pressed147(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed147], this);
            }
        }

        public void Pressed148(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed148], this);
            }
        }

        public void Pressed149(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed149], this);
            }
        }

        public void Pressed150(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed150], this);
            }
        }

        public void Pressed151(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed151], this);
            }
        }

        public void Pressed152(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed152], this);
            }
        }

        public void Pressed153(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed153], this);
            }
        }

        public void Pressed154(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed154], this);
            }
        }

        public void Pressed155(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed155], this);
            }
        }

        public void Pressed156(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed156], this);
            }
        }

        public void Pressed157(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed157], this);
            }
        }

        public void Pressed158(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed158], this);
            }
        }

        public void Pressed159(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed159], this);
            }
        }

        public void Pressed160(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed160], this);
            }
        }

        public void Pressed161(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed161], this);
            }
        }

        public void Pressed162(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed162], this);
            }
        }

        public void Pressed163(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed163], this);
            }
        }

        public void Pressed164(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed164], this);
            }
        }

        public void Pressed165(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed165], this);
            }
        }

        public void Pressed166(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed166], this);
            }
        }

        public void Pressed167(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed167], this);
            }
        }

        public void Pressed168(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed168], this);
            }
        }

        public void Pressed169(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed169], this);
            }
        }

        public void Pressed170(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed170], this);
            }
        }

        public void Pressed171(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed171], this);
            }
        }

        public void Pressed172(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed172], this);
            }
        }

        public void Pressed173(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed173], this);
            }
        }

        public void Pressed174(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed174], this);
            }
        }

        public void Pressed175(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed175], this);
            }
        }

        public void Pressed176(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed176], this);
            }
        }

        public void Pressed177(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed177], this);
            }
        }

        public void Pressed178(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed178], this);
            }
        }

        public void Pressed179(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed179], this);
            }
        }

        public void Pressed180(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed180], this);
            }
        }

        public void Pressed181(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed181], this);
            }
        }

        public void Pressed182(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed182], this);
            }
        }

        public void Pressed183(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed183], this);
            }
        }

        public void Pressed184(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed184], this);
            }
        }

        public void Pressed185(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed185], this);
            }
        }

        public void Pressed186(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed186], this);
            }
        }

        public void Pressed187(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed187], this);
            }
        }

        public void Pressed188(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed188], this);
            }
        }

        public void Pressed189(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed189], this);
            }
        }

        public void Pressed190(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed190], this);
            }
        }

        public void Pressed191(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed191], this);
            }
        }

        public void Pressed192(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed192], this);
            }
        }

        public void Pressed193(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed193], this);
            }
        }

        public void Pressed194(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed194], this);
            }
        }

        public void Pressed195(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed195], this);
            }
        }

        public void Pressed196(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed196], this);
            }
        }

        public void Pressed197(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed197], this);
            }
        }

        public void Pressed198(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed198], this);
            }
        }

        public void Pressed199(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed199], this);
            }
        }

        public void Pressed200(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed200], this);
            }
        }

        public void Pressed201(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed201], this);
            }
        }

        public void Pressed202(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed202], this);
            }
        }

        public void Pressed203(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed203], this);
            }
        }

        public void Pressed204(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed204], this);
            }
        }

        public void Pressed205(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed205], this);
            }
        }

        public void Pressed206(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed206], this);
            }
        }

        public void Pressed207(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed207], this);
            }
        }

        public void Pressed208(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed208], this);
            }
        }

        public void Pressed209(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed209], this);
            }
        }

        public void Pressed210(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed210], this);
            }
        }

        public void Pressed211(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed211], this);
            }
        }

        public void Pressed212(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed212], this);
            }
        }

        public void Pressed213(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed213], this);
            }
        }

        public void Pressed214(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed214], this);
            }
        }

        public void Pressed215(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed215], this);
            }
        }

        public void Pressed216(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed216], this);
            }
        }

        public void Pressed217(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed217], this);
            }
        }

        public void Pressed218(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed218], this);
            }
        }

        public void Pressed219(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed219], this);
            }
        }

        public void Pressed220(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed220], this);
            }
        }

        public void Pressed221(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed221], this);
            }
        }

        public void Pressed222(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed222], this);
            }
        }

        public void Pressed223(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed223], this);
            }
        }

        public void Pressed224(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed224], this);
            }
        }

        public void Pressed225(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed225], this);
            }
        }

        public void Pressed226(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed226], this);
            }
        }

        public void Pressed227(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed227], this);
            }
        }

        public void Pressed228(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed228], this);
            }
        }

        public void Pressed229(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed229], this);
            }
        }

        public void Pressed230(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed230], this);
            }
        }

        public void Pressed231(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed231], this);
            }
        }

        public void Pressed232(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed232], this);
            }
        }

        public void Pressed233(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed233], this);
            }
        }

        public void Pressed234(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed234], this);
            }
        }

        public void Pressed235(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed235], this);
            }
        }

        public void Pressed236(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed236], this);
            }
        }

        public void Pressed237(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed237], this);
            }
        }

        public void Pressed238(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed238], this);
            }
        }

        public void Pressed239(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed239], this);
            }
        }

        public void Pressed240(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed240], this);
            }
        }

        public void Pressed241(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed241], this);
            }
        }

        public void Pressed242(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed242], this);
            }
        }

        public void Pressed243(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed243], this);
            }
        }

        public void Pressed244(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed244], this);
            }
        }

        public void Pressed245(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed245], this);
            }
        }

        public void Pressed246(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed246], this);
            }
        }

        public void Pressed247(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed247], this);
            }
        }

        public void Pressed248(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed248], this);
            }
        }

        public void Pressed249(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed249], this);
            }
        }

        public void Pressed0(ZonesBoolInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].BooleanInput[Joins.Booleans.Pressed0], this);
            }
        }


        public void Zone1(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone1], this);
            }
        }

        public void Zone2(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone2], this);
            }
        }

        public void Zone3(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone3], this);
            }
        }

        public void Zone4(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone4], this);
            }
        }

        public void Zone5(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone5], this);
            }
        }

        public void Zone6(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone6], this);
            }
        }

        public void Zone7(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone7], this);
            }
        }

        public void Zone8(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone8], this);
            }
        }

        public void Zone9(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone9], this);
            }
        }

        public void Zone10(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone10], this);
            }
        }

        public void Zone11(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone11], this);
            }
        }

        public void Zone12(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone12], this);
            }
        }

        public void Zone13(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone13], this);
            }
        }

        public void Zone14(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone14], this);
            }
        }

        public void Zone15(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone15], this);
            }
        }

        public void Zone16(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone16], this);
            }
        }

        public void Zone17(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone17], this);
            }
        }

        public void Zone18(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone18], this);
            }
        }

        public void Zone19(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone19], this);
            }
        }

        public void Zone20(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone20], this);
            }
        }

        public void Zone21(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone21], this);
            }
        }

        public void Zone22(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone22], this);
            }
        }

        public void Zone23(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone23], this);
            }
        }

        public void Zone24(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone24], this);
            }
        }

        public void Zone25(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone25], this);
            }
        }

        public void Zone26(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone26], this);
            }
        }

        public void Zone27(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone27], this);
            }
        }

        public void Zone28(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone28], this);
            }
        }

        public void Zone29(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone29], this);
            }
        }

        public void Zone30(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone30], this);
            }
        }

        public void Zone31(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone31], this);
            }
        }

        public void Zone32(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone32], this);
            }
        }

        public void Zone33(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone33], this);
            }
        }

        public void Zone34(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone34], this);
            }
        }

        public void Zone35(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone35], this);
            }
        }

        public void Zone36(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone36], this);
            }
        }

        public void Zone37(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone37], this);
            }
        }

        public void Zone38(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone38], this);
            }
        }

        public void Zone39(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone39], this);
            }
        }

        public void Zone40(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone40], this);
            }
        }

        public void Zone41(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone41], this);
            }
        }

        public void Zone42(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone42], this);
            }
        }

        public void Zone43(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone43], this);
            }
        }

        public void Zone44(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone44], this);
            }
        }

        public void Zone45(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone45], this);
            }
        }

        public void Zone46(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone46], this);
            }
        }

        public void Zone47(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone47], this);
            }
        }

        public void Zone48(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone48], this);
            }
        }

        public void Zone49(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone49], this);
            }
        }

        public void Zone50(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone50], this);
            }
        }

        public void Zone51(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone51], this);
            }
        }

        public void Zone52(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone52], this);
            }
        }

        public void Zone53(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone53], this);
            }
        }

        public void Zone54(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone54], this);
            }
        }

        public void Zone55(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone55], this);
            }
        }

        public void Zone56(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone56], this);
            }
        }

        public void Zone57(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone57], this);
            }
        }

        public void Zone58(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone58], this);
            }
        }

        public void Zone59(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone59], this);
            }
        }

        public void Zone60(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone60], this);
            }
        }

        public void Zone61(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone61], this);
            }
        }

        public void Zone62(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone62], this);
            }
        }

        public void Zone63(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone63], this);
            }
        }

        public void Zone64(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone64], this);
            }
        }

        public void Zone65(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone65], this);
            }
        }

        public void Zone66(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone66], this);
            }
        }

        public void Zone67(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone67], this);
            }
        }

        public void Zone68(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone68], this);
            }
        }

        public void Zone69(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone69], this);
            }
        }

        public void Zone70(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone70], this);
            }
        }

        public void Zone71(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone71], this);
            }
        }

        public void Zone72(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone72], this);
            }
        }

        public void Zone73(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone73], this);
            }
        }

        public void Zone74(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone74], this);
            }
        }

        public void Zone75(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone75], this);
            }
        }

        public void Zone76(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone76], this);
            }
        }

        public void Zone77(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone77], this);
            }
        }

        public void Zone78(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone78], this);
            }
        }

        public void Zone79(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone79], this);
            }
        }

        public void Zone80(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone80], this);
            }
        }

        public void Zone81(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone81], this);
            }
        }

        public void Zone82(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone82], this);
            }
        }

        public void Zone83(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone83], this);
            }
        }

        public void Zone84(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone84], this);
            }
        }

        public void Zone85(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone85], this);
            }
        }

        public void Zone86(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone86], this);
            }
        }

        public void Zone87(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone87], this);
            }
        }

        public void Zone88(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone88], this);
            }
        }

        public void Zone89(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone89], this);
            }
        }

        public void Zone90(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone90], this);
            }
        }

        public void Zone91(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone91], this);
            }
        }

        public void Zone92(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone92], this);
            }
        }

        public void Zone93(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone93], this);
            }
        }

        public void Zone94(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone94], this);
            }
        }

        public void Zone95(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone95], this);
            }
        }

        public void Zone96(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone96], this);
            }
        }

        public void Zone97(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone97], this);
            }
        }

        public void Zone98(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone98], this);
            }
        }

        public void Zone99(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone99], this);
            }
        }

        public void Zone100(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone100], this);
            }
        }

        public void Zone101(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone101], this);
            }
        }

        public void Zone102(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone102], this);
            }
        }

        public void Zone103(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone103], this);
            }
        }

        public void Zone104(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone104], this);
            }
        }

        public void Zone105(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone105], this);
            }
        }

        public void Zone106(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone106], this);
            }
        }

        public void Zone107(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone107], this);
            }
        }

        public void Zone108(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone108], this);
            }
        }

        public void Zone109(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone109], this);
            }
        }

        public void Zone110(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone110], this);
            }
        }

        public void Zone111(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone111], this);
            }
        }

        public void Zone112(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone112], this);
            }
        }

        public void Zone113(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone113], this);
            }
        }

        public void Zone114(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone114], this);
            }
        }

        public void Zone115(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone115], this);
            }
        }

        public void Zone116(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone116], this);
            }
        }

        public void Zone117(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone117], this);
            }
        }

        public void Zone118(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone118], this);
            }
        }

        public void Zone119(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone119], this);
            }
        }

        public void Zone120(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone120], this);
            }
        }

        public void Zone121(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone121], this);
            }
        }

        public void Zone122(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone122], this);
            }
        }

        public void Zone123(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone123], this);
            }
        }

        public void Zone124(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone124], this);
            }
        }

        public void Zone125(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone125], this);
            }
        }

        public void Zone126(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone126], this);
            }
        }

        public void Zone127(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone127], this);
            }
        }

        public void Zone128(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone128], this);
            }
        }

        public void Zone129(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone129], this);
            }
        }

        public void Zone130(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone130], this);
            }
        }

        public void Zone131(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone131], this);
            }
        }

        public void Zone132(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone132], this);
            }
        }

        public void Zone133(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone133], this);
            }
        }

        public void Zone134(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone134], this);
            }
        }

        public void Zone135(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone135], this);
            }
        }

        public void Zone136(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone136], this);
            }
        }

        public void Zone137(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone137], this);
            }
        }

        public void Zone138(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone138], this);
            }
        }

        public void Zone139(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone139], this);
            }
        }

        public void Zone140(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone140], this);
            }
        }

        public void Zone141(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone141], this);
            }
        }

        public void Zone142(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone142], this);
            }
        }

        public void Zone143(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone143], this);
            }
        }

        public void Zone144(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone144], this);
            }
        }

        public void Zone145(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone145], this);
            }
        }

        public void Zone146(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone146], this);
            }
        }

        public void Zone147(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone147], this);
            }
        }

        public void Zone148(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone148], this);
            }
        }

        public void Zone149(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone149], this);
            }
        }

        public void Zone150(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone150], this);
            }
        }

        public void Zone151(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone151], this);
            }
        }

        public void Zone152(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone152], this);
            }
        }

        public void Zone153(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone153], this);
            }
        }

        public void Zone154(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone154], this);
            }
        }

        public void Zone155(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone155], this);
            }
        }

        public void Zone156(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone156], this);
            }
        }

        public void Zone157(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone157], this);
            }
        }

        public void Zone158(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone158], this);
            }
        }

        public void Zone159(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone159], this);
            }
        }

        public void Zone160(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone160], this);
            }
        }

        public void Zone161(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone161], this);
            }
        }

        public void Zone162(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone162], this);
            }
        }

        public void Zone163(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone163], this);
            }
        }

        public void Zone164(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone164], this);
            }
        }

        public void Zone165(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone165], this);
            }
        }

        public void Zone166(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone166], this);
            }
        }

        public void Zone167(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone167], this);
            }
        }

        public void Zone168(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone168], this);
            }
        }

        public void Zone169(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone169], this);
            }
        }

        public void Zone170(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone170], this);
            }
        }

        public void Zone171(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone171], this);
            }
        }

        public void Zone172(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone172], this);
            }
        }

        public void Zone173(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone173], this);
            }
        }

        public void Zone174(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone174], this);
            }
        }

        public void Zone175(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone175], this);
            }
        }

        public void Zone176(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone176], this);
            }
        }

        public void Zone177(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone177], this);
            }
        }

        public void Zone178(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone178], this);
            }
        }

        public void Zone179(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone179], this);
            }
        }

        public void Zone180(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone180], this);
            }
        }

        public void Zone181(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone181], this);
            }
        }

        public void Zone182(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone182], this);
            }
        }

        public void Zone183(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone183], this);
            }
        }

        public void Zone184(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone184], this);
            }
        }

        public void Zone185(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone185], this);
            }
        }

        public void Zone186(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone186], this);
            }
        }

        public void Zone187(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone187], this);
            }
        }

        public void Zone188(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone188], this);
            }
        }

        public void Zone189(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone189], this);
            }
        }

        public void Zone190(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone190], this);
            }
        }

        public void Zone191(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone191], this);
            }
        }

        public void Zone192(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone192], this);
            }
        }

        public void Zone193(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone193], this);
            }
        }

        public void Zone194(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone194], this);
            }
        }

        public void Zone195(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone195], this);
            }
        }

        public void Zone196(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone196], this);
            }
        }

        public void Zone197(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone197], this);
            }
        }

        public void Zone198(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone198], this);
            }
        }

        public void Zone199(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone199], this);
            }
        }

        public void Zone200(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone200], this);
            }
        }

        public void Zone201(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone201], this);
            }
        }

        public void Zone202(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone202], this);
            }
        }

        public void Zone203(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone203], this);
            }
        }

        public void Zone204(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone204], this);
            }
        }

        public void Zone205(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone205], this);
            }
        }

        public void Zone206(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone206], this);
            }
        }

        public void Zone207(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone207], this);
            }
        }

        public void Zone208(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone208], this);
            }
        }

        public void Zone209(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone209], this);
            }
        }

        public void Zone210(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone210], this);
            }
        }

        public void Zone211(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone211], this);
            }
        }

        public void Zone212(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone212], this);
            }
        }

        public void Zone213(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone213], this);
            }
        }

        public void Zone214(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone214], this);
            }
        }

        public void Zone215(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone215], this);
            }
        }

        public void Zone216(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone216], this);
            }
        }

        public void Zone217(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone217], this);
            }
        }

        public void Zone218(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone218], this);
            }
        }

        public void Zone219(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone219], this);
            }
        }

        public void Zone220(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone220], this);
            }
        }

        public void Zone221(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone221], this);
            }
        }

        public void Zone222(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone222], this);
            }
        }

        public void Zone223(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone223], this);
            }
        }

        public void Zone224(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone224], this);
            }
        }

        public void Zone225(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone225], this);
            }
        }

        public void Zone226(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone226], this);
            }
        }

        public void Zone227(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone227], this);
            }
        }

        public void Zone228(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone228], this);
            }
        }

        public void Zone229(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone229], this);
            }
        }

        public void Zone230(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone230], this);
            }
        }

        public void Zone231(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone231], this);
            }
        }

        public void Zone232(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone232], this);
            }
        }

        public void Zone233(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone233], this);
            }
        }

        public void Zone234(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone234], this);
            }
        }

        public void Zone235(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone235], this);
            }
        }

        public void Zone236(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone236], this);
            }
        }

        public void Zone237(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone237], this);
            }
        }

        public void Zone238(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone238], this);
            }
        }

        public void Zone239(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone239], this);
            }
        }

        public void Zone240(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone240], this);
            }
        }

        public void Zone241(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone241], this);
            }
        }

        public void Zone242(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone242], this);
            }
        }

        public void Zone243(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone243], this);
            }
        }

        public void Zone244(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone244], this);
            }
        }

        public void Zone245(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone245], this);
            }
        }

        public void Zone246(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone246], this);
            }
        }

        public void Zone247(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone247], this);
            }
        }

        public void Zone248(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone248], this);
            }
        }

        public void Zone249(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone249], this);
            }
        }

        public void Zone0(ZonesStringInputSigDelegate callback)
        {
            for (int index = 0; index < Devices.Count; index++)
            {
                callback(Devices[index].SmartObjects[ControlJoinId].StringInput[Joins.Strings.Zone0], this);
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
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "Zones", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

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
            Press189 = null;
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
            Press0 = null;
            Save_Area = null;
        }

        #endregion

    }
}
