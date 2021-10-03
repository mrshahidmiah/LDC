using LDC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace StringProcessorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringProcessor sp = new StringProcessor();
            string expected = "Ac91%cWwWkLq£1c";
            string actual = sp.Process("AAAc91%cWwWkLq$1ci3_848v3d__K");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("unm_$£2uzzle", "unm£2uzle")]
        [DataRow("6cal%ibers", "6cal%ibers")]
        [DataRow("mi4s-gr0ow", "mis-gr0ow")]
        [DataRow("deco#ladyh0ood", "deco#ladyh0od")]
        [DataRow("gal8lnuts", "gal8lnuts")]
        [DataRow("ul6ti$mas", "ul6ti£mas")]
        [DataRow("d4ism$2ally", "dism£2aly")]
        [DataRow("roo0£fing", "ro0£fing")]
        [DataRow("co#nfo%rm", "co#nfo%rm")]
        [DataRow("hom6e!spun", "hom6e!spun")]
        [DataRow("r$workinth£dark!", "r£workinth£dark")]
        [DataRow("an-ti_c$ipation", "an-tic£ipation")]
        [DataRow("rhetorica4lly", "rhetoricaly")]
        [DataRow("ins#t6%rument4", "ins#t6%rument")]
        [DataRow("innov8_£2ation", "inov8£2ation")]
        [DataRow("raw$12_34", "raw£123")]
        [DataRow("chargeb__rigade52", "chargebrigade52")]
        [DataRow("e8fflux", "e8flux")]
        [DataRow("le04ase", "le0ase")]
        [DataRow("em-brace", "em-brace")]
        [DataRow("reco__v$6%er", "recov£6%er")]
        [DataRow("fail#£action", "fail#£action")]
        [DataRow("be84l$l", "be8l£l")]
        [DataRow("charac$t%eristically", "charac£t%eristi")]
        [DataRow("in-c1u__bate", "in-c1ubate")]
        [DataRow("muciferous", "muciferous")]
        [DataRow("phot4ogram%metry", "photogram%metry")]
        [DataRow("nonpro__6$lif%erous", "nonpro6£lif%ero")]
        [DataRow("lymp8h£atolysis", "lymp8h£atolysis")]
        [DataRow("unenn4$#obling", "unen£#obling")]
        [DataRow("non-roma$nticism", "non-roma£nticis")]
        [DataRow("exc0la48mational", "exc0la8mational")]
        [DataRow("disput_abl$y", "disputabl£y")]
        [DataRow("photo-di4ss%ociation", "photo-dis%ociat")]
        [DataRow("ungoth#ic_", "ungoth#ic")]
        [DataRow("_hyp1no$ge2netic", "hyp1no£ge2netic")]
        [DataRow("theo4log8ical", "theolog8ical")]
        [DataRow("over4ce$nt_ralization", "overce£ntraliza")]
        [DataRow("catacumba", "catacumba")]
        [DataRow("soci7a$lity", "soci7a£lity")]
        [DataRow("cuncta£t6or", "cuncta£t6or")]
        [DataRow("archaeo$#zoi%c", "archaeo£#zoi%c")]
        [DataRow("zoo-che$mical", "zo-che£mical")]
        [DataRow("dead_-_panning", "dead-paning")]
        [DataRow("undem4_ocrati%ze", "undemocrati%ze")]
        [DataRow("ring$w_ood", "ring£wod")]
        [DataRow("spa$ciou£#6s", "spa£ciou£#6s")]
        [DataRow("ba___rbec2ui$ng", "barbec2ui£ng")]
        [DataRow("in-curri%ng", "in-curi%ng")]
        [DataRow("habit$41uated", "habit£1uated")]
        [DataRow("wester#lin#ess", "wester#lin#es")]
        [DataRow("heart-bro%kenly", "heart-bro%kenly")]
        [DataRow("cho47ragic", "cho7ragic")]
        [DataRow("_d_$eciar£e", "d£eciar£e")]
        [DataRow("blo_cki6est6", "blocki6est6")]
        [DataRow("inte4%rt$ransfo#rmable", "inte%rt£ransfo#")]
        [DataRow("para3psyc#holog4ical", "para3psyc#holog")]
        [DataRow("chr£om%_ophotograph", "chr£om%ophotogr")]
        [DataRow("an$ti_e2duc%ationalist", "an£tie2duc%atio")]
        [DataRow("thoro#ug$hbred#ness", "thoro#ug£hbred#")]
        [DataRow("evolutio0n%isti4cally", "evolutio0n%isti")]
        [DataRow("disa%gre9e_ableness", "disa%gre9eablen")]
        [DataRow("super4£not$#ableness", "super£not£#able")]
        [DataRow("tele$co5mmu-nications", "tele£co5mu-nica")]
        [DataRow("semi#p3roducti_v4ity", "semi#p3roductiv")]

        public void TestMethodMulti(string a, string b)
        {
            StringProcessor sp = new StringProcessor();            
            Assert.AreEqual(b, sp.Process(a));
        }
    }
}
