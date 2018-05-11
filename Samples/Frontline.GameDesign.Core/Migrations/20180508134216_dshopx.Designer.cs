﻿// <auto-generated />
using Frontline.GameDesign;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Collections.Generic;

namespace Frontline.GameDesign.Core.Migrations
{
    [DbContext(typeof(GameDesignContext))]
    [Migration("20180508134216_dshopx")]
    partial class dshopx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Frontline.GameDesign.DArenaChallengeReward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("random_id");

                    b.Property<int>("times");

                    b.HasKey("id");

                    b.ToTable("DArenaChallengeReward");
                });

            modelBuilder.Entity("Frontline.GameDesign.DArenaRankReward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<JsonObject<Int32[]>>("items_cnt");

                    b.Property<JsonObject<Int32[]>>("items_id");

                    b.Property<int>("random_id");

                    b.Property<JsonObject<Int32[]>>("rank_area");

                    b.HasKey("id");

                    b.ToTable("DArenaRankReward");
                });

            modelBuilder.Entity("Frontline.GameDesign.DDiKangQianXian", b =>
                {
                    b.Property<int>("wid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("command");

                    b.Property<int>("dungeon_id");

                    b.Property<int>("token");

                    b.HasKey("wid");

                    b.ToTable("DDiKangQianXian");
                });

            modelBuilder.Entity("Frontline.GameDesign.DDiKangQianXianBox", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("box");

                    b.Property<int>("wid");

                    b.HasKey("id");

                    b.ToTable("DDiKangQianXianBox");
                });

            modelBuilder.Entity("Frontline.GameDesign.DDiKangQianXianBuilding", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("defence");

                    b.Property<int>("hp");

                    b.HasKey("id");

                    b.ToTable("DDiKangQianXianBuilding");
                });

            modelBuilder.Entity("Frontline.GameDesign.DDungeon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("desc")
                        .HasMaxLength(32);

                    b.Property<JsonObject<List<int>>>("drop_items")
                        .HasMaxLength(128);

                    b.Property<int>("exp");

                    b.Property<int>("exp_element");

                    b.Property<int>("fight_times");

                    b.Property<int>("gold");

                    b.Property<string>("icon")
                        .HasMaxLength(32);

                    b.Property<int>("level_limit");

                    b.Property<string>("map_fighting")
                        .HasMaxLength(32);

                    b.Property<string>("map_file_name")
                        .HasMaxLength(32);

                    b.Property<string>("map_res_name")
                        .HasMaxLength(32);

                    b.Property<int>("mission");

                    b.Property<string>("name")
                        .HasMaxLength(32);

                    b.Property<int>("next");

                    b.Property<int>("oil_cost");

                    b.Property<int>("power");

                    b.Property<int>("random_id");

                    b.Property<string>("screen_id")
                        .HasMaxLength(32);

                    b.Property<int>("section");

                    b.Property<string>("section_name")
                        .HasMaxLength(32);

                    b.Property<int>("time_limit_1");

                    b.Property<int>("time_limit_2");

                    b.Property<int>("time_limit_3");

                    b.Property<int>("type")
                        .HasMaxLength(32);

                    b.Property<string>("type_name")
                        .HasMaxLength(32);

                    b.Property<int>("wipe_cost");

                    b.HasKey("id");

                    b.HasIndex("section", "type");

                    b.ToTable("DDungeon");
                });

            modelBuilder.Entity("Frontline.GameDesign.DDungeonStar", b =>
                {
                    b.Property<int>("type");

                    b.Property<int>("section");

                    b.Property<int>("index");

                    b.Property<int>("res_count");

                    b.Property<int>("res_type");

                    b.Property<int>("star");

                    b.HasKey("type", "section", "index");

                    b.ToTable("DDungeonStar");
                });

            modelBuilder.Entity("Frontline.GameDesign.DEquip", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("base_attr_type");

                    b.Property<float>("base_attr_value");

                    b.Property<int>("gradeid");

                    b.Property<float>("level_grow");

                    b.Property<int>("level_k");

                    b.Property<int>("pos");

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.ToTable("DEquip");
                });

            modelBuilder.Entity("Frontline.GameDesign.DEquipGrade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("grade");

                    b.Property<float>("grade_grow");

                    b.Property<JsonObject<Int32[]>>("grade_item_cnt");

                    b.Property<JsonObject<Int32[]>>("grade_item_id");

                    b.Property<JsonObject<Int32[]>>("grade_res_cnt");

                    b.Property<JsonObject<Int32[]>>("grade_res_type");

                    b.Property<int>("max_level");

                    b.Property<int>("next_id");

                    b.HasKey("id");

                    b.ToTable("DEquipGrade");
                });

            modelBuilder.Entity("Frontline.GameDesign.DEquipLevelCost", b =>
                {
                    b.Property<int>("level")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("soldier_gold");

                    b.Property<int>("tank_gold");

                    b.HasKey("level");

                    b.ToTable("DEquipLevelCost");
                });

            modelBuilder.Entity("Frontline.GameDesign.DFacTask", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("cost_item_cnt");

                    b.Property<int>("cost_item_id");

                    b.Property<int>("cost_time");

                    b.Property<int>("done_item_cnt");

                    b.Property<int>("done_item_id");

                    b.Property<int>("group");

                    b.Property<JsonObject<Int32[]>>("item_cnt");

                    b.Property<JsonObject<Int32[]>>("item_cnt_ex");

                    b.Property<JsonObject<Int32[]>>("item_id_ex");

                    b.Property<JsonObject<Int32[]>>("item_type");

                    b.Property<int>("res_cnt");

                    b.Property<int>("res_type");

                    b.Property<float>("reward_ex_prob");

                    b.Property<int>("star");

                    b.Property<int>("type");

                    b.Property<int>("w");

                    b.Property<int>("worker_num");

                    b.Property<int>("worker_q");

                    b.HasKey("id");

                    b.ToTable("DFacTask");
                });

            modelBuilder.Entity("Frontline.GameDesign.DFacTaskGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("gourp_supply");

                    b.Property<int>("group_iron");

                    b.Property<int>("max_level");

                    b.Property<int>("min_level");

                    b.HasKey("id");

                    b.ToTable("DFacTaskGroup");
                });

            modelBuilder.Entity("Frontline.GameDesign.DFacWorker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("itemes_p");

                    b.Property<int>("output_p");

                    b.Property<int>("res_cnt");

                    b.Property<int>("res_type");

                    b.Property<int>("star");

                    b.Property<int>("type");

                    b.Property<int>("weight");

                    b.HasKey("id");

                    b.ToTable("DFacWorker");
                });

            modelBuilder.Entity("Frontline.GameDesign.DGameConfig", b =>
                {
                    b.Property<string>("field_name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("desc")
                        .HasMaxLength(64);

                    b.Property<string>("field_value")
                        .HasMaxLength(1024);

                    b.HasKey("field_name");

                    b.ToTable("DGameConfig");
                });

            modelBuilder.Entity("Frontline.GameDesign.DItem", b =>
                {
                    b.Property<int>("tid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("bag_type");

                    b.Property<int>("breakCount");

                    b.Property<int>("breakRandomId");

                    b.Property<int>("breakUnitId");

                    b.Property<TimeSpan?>("cd");

                    b.Property<string>("desc")
                        .HasMaxLength(64);

                    b.Property<int>("diamond");

                    b.Property<int>("icon");

                    b.Property<string>("name")
                        .HasMaxLength(32);

                    b.Property<int>("overlap");

                    b.Property<int>("price");

                    b.Property<int>("quality");

                    b.Property<int>("type");

                    b.Property<bool>("useable");

                    b.Property<int>("worth");

                    b.HasKey("tid");

                    b.ToTable("DItem");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLegion", b =>
                {
                    b.Property<int>("level")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("def_player_cnt");

                    b.Property<int>("exp");

                    b.Property<float>("glv_add");

                    b.Property<int>("max");

                    b.HasKey("level");

                    b.ToTable("DLegion");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLegionDonate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("contri");

                    b.Property<int>("cost");

                    b.Property<int>("exp_party");

                    b.Property<string>("name")
                        .HasMaxLength(64);

                    b.Property<int>("party_coin");

                    b.Property<int>("party_contri");

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.ToTable("DLegionDonate");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLegionScience", b =>
                {
                    b.Property<int>("id");

                    b.Property<int>("lv");

                    b.Property<int>("atk");

                    b.Property<int>("damage");

                    b.Property<int>("damage_del");

                    b.Property<int>("def");

                    b.Property<string>("desc")
                        .HasMaxLength(64);

                    b.Property<int>("hp");

                    b.Property<int>("icon");

                    b.Property<JsonObject<Int32[]>>("item_cnt");

                    b.Property<JsonObject<Int32[]>>("item_id");

                    b.Property<int>("legion_lv");

                    b.Property<string>("name")
                        .HasMaxLength(64);

                    b.Property<JsonObject<Int32[]>>("res_cnt");

                    b.Property<JsonObject<Int32[]>>("res_type");

                    b.Property<JsonObject<Int32[]>>("unit_scope");

                    b.HasKey("id", "lv");

                    b.ToTable("DLegionScience");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLevel", b =>
                {
                    b.Property<int>("level")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("buy_gold");

                    b.Property<int>("exp");

                    b.HasKey("level");

                    b.ToTable("DLevel");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLottery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("cost_item");

                    b.Property<int>("cost_res_cnt");

                    b.Property<int>("cost_res_type");

                    b.Property<int>("free_cd");

                    b.Property<int>("free_cnt");

                    b.Property<string>("name")
                        .HasMaxLength(32);

                    b.Property<int>("rand");

                    b.Property<int>("rand_first10");

                    b.Property<int>("rand_sp");

                    b.Property<int>("ten_discount");

                    b.HasKey("id");

                    b.ToTable("DLottery");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLotteryGroup", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<JsonObject<Int32[]>>("group");

                    b.Property<JsonObject<Int32[]>>("group_w");

                    b.HasKey("id");

                    b.ToTable("DLotteryGroup");
                });

            modelBuilder.Entity("Frontline.GameDesign.DLotteryRand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("group");

                    b.Property<int>("item_cnt");

                    b.Property<int>("item_id");

                    b.Property<int>("lv_max");

                    b.Property<int>("lv_min");

                    b.Property<int>("w");

                    b.HasKey("id");

                    b.ToTable("DLotteryRand");
                });

            modelBuilder.Entity("Frontline.GameDesign.DMallShop", b =>
                {
                    b.Property<int>("type")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("diamond");

                    b.Property<string>("name")
                        .HasMaxLength(64);

                    b.Property<bool>("refresh");

                    b.Property<JsonObject<Int32[]>>("refresh_hour");

                    b.Property<JsonObject<Int32[]>>("res_type");

                    b.HasKey("type");

                    b.ToTable("DMallShop");
                });

            modelBuilder.Entity("Frontline.GameDesign.DMallShopItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("commodity_stock");

                    b.Property<int>("cost_res_cnt");

                    b.Property<int>("cost_res_type");

                    b.Property<string>("desc")
                        .HasMaxLength(64);

                    b.Property<int>("item_cnt");

                    b.Property<int>("item_id");

                    b.Property<int>("level_max");

                    b.Property<int>("level_min");

                    b.Property<int>("order");

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.ToTable("DMallShopItem");
                });

            modelBuilder.Entity("Frontline.GameDesign.DMonster", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("armor");

                    b.Property<int>("att");

                    b.Property<string>("att_effect")
                        .HasMaxLength(32);

                    b.Property<int>("bullet_count");

                    b.Property<float>("cd");

                    b.Property<int>("count");

                    b.Property<float>("crit");

                    b.Property<float>("crit_hurt");

                    b.Property<int>("defence");

                    b.Property<string>("desc")
                        .HasMaxLength(64);

                    b.Property<string>("die_model")
                        .HasMaxLength(32);

                    b.Property<float>("distance");

                    b.Property<int>("energy");

                    b.Property<int>("hp");

                    b.Property<float>("hurt_add");

                    b.Property<float>("hurt_multiple");

                    b.Property<float>("hurt_sub");

                    b.Property<float>("last_time");

                    b.Property<int>("lv");

                    b.Property<string>("model")
                        .HasMaxLength(32);

                    b.Property<string>("move_effect")
                        .HasMaxLength(32);

                    b.Property<string>("name")
                        .HasMaxLength(32);

                    b.Property<int>("nation");

                    b.Property<float>("off");

                    b.Property<float>("r");

                    b.Property<float>("rev");

                    b.Property<float>("rev_body");

                    b.Property<float>("scale");

                    b.Property<float>("speed");

                    b.Property<int>("type");

                    b.Property<int>("type_detail");

                    b.HasKey("id");

                    b.ToTable("DMonster");
                });

            modelBuilder.Entity("Frontline.GameDesign.DMonsterAbility", b =>
                {
                    b.Property<int>("level")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("s_atk");

                    b.Property<float>("s_def");

                    b.Property<float>("s_hp");

                    b.Property<float>("t_atk");

                    b.Property<float>("t_def");

                    b.Property<float>("t_hp");

                    b.HasKey("level");

                    b.ToTable("DMonsterAbility");
                });

            modelBuilder.Entity("Frontline.GameDesign.DMonsterInDungeon", b =>
                {
                    b.Property<int>("dungeon_id");

                    b.Property<int>("mid");

                    b.Property<string>("Id");

                    b.Property<int>("level");

                    b.HasKey("dungeon_id", "mid");

                    b.ToTable("DMonsterInDungeon");
                });

            modelBuilder.Entity("Frontline.GameDesign.DName", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsedNumber");

                    b.HasKey("Name");

                    b.ToTable("DName");
                });

            modelBuilder.Entity("Frontline.GameDesign.DOlReward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<JsonObject<Int32[]>>("adv_cnt");

                    b.Property<JsonObject<Int32[]>>("adv_id");

                    b.Property<JsonObject<Int32[]>>("low_cnt");

                    b.Property<JsonObject<Int32[]>>("low_id");

                    b.Property<int>("t");

                    b.Property<TimeSpan>("time");

                    b.HasKey("id");

                    b.ToTable("DOlReward");
                });

            modelBuilder.Entity("Frontline.GameDesign.DQuest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("condition_target");

                    b.Property<int>("condition_type");

                    b.Property<int>("index");

                    b.Property<int>("limit_level");

                    b.Property<int>("max_progress");

                    b.Property<int>("next_quest_id");

                    b.Property<int>("res_diamond");

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.ToTable("DQuest");
                });

            modelBuilder.Entity("Frontline.GameDesign.DQuestDaily", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("condition_target");

                    b.Property<int>("condition_type");

                    b.Property<JsonObject<Int32[]>>("level_area");

                    b.Property<int>("max_progress");

                    b.Property<int>("quest_point");

                    b.Property<int>("res_exp");

                    b.Property<int>("reward_ID");

                    b.Property<int>("reward_num");

                    b.Property<int>("reward_type");

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.ToTable("DQuestDaily");
                });

            modelBuilder.Entity("Frontline.GameDesign.DQuestDailyReward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("item_id");

                    b.Property<JsonObject<Int32[]>>("lv");

                    b.Property<int>("point");

                    b.HasKey("id");

                    b.ToTable("DQuestDailyReward");
                });

            modelBuilder.Entity("Frontline.GameDesign.DRaffle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("drop");

                    b.Property<int>("item_cnt_max");

                    b.Property<int>("item_cnt_min");

                    b.Property<int>("item_id");

                    b.Property<bool>("special");

                    b.Property<int>("star");

                    b.Property<int>("w_0");

                    b.Property<int>("w_1");

                    b.Property<int>("w_2");

                    b.HasKey("id");

                    b.ToTable("DRaffle");
                });

            modelBuilder.Entity("Frontline.GameDesign.DRaffleGroup", b =>
                {
                    b.Property<int>("type")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("adv_drop");

                    b.Property<int>("base_drop");

                    b.Property<int>("base_numb");

                    b.Property<int>("cost_item");

                    b.Property<DateTime?>("endtime");

                    b.Property<int>("first_drop");

                    b.Property<int>("item_cnt_1");

                    b.Property<int>("item_cnt_10");

                    b.Property<int>("nec_drop");

                    b.Property<int>("normal_drop");

                    b.Property<JsonObject<List<int>>>("theme_unit_id");

                    b.HasKey("type");

                    b.ToTable("DRaffleGroup");
                });

            modelBuilder.Entity("Frontline.GameDesign.DRandom", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("group");

                    b.Property<int>("max");

                    b.Property<int>("min");

                    b.Property<int>("random");

                    b.Property<int>("tid");

                    b.Property<int>("type");

                    b.Property<int>("w");

                    b.HasKey("id");

                    b.ToTable("DRandom");
                });

            modelBuilder.Entity("Frontline.GameDesign.DRescue", b =>
                {
                    b.Property<int>("mid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("diffic");

                    b.Property<int>("iron");

                    b.Property<JsonObject<Int32[]>>("may_drop");

                    b.Property<int>("supply");

                    b.HasKey("mid");

                    b.ToTable("DRescue");
                });

            modelBuilder.Entity("Frontline.GameDesign.DResPrice", b =>
                {
                    b.Property<int>("times")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("gold");

                    b.Property<int>("gold_cost");

                    b.Property<int>("iron");

                    b.Property<int>("iron_cost");

                    b.Property<int>("oil");

                    b.Property<int>("oil_cost");

                    b.Property<int>("supply");

                    b.Property<int>("supply_cost");

                    b.HasKey("times");

                    b.ToTable("DResPrice");
                });

            modelBuilder.Entity("Frontline.GameDesign.DSecretShop", b =>
                {
                    b.Property<int>("mission_type");

                    b.Property<int>("shop_id");

                    b.Property<int>("duration_second");

                    b.Property<int>("interval_second");

                    b.Property<int>("prob");

                    b.Property<JsonObject<Int32[]>>("trigger_lv");

                    b.HasKey("mission_type", "shop_id");

                    b.ToTable("DSecretShop");
                });

            modelBuilder.Entity("Frontline.GameDesign.DSecretShopItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("cur_price");

                    b.Property<int>("group");

                    b.Property<int>("item_cnt");

                    b.Property<int>("item_id");

                    b.Property<int>("limit_cnt");

                    b.Property<int>("old_price");

                    b.Property<int>("res_type");

                    b.Property<int>("vip");

                    b.Property<int>("w");

                    b.HasKey("id");

                    b.ToTable("DSecretShopItem");
                });

            modelBuilder.Entity("Frontline.GameDesign.DSkill", b =>
                {
                    b.Property<int>("id");

                    b.Property<int>("lv");

                    b.Property<string>("name");

                    b.Property<int>("unit_grade");

                    b.HasKey("id", "lv");

                    b.ToTable("DSkill");
                });

            modelBuilder.Entity("Frontline.GameDesign.DTransport", b =>
                {
                    b.Property<int>("tid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("diff");

                    b.Property<int>("gold");

                    b.Property<JsonObject<Int32[]>>("robbers1");

                    b.Property<JsonObject<Int32[]>>("robbers2");

                    b.Property<JsonObject<Int32[]>>("robbers3");

                    b.Property<int>("truck_id");

                    b.HasKey("tid");

                    b.ToTable("DTransport");
                });

            modelBuilder.Entity("Frontline.GameDesign.DUnit", b =>
                {
                    b.Property<int>("tid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("armor");

                    b.Property<float>("att_add");

                    b.Property<int>("bullet_count");

                    b.Property<float>("cd");

                    b.Property<int>("count");

                    b.Property<float>("crit");

                    b.Property<float>("crit_hurt");

                    b.Property<int>("crit_v");

                    b.Property<float>("def_add");

                    b.Property<string>("desc")
                        .HasMaxLength(128);

                    b.Property<float>("distance");

                    b.Property<int>("energy");

                    b.Property<JsonObject<Int32[]>>("equip");

                    b.Property<int>("exist");

                    b.Property<int>("grade_item_id");

                    b.Property<int>("gvg_rest_diamond");

                    b.Property<string>("gvg_rest_res_cnt");

                    b.Property<int>("gvg_rest_second");

                    b.Property<float>("hp_add");

                    b.Property<float>("hurt_add");

                    b.Property<int>("hurt_add_v");

                    b.Property<float>("hurt_multiple");

                    b.Property<float>("hurt_sub");

                    b.Property<int>("hurt_sub_v");

                    b.Property<float>("last_time");

                    b.Property<int>("max_energy");

                    b.Property<int>("mob");

                    b.Property<string>("name");

                    b.Property<int>("nation");

                    b.Property<float>("off");

                    b.Property<JsonObject<Int32[]>>("prop_grow_type");

                    b.Property<JsonObject<Single[]>>("prop_grow_val");

                    b.Property<JsonObject<Int32[]>>("prop_type");

                    b.Property<JsonObject<Single[]>>("prop_val");

                    b.Property<int>("pvp_dec_score");

                    b.Property<int>("pvp_point");

                    b.Property<float>("r");

                    b.Property<JsonObject<Int32[]>>("res_cnt");

                    b.Property<JsonObject<Int32[]>>("res_type");

                    b.Property<float>("rev");

                    b.Property<float>("rev_body");

                    b.Property<int>("sec");

                    b.Property<int>("show_p");

                    b.Property<JsonObject<List<int>>>("skills");

                    b.Property<float>("speed");

                    b.Property<int>("star");

                    b.Property<int>("type");

                    b.Property<int>("type_detail");

                    b.Property<int>("ww_type");

                    b.HasKey("tid");

                    b.ToTable("DUnit");
                });

            modelBuilder.Entity("Frontline.GameDesign.DUnitGradeUp", b =>
                {
                    b.Property<int>("star");

                    b.Property<int>("grade");

                    b.Property<int>("type");

                    b.Property<float>("atk");

                    b.Property<JsonObject<Int32[]>>("cost_item_cnt");

                    b.Property<JsonObject<Int32[]>>("cost_item_id");

                    b.Property<float>("defence");

                    b.Property<int>("gold");

                    b.Property<int>("grade_item_cnt");

                    b.Property<float>("hp");

                    b.Property<int>("max_level");

                    b.Property<int>("min_level");

                    b.HasKey("star", "grade", "type");

                    b.ToTable("DUnitGradeUp");
                });

            modelBuilder.Entity("Frontline.GameDesign.DUnitLevelUp", b =>
                {
                    b.Property<int>("level")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("star1");

                    b.Property<int>("star2");

                    b.Property<int>("star3");

                    b.Property<int>("star4");

                    b.Property<int>("star5");

                    b.HasKey("level");

                    b.ToTable("DUnitLevelUp");
                });

            modelBuilder.Entity("Frontline.GameDesign.DUnitUnlock", b =>
                {
                    b.Property<int>("tid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("item_cnt");

                    b.Property<int>("item_id");

                    b.HasKey("tid");

                    b.ToTable("DUnitUnlock");
                });

            modelBuilder.Entity("Frontline.GameDesign.DVIP", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("can_sweep");

                    b.Property<int>("day");

                    b.Property<float>("diamond_mall_rate");

                    b.Property<JsonObject<Int32[]>>("first_item_cnt");

                    b.Property<JsonObject<Int32[]>>("first_item_id");

                    b.Property<int>("lv");

                    b.Property<int>("max_oil");

                    b.Property<int>("mission_ex_numb_buytimes");

                    b.Property<JsonObject<Int32[]>>("next_item_cnt");

                    b.Property<JsonObject<Int32[]>>("next_item_id");

                    b.Property<int>("oneday_buy_gold");

                    b.Property<int>("oneday_buy_oil");

                    b.Property<int>("oneday_recv_diamond");

                    b.Property<int>("oneday_recv_gold");

                    b.Property<float>("price");

                    b.Property<int>("property_addition");

                    b.Property<int>("reset_dikang");

                    b.Property<int>("reset_rescue");

                    b.Property<int>("reset_transport");

                    b.Property<int>("reset_weekwar");

                    b.Property<int>("sign_re_day_numb");

                    b.Property<int>("work_day_hire_n");

                    b.Property<int>("work_total_hire_n");

                    b.Property<float>("work_worker4_prob");

                    b.HasKey("id");

                    b.ToTable("DVIP");
                });

            modelBuilder.Entity("Frontline.GameDesign.DWeekBattle", b =>
                {
                    b.Property<int>("mid");

                    b.Property<int>("day");

                    b.Property<JsonObject<Int32[]>>("item_cnt");

                    b.Property<JsonObject<Int32[]>>("item_id");

                    b.Property<int>("lv");

                    b.Property<JsonObject<Int32[]>>("res_cnt");

                    b.Property<JsonObject<Int32[]>>("res_type");

                    b.Property<JsonObject<Int32[]>>("unit_type");

                    b.HasKey("mid", "day");

                    b.ToTable("DWeekBattle");
                });

            modelBuilder.Entity("Frontline.GameDesign.DWeekBox", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("count");

                    b.Property<int>("item_id");

                    b.HasKey("id");

                    b.ToTable("DWeekBox");
                });
#pragma warning restore 612, 618
        }
    }
}
