﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbioz.Protocol.Selfmade.Enums
{
    public enum ChallengeTypeEnum
    {
        Zombie = 1,
        Statue,
        Désigné_volontaire,
        Sursis,
        Économe,
        Versatile,
        Jardinier,
        Nomade,
        Barbare,
        Cruel,
        Mystique,
        Fossoyeur,
        Casino_Royal,
        Araknophile,
        Intouchable = 17,
        Incurable,
        Mains_propres,
        Elémentaire,
        Circulez,
        Le_temps_qui_court,
        Perdu_de_vue,
        Ordonné = 25,
        Ni_pioutes_ni_soumises = 28,
        Ni_pious_ni_soumis,
        Les_petits_d_abord,
        Focus,
        Elitiste,
        Survivant,
        Imprévisible,
        Tueur_à_gages,
        Hardi,
        Collant,
        Blitzkrieg,
        Anachorète,
        Pusillanime,
        Pétulant,
        Deux_pour_le_prix_d_un,
        Abnégation,
        Partage,
        Duel,
        Chacun_son_monstre,
        Contamination,
        Les_mules_d_abord,
        Protégez_vos_mules,
        Le_cheat_des_devs,
        Bouftou_Royal_challenge_duo = 52,
        Royalmouth_challenge_duo,
        Mansot_Royal_challenge_duo,
        Ben_le_Ripate_challenge_duo,
        Obsidiantre_challenge_duo,
        Tengu_Givrefoux_challenge_duo,
        Fuji_Givrefoux_Nourricière_challenge_duo,
        Korriandre_challenge_duo,
        Kolosso_challenge_duo,
        Glourséleste_challenge_duo,
        Grolloum_challenge_duo,
        Corailleur_Magistral_challenge_duo,
        Gourlo_le_terrible_challenge_duo,
        Silf_le_Rasboul_Majeur_challenge_duo,
        Tynril_ahuri_challenge_duo,
        Kimbo_challenge_duo,
        Kralamour_géant_challenge_duo,
        Bulbig_Brozeur_challenge_duo,
        Tanukouï_San_challenge_duo,
        Maître_Pandore_challenge_duo,
        Péki_Péki_challenge_duo,
        Ougah_challenge_duo,
        Bworker_challenge_duo,
        Sphincter_Cell_challenge_duo,
        Chêne_Mou_challenge_duo,
        Minotot_challenge_duo,
        Blop_multicolore_royal_challenge_duo,
        Skeunk_challenge_duo,
        Crocabulia_challenge_duo,
        Tofu_Royal_challenge_duo,
        Minotoror_challenge_duo,
        Moon_challenge_duo,
        Dragon_Cochon_challenge_duo,
        Koulosse_challenge_duo,
        Meulou_challenge_duo,
        Rat_Noir_challenge_duo,
        Rat_Blanc_challenge_duo,
        Maître_Corbac_challenge_duo,
        Coffre_des_Forgerons_challenge_duo,
        Bworkette_challenge_duo,
        Kwakwa_challenge_duo,
        Blop_Coco_Royal_challenge_duo,
        Blop_Griotte_Royal_challenge_duo,
        Blop_Indigo_Royal_challenge_duo,
        Blop_Reinette_Royal_challenge_duo,
        Kanniboul_Ebil_challenge_duo,
        Craqueleur_Légendaire_challenge_duo,
        Nelween_challenge_duo,
        Daïgoro_challenge_duo,
        Abraknyde_Ancestral_challenge_duo,
        Kardorim_challenge_duo,
        Tournesol_Affamé_challenge_duo,
        Mob_l_Eponge_challenge_duo,
        Scarabosse_Doré_challenge_duo,
        Batofu_challenge_duo,
        Boostache_challenge_duo,
        Chafer_Ronin_challenge_duo,
        Shin_Larve_challenge_duo,
        Wa_Wabbit_challenge_duo,
        Gelée_Royale_Menthe_challenge_duo,
        Gelée_Royale_Fraise_challenge_duo,
        Gelée_Royale_Citron_challenge_duo,
        Gelée_Royale_Bleue_challenge_duo,
        Kardorim_challenge_1,
        Tournesol_Affamé_challenge_1,
        Kardorim_challenge_2,
        Tournesol_Affamé_challenge_2,
        Mob_l_Eponge_challenge_1,
        Mob_l_Eponge_challenge_2,
        Bouftou_Royal_challenge_1,
        Bouftou_Royal_challenge_2,
        Scarabosse_Doré_challenge_1,
        Scarabosse_Doré_challenge_2,
        Batofu_challenge_1,
        Batofu_challenge_2,
        Boostache_challenge_1,
        Boostache_challenge_2,
        Chafer_Ronin_challenge_1,
        Chafer_Ronin_challenge_2,
        Bworkette_challenge_1,
        Bworkette_challenge_1_dupliqué,
        Coffre_des_Forgerons_challenge_1,
        Coffre_des_Forgerons_challenge_2,
        Shin_Larve_challenge_1,
        Shin_Larve_challenge_2,
        Corailleur_Magistral_challenge_1,
        Corailleur_Magistral_challenge_2,
        Kwakwa_challenge_1,
        Kwakwa_challenge_2,
        Bulbig_Brozeur_challenge_1,
        Bulbig_Brozeur_challenge_2,
        Wa_Wabbit_challenge_1,
        Wa_Wabbit_challenge_2,
        Kanniboul_Ebil_challenge_1,
        Kanniboul_Ebil_challenge_2,
        Blop_Coco_Royal_challenge_1,
        Blop_Coco_Royal_challenge_2,
        Blop_Griotte_Royal_challenge_1,
        Blop_Griotte_Royal_challenge_2,
        Blop_Indigo_Royal_challenge_1,
        Blop_Indigo_Royal_challenge_2,
        Blop_Reinette_Royal_challenge_1,
        Blop_Reinette_Royal_challenge_2,
        Nelween_challenge_1,
        Nelween_challenge_2,
        Gourlo_le_terrible_challenge_1,
        Gourlo_le_terrible_challenge_2,
        Craqueleur_Légendaire_challenge_1,
        Craqueleur_Légendaire_challenge_2,
        Gelée_Royale_Menthe_challenge_1,
        Gelée_Royale_Menthe_challenge_2,
        Gelée_Royale_Fraise_challenge_1,
        Gelée_Royale_Fraise_challenge_2,
        Gelée_Royale_Citron_challenge_1,
        Gelée_Royale_Citron_challenge_2,
        Gelée_Royale_Bleue_challenge_1,
        Gelée_Royale_Bleue_challenge_2,
        Daïgoro_challenge_1,
        Daïgoro_challenge_2,
        Abraknyde_Ancestral_challenge_1,
        Abraknyde_Ancestral_challenge_2,
        Dragon_Cochon_challenge_1,
        Dragon_Cochon_challenge_2,
        Koulosse_challenge_1,
        Koulosse_challenge_2,
        Meulou_challenge_1,
        Meulou_challenge_2,
        Moon_challenge_1,
        Moon_challenge_2,
        Silf_le_Rasboul_Majeur_challenge_1,
        Silf_le_Rasboul_Majeur_challenge_2,
        Maître_Corbac_challenge_1,
        Maître_Corbac_challenge_2,
        Rat_Blanc_challenge_1,
        Rat_Blanc_challenge_2,
        Rat_Noir_challenge_1,
        Rat_Noir_challenge_2,
        Blop_multicolore_royal_challenge_1,
        Blop_multicolore_royal_challenge_2,
        Minotoror_challenge_1,
        Minotoror_challenge_2,
        Royalmouth_challenge_1,
        Royalmouth_challenge_2,
        Maître_Pandore_challenge_1,
        Maître_Pandore_challenge_2,
        Tofu_Royal_challenge_1,
        Tofu_Royal_challenge_2,
        Crocabulia_challenge_1,
        Crocabulia_challenge_2,
        Skeunk_challenge_1,
        Skeunk_challenge_2,
        Tanukouï_San_challenge_1,
        Tanukouï_San_challenge_2,
        Péki_Péki_challenge_1,
        Péki_Péki_challenge_2,
        Chêne_Mou_challenge_1,
        Chêne_Mou_challenge_2,
        Tynril_ahuri_challenge_1,
        Tynril_ahuri_challenge_2,
        Mansot_Royal_challenge_1,
        Mansot_Royal_challenge_2,
        Ben_le_Ripate_challenge_1,
        Ben_le_Ripate_challenge_2,
        Sphincter_Cell_challenge_1,
        Sphincter_Cell_challenge_2,
        Kimbo_challenge_1,
        Kimbo_challenge_2,
        Minotot_challenge_1,
        Minotot_challenge_2,
        Obsidiantre_challenge_1,
        Obsidiantre_challenge_2,
        Tengu_Givrefoux_challenge_1,
        Tengu_Givrefoux_challenge_2,
        Korriandre_challenge_1,
        Korriandre_challenge_2,
        Kralamour_géant_challenge_1,
        Kralamour_géant_challenge_2,
        Bworker_challenge_1,
        Bworker_challenge_2,
        Ougah_challenge_1,
        Ougah_challenge_2,
        Kolosso_challenge_1,
        Kolosso_challenge_2,
        Fuji_Givrefoux_Nourricière_challenge_1,
        Fuji_Givrefoux_Nourricière_challenge_2,
        Grolloum_challenge_1,
        Grolloum_challenge_2,
        Glourséleste_challenge_1,
        Glourséleste_challenge_2,
        Sapik_challenge_1,
        Sapik_challenge_2,
        Sapik_challenge_duo,
        Papa_Nowel_challenge_1,
        Papa_Nowel_challenge_2,
        Papa_Nowel_challenge_duo,
        Père_Fwetar_challenge_1,
        Père_Fwetar_challenge_2,
        Père_Fwetar_challenge_duo,
        Sapik_challenge_chrono,
        Papa_Nowel_challenge_chrono,
        Père_Fwetar_challenge_chrono,
        Nileza_challenge_duo,
        Missiz_Frizz_challenge_duo,
        Sylargh_challenge_duo,
        Klime_challenge_duo,
        Harebourg_challenge_duo,
        Nileza_challenge_1,
        Klime_challenge_1,
        Missiz_Frizz_challenge_1,
        Klime_challenge_2,
        Sylargh_challenge_1,
        Harebourg_challenge_1,
        Nileza_challenge_2,
        Missiz_Frizz__challenge_2,
        Sylargh_challenge_2,
        Harebourg_challenge_2,
        Harebourg__et_Nileza_challenge_sbire_2,
        Harebourg__et_Missiz_Frizz_challenge_sbire_2,
        Harebourg__et_Sylargh_challenge_sbire_2,
        Harebourg__et_Klime_challenge_sbire_2,
        Grozilla_et_Grasmera_Somnambules_challenge_chrono,
        Grozilla_et_Grasmera_Somnambules_challenge_1,
        Grozilla_et_Grasmera_Somnambules_challenge_2,
        Grozilla_et_Grasmera_Somnambules_challenge_duo,
        Grozilla_et_Grasmera_Épuisés_challenge_chrono,
        Grozilla_et_Grasmera_Épuisés_challenge_1,
        Grozilla_et_Grasmera_Épuisés_challenge_2,
        Grozilla_et_Grasmera_Épuisés_challenge_duo,
        Grozilla_et_Grasmera_Fatigués_challenge_chrono,
        Grozilla_et_Grasmera_Fatigués_challenge_1,
        Grozilla_et_Grasmera_Fatigués_challenge_2,
        Grozilla_et_Grasmera_Fatigués_challenge_duo,
        Grozilla_et_Grasmera_challenge_chrono,
        Grozilla_et_Grasmera_challenge_1_zombie,
        Grozilla_et_Grasmera_challenge_1_hardi,
        Grozilla_et_Grasmera_challenge_duo,
        Wa_Wobot_Challenge_1,
        Wa_Wobot_challenge_2,
        Wa_Wobot_challenge_duo,
        Maître_des_Pantins_challenge_1,
        Maître_des_Pantins_challenge_2,
        Maître_des_Pantins_challenge_duo,
        Merkator_challenge_duo,
        Merkator_challenge_1,
        Merkator_challenge_2,
        Ombre_challenge_1,
        Ombre_challenge_2,
        Ombre_challenge_duo,
        Kanigroula_challenge_1,
        Kanigroula_challenge_2,
        Kanigroula_challenge_duo,
        Haute_Truche_challenge_1,
        Haute_Truche_challenge_2,
        Haute_Truche_challenge_duo,
        Roi_Nidas_challenge_1,
        Roi_Nidas_challenge_2,
        Roi_Nidas_challenge_trio,
        Phossile_challenge_2,
        Phossile_challenge_1,
        Phossile_challenge_duo,
        Malléfisk_challenge_1,
        Malléfisk_challenge_2,
        Malléfisk_challenge_duo,
        Reine_des_Voleurs_challenge_1,
        Reine_des_Voleurs_challenge_2,
        Reine_des_Voleurs_challenge_trio,
        Toxoliath_challenge_2,
        Toxoliath_challenge_duo,
        Capitaine_Ekarlatte_challenge_1,
        Capitaine_Ekarlatte_challenge_2,
        Capitaine_Ekarlatte_challenge_duo,
        Toxoliath_challenge_1,
        Protozorreur_challenge_1,
        Protozorreur_challenge_2,
        Protozorreur_challenge_duo,
        Halouine_challenge_chrono,
        Halouine_challenge_1,
        Halouine_challenge_2,
        Halouine_challenge_duo,
        Vortex_challenge_1,
        Vortex_challenge_2,
        Vortex_challenge_trio,
        XLII_challenge_1,
        XLII_challenge_2,
        XLII_challenge_duo,
        Fraktale_challenge_1,
        Fraktale_challenge_2,
        Fraktale_challenge_duo,
        Kankreblath_challenge_duo,
        Kankreblath_challenge_1,
        Kankreblath_challenge_2,
        Reine_Nyée_challenge_duo,
        Reine_Nyée_challenge_1,
        Reine_Nyée_challenge_2,
        Le_Chouque_challenge_duo,
        Le_Chouque_challenge_1,
        Le_Chouque_challenge_2,
        Pounicheur_challenge_duo,
        Pounicheur_challenge_1,
        Pounicheur_challenge_2,
        Ush_Galesh_challenge_duo,
        Ush_Galesh_challenge_2,
        Ush_Galesh_challenge_1,
        Chalœil_challenge_1,
        Chalœil_challenge_2,
        Chalœil_challenge_trio,
    }
}
