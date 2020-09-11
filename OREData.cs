﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE_SSS
{
    public class ORE
    {
        public Dictionary<string, int> mineral;
        public bool isMain;
        public int id;
        public int typeID;
        public int price;
        public float ratio;
        public ORE(
               int type_id,
               int a,
               int b,
               int c,
               int d,
               int e,
               int f,
               int g,
               int h,bool ismain = false,int price = 0,float ratio = 1.0f)
        {
            mineral = new Dictionary<string, int>()
            {
                { "三钛合金",a},
                { "类晶体胶矿",b},
                { "类银超金属",c},
                { "同位聚合体",d},
                { "超星诺克石",e},
                { "晶状石英岩",f},
                { "超噬矿",g},
                { "莫尔石",h},
            };
            isMain = ismain;
            this.price = price;
            this.ratio = ratio;
            this.typeID = type_id;
        }
    }

    public class OREDictionary
    {
        public Dictionary<string, ORE> ORE_Dictionary { get; private set; }
        public OREDictionary()
        {
            ORE_Dictionary = new Dictionary<string, ORE>(){
                {"高密度玻璃化基腹断岩",new ORE(28414,0,0,0,0,0,0,0,330)},
                {"高密度基腹断岩岩浆",new ORE(28412,0,0,0,0,0,0,0,315)},
                {"高密度基腹断岩",new ORE(28413,0,0,0,0,0,0,0,300,true,3098000)},

                //{"高密度洁净杰斯贝矿",new ORE(46698,0,0,403,0,86,9,0,0)},
                {"高密度朴质杰斯贝矿",new ORE(28407,0,0,385,0,83,9,0,0)},
                {"高密度纯杰斯贝矿",new ORE(28408,0,0,368,0,79,8,0,0)},
                {"高密度杰斯贝矿",new ORE(28406,0,0,350,0,75,8,0,0,true,175000)},

                //{"高密度光辉同位原矿",new ORE(46696,0,1150,0,230,115,22,0,0)},
                {"高密度光面同位原矿",new ORE(28400,0,1100,0,220,110,21,0,0)},
                {"高密度玻璃状同位原矿",new ORE(28402,0,1050,0,210,105,20,0,0)},
                {"高密度同位原矿",new ORE(28401,0,1000,0,200,100,19,0,0,true,156000)},

                //{"高密度华丽水硼砂",new ORE(46699,154,0,307,154,0,0,0,0)},
                {"高密度灼热水硼砂",new ORE(28409,148,0,294,148,0,0,0,0)},
                {"高密度发光水硼砂",new ORE(28411,141,0,281,141,0,0,0,0)},
                {"高密度水硼砂",new ORE(28410,134,0,267,134,0,0,0,0,true,61880)},

                //{"高密度光辉片麻岩",new ORE(46695,0,2530,2760,345,0,0,0,0)},
                {"高密度棱柱片麻岩",new ORE(28399,0,2420,2640,330,0,0,0,0)},
                {"高密度彩色片麻岩",new ORE(28398,0,2310,2520,315,0,0,0,0)},
                {"高密度片麻岩",new ORE(28397,0,2200,2400,300,0,0,0,0,true,661000)},

                //{"高密度闪烁希莫非特",new ORE(46697,2530,0,0,115,138,17,0,0)},
                {"高密度辐射希莫非特",new ORE(28404,2420,0,0,110,132,17,0,0)},
                {"高密度多色希莫非特",new ORE(28405,2310,0,0,105,126,16,0,0)},
                {"高密度希莫非特",new ORE(28403,2200,0,0,100,120,15,0,0,true,200000)},

                //{"高密度双多特石立方体",new ORE(46692,0,13800,0,0,0,518,115,0)},
                {"高密度单晶双多特斜岩",new ORE(28389,0,13200,0,0,0,495,110,0)},
                {"高密度三晶双多特斜岩",new ORE(28390,0,12600,0,0,0,473,105,0)},
                {"高密度双多特石",new ORE(28388,0,12000,0,0,0,450,100,0,true,740800)},

                //{"高密度透明克洛基石",new ORE(46693,24150,0,0,0,874,155,0,0)},
                {"高密度克洛基水晶",new ORE(28392,23100,0,0,0,836,149,0,0)},
                {"高密度斜克洛基石",new ORE(28393,22050,0,0,0,798,142,0,0)},
                {"高密度克洛基石",new ORE(28391,21000,0,0,0,760,135,0,0,true,6900000)},

                //{"高密度闪耀斜长岩",new ORE(0,123,245,123,0,0,0,0,0)},
                {"高密度富斜长岩",new ORE(28423,118,235,118,0,0,0,0,0)},
                {"高密度蓝色斜长岩",new ORE(28421,113,224,113,0,0,0,0,0)},
                {"高密度斜长岩",new ORE(28422,107,213,107,0,0,0,0,0,true,17990)},

                //{"高密度无暇艾克诺岩",new ORE(0,25300,0,2875,0,0,0,368,0)},
                {"高密度艾克诺精华岩",new ORE(28387,24200,0,2750,0,0,0,352,0)},
                {"高密度红色艾克诺岩",new ORE(28385,23100,0,2625,0,0,0,336,0)},
                {"高密度艾克诺岩",new ORE(28367,22000,0,2500,0,0,0,320,0,true,1231000)},

                //{"高密度丰裕干焦岩",new ORE(0,404,29,58,0,6,0,0,0)},
                {"高密度流体干焦岩",new ORE(28426,387,27,55,0,5,0,0,0)},
                {"高密度固体干焦岩",new ORE(28425,369,26,53,0,5,0,0,0)},
                {"高密度干焦岩",new ORE(28424,351,25,50,0,5,0,0,0,true,16400)},

                //{"高密度墨黑赭石",new ORE(0,11500,0,0,1840,138,0,0,0)},
                {"高密度黑曜赭石",new ORE(28395,11000,0,0,1760,132,0,0,0)},
                {"高密度条纹赭",new ORE(28396,10500,0,0,1680,126,0,0,0)},
                {"高密度黑赭石",new ORE(28394,10000,0,0,1600,120,0,0,0,true,358600)},

                //{"高密度铂族奥贝尔石",new ORE(0,920,115,0,98,0,0,0,0)},
                {"高密度金色奥贝尔石",new ORE(28415,880,110,0,94,0,0,0,0)},
                {"高密度银色奥贝尔石",new ORE(28417,840,105,0,90,0,0,0,0)},
                {"高密度奥贝尔石",new ORE(28416,800,100,0,85,0,0,0,0,true,17990)},

                //{"高密度璀璨灰岩",new ORE(0,64400,13858,2415,518,0,0,0,0)},
                {"高密度发光灰岩",new ORE(28419,61600,13255,2310,495,0,0,0,0)},
                {"高密度亮灰岩",new ORE(28418,58800,12653,2205,473,0,0,0,0)},
                {"高密度灰岩",new ORE(28420,56000,12050,2100,450,0,0,0,0,true,1400000)},

                //{"高密度坚固凡晶石",new ORE(0,477,0,0,0,0,0,0,0)},
                {"高密度厚质凡晶石",new ORE(28431,457,0,0,0,0,0,0,0)},
                {"高密度富凡晶石",new ORE(28430,436,0,0,0,0,0,0,0)},
                {"高密度凡晶石",new ORE(28432,415,0,0,0,0,0,0,0,true,5434)},

                //{"高密度光泽灼烧岩",new ORE(0,398,199,0,0,0,0,0,0)},
                {"高密度浓缩灼烧岩",new ORE(28427,364,182,0,0,0,0,0,0)},
                {"高密度厚灼烧岩",new ORE(28428,381,190,0,0,0,0,0,0)},
                {"高密度灼烧岩",new ORE(28429,346,173,0,0,0,0,0,0,true,5094)}};

        }
    }
}
