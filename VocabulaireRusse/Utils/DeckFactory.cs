﻿using System;
using System.Collections.Generic;
using SQLite;
using SQLite.Net;
using SQLiteNetExtensions.Extensions;
using VocabulaireRusse.Domain;
namespace VocabulaireRusse.Utils
{
    public class DeckFactory
    {
        public static DeckSharp GetTestDeck()
        {
            var d = new DeckSharp();
            d.Add(new Card("а", "et, mais"));
            d.Add(new Card("август", "août"));
            d.Add(new Card("автобус", "autobus"));
            d.Add(new Card("агат", "agate"));
            d.Add(new Card("адрес (plur. адреса)", "adresse"));
            d.Add(new Card("аллея", "allée"));
            d.Add(new Card("Амьен", "Amiens"));
            d.Add(new Card("английский", "anglais (adj)"));
            d.Add(new Card("английский", "anglais (langue)"));
            d.Add(new Card("англичанин", "(un) Anglais"));

            return d;
        }

        public static DeckSharp GetLRUSS1100Deck()
        {
            var d = new DeckSharp();

           d.Add (new Card ("а", "et, mais"));
d.Add (new Card ("август", "août"));
d.Add (new Card ("автобус", "autobus"));
d.Add (new Card ("агат", "agate"));
d.Add (new Card ("адрес (plur. адреса)", "adresse"));
d.Add (new Card ("аллея", "allée"));
d.Add (new Card ("Амьен", "Amiens"));
d.Add (new Card ("английский", "anglais (adj)"));
d.Add (new Card ("английский", "anglais (langue)"));
d.Add (new Card ("англичанин", "(un) Anglais"));
d.Add (new Card ("англичанка", "(une) Anglaise"));
d.Add (new Card ("антракт", "entracte"));
d.Add (new Card ("апрель", "avril"));
d.Add (new Card ("аптека", "pharmacie"));
d.Add (new Card ("аромат", "parfum, arôme"));
d.Add (new Card ("атаман", "ataman"));
d.Add (new Card ("атлантический океан", "Océan Atlantique"));
d.Add (new Card ("аудитория", "auditoire, salle de cours, salle d'étude"));
d.Add (new Card ("афиша", "affiche"));
d.Add (new Card ("Аяччо", "Ajaccio"));
d.Add (new Card ("бабушка", "grand-mère"));
d.Add (new Card ("балет", "ballet"));
d.Add (new Card ("балкон", "balcon"));
d.Add (new Card ("банк", "banque"));
d.Add (new Card ("бар", "bar"));
d.Add (new Card ("батарея", "radiateur"));
d.Add (new Card ("батарея", "pile éléctrique"));
d.Add (new Card ("башня", "(une) tour"));
d.Add (new Card ("бедро (n. plur. бёдра)", "cuisse"));
d.Add (new Card ("бежевый (adj.)", "beige (adj.)"));
d.Add (new Card ("Безансон", "Besançon"));
d.Add (new Card ("белый", "blanc (adj)"));
d.Add (new Card ("берег (plur. Берега)", "rive, bord"));
d.Add (new Card ("библиотека", "bibliothèque"));
d.Add (new Card ("библиотекарь", "bibliothécaire"));
d.Add (new Card ("бизнесмен", "homme d'affaire"));
d.Add (new Card ("биология", "biologie"));
d.Add (new Card ("ближайший", "le plus proche"));
d.Add (new Card ("близко (adv.)", "près"));
d.Add (new Card ("блокнот", "carnet"));
d.Add (new Card ("бой (plur. бои)", "bataille"));
d.Add (new Card ("бок (plur. бока)", "coté, flanc"));
d.Add (new Card ("болтать", "bavarder"));
d.Add (new Card ("больница", "hôpital"));
d.Add (new Card ("большой", "grand"));
d.Add (new Card ("Бордо", "Bordeaux"));
d.Add (new Card ("брат (plur. Братья)", "frère"));
d.Add (new Card ("будни", "jours ouvrables"));
d.Add (new Card ("будущий", "futur, prochain (adj.)"));
d.Add (new Card ("бульвар", "boulevard"));
d.Add (new Card ("бумага", "papier"));
d.Add (new Card ("буря", "tempête"));
d.Add (new Card ("бутылка", "bouteille"));
d.Add (new Card ("быстро", "vite"));
d.Add (new Card ("быть", "être"));
d.Add (new Card ("в", "dans, en"));
d.Add (new Card ("ваза", "vase"));
d.Add (new Card ("ванная", "salle de bain"));
d.Add (new Card ("ваш", "votre"));
d.Add (new Card ("вдоль + gén.", "le long de"));
d.Add (new Card ("весело", "gaiement"));
d.Add (new Card ("весёлый", "gai"));
d.Add (new Card ("весна", "printemps"));
d.Add (new Card ("весной", "au printemps"));
d.Add (new Card ("весь(m.), вся(f.), всё(n.), все (plur.)", "tout, toute, tout, tous, tout le monde"));
d.Add (new Card ("ветер", "vent"));
d.Add (new Card ("вечер (plur. вечера)", "soir"));
d.Add (new Card ("вечером", "pendant la soirée"));
d.Add (new Card ("вешалка", "porte-manteau"));
d.Add (new Card ("видеофильм", "vidéofilm"));
d.Add (new Card ("видеть", "voir"));
d.Add (new Card ("видеться", "se voir, voir"));
d.Add (new Card ("вино", "vin"));
d.Add (new Card ("вираж", "virage"));
d.Add (new Card ("висеть", "être accroché"));
d.Add (new Card ("вместе", "ensemble"));
d.Add (new Card ("внизу (adv.)", "en dessous"));
d.Add (new Card ("внимательно", "attentivement"));
d.Add (new Card ("внимательный", "attentif"));
d.Add (new Card ("внук", "petit-fils"));
d.Add (new Card ("внучка", "petite-fille"));
d.Add (new Card ("вода", "eau"));
d.Add (new Card ("водка", "vodka"));
d.Add (new Card ("возвращаться", "rentrer, revenir"));
d.Add (new Card ("вокзал", "gare"));
d.Add (new Card ("волос", "cheveu"));
d.Add (new Card ("вопрос", "question"));
d.Add (new Card ("восем", "huit"));
d.Add (new Card ("восемнадцать", "dix-huit"));
d.Add (new Card ("воск", "cire"));
d.Add (new Card ("воскресенье", "dimanche"));
d.Add (new Card ("восток", "est"));
d.Add (new Card ("вот", "voici"));
d.Add (new Card ("врач", "médecin"));
d.Add (new Card ("время (n.)", "temps"));
d.Add (new Card ("все", "tous"));
d.Add (new Card ("всё", "tout"));
d.Add (new Card ("всегда", "toujours"));
d.Add (new Card ("вставать", "se lever"));
d.Add (new Card ("встреча", "rencontre"));
d.Add (new Card ("встречать", "rencontrer"));
d.Add (new Card ("вторник", "mardi"));
d.Add (new Card ("второй", "second"));
d.Add (new Card ("вход", "entrée"));
d.Add (new Card ("вчера", "hier"));
d.Add (new Card ("вы", "vous"));
d.Add (new Card ("высокий", "haut, élevé"));
d.Add (new Card ("выставка", "exposition"));
d.Add (new Card ("выход", "sortie"));
d.Add (new Card ("выходной день", "jour de congé"));
d.Add (new Card ("газета", "journal"));
d.Add (new Card ("гараж", "garage"));
d.Add (new Card ("Гаронна", "La Garonne (fleuve)"));
d.Add (new Card ("где", "où"));
d.Add (new Card ("генерал", "général (grade militaire)"));
d.Add (new Card ("гений", "génie"));
d.Add (new Card ("география", "géographie"));
d.Add (new Card ("герой", "héros"));
d.Add (new Card ("гид", "guide"));
d.Add (new Card ("глаз (plur. глаза)", "oeil"));
d.Add (new Card ("говорить", "parler"));
d.Add (new Card ("год", "année"));
d.Add (new Card ("головa", "tête"));
d.Add (new Card ("голос (plur. голоса)", "voix"));
d.Add (new Card ("гора", "montagne"));
d.Add (new Card ("город (plur. города)", "ville"));
d.Add (new Card ("городок", "petite ville"));
d.Add (new Card ("горячий", "chaud, brûlant"));
d.Add (new Card ("гостиная", "salon"));
d.Add (new Card ("гостиница, отель", "hôtel"));
d.Add (new Card ("гость (m.)", "hôte, invité"));
d.Add (new Card ("государство", "État"));
d.Add (new Card ("готовить", "préparer"));
d.Add (new Card ("готовиться", "se préparer"));
d.Add (new Card ("грамматика", "grammaire"));
d.Add (new Card ("Гренобль", "Grenoble"));
d.Add (new Card ("громко", "fort, à haute voix, bruyamment (adv.)"));
d.Add (new Card ("грудь (f.)", "sein"));
d.Add (new Card ("группа", "groupe"));
d.Add (new Card ("грустно", "tristement"));
d.Add (new Card ("грустный", "triste"));
d.Add (new Card ("губка", "éponge"));
d.Add (new Card ("гулять", "se promener"));
d.Add (new Card ("д(е)нь (m.)", "jour"));
d.Add (new Card ("да", "oui"));
d.Add (new Card ("давать", "donner"));
d.Add (new Card ("давно (adv.)", "(depuis) longtemps"));
d.Add (new Card ("далеко", "loin"));
d.Add (new Card ("дама", "dame"));
d.Add (new Card ("два (m.), две (f.)", "deux"));
d.Add (new Card ("двадцать", "ving"));
d.Add (new Card ("двенадцать", "douze"));
d.Add (new Card ("дверь (f.)", "porte"));
d.Add (new Card ("двор(е)ц", "palais"));
d.Add (new Card ("девочка", "petite fille"));
d.Add (new Card ("девушка", "jeune fille"));
d.Add (new Card ("девятнадцать", "dix-neuf"));
d.Add (new Card ("девять (f.)", "neuf (chiffre)"));
d.Add (new Card ("дедушка (m.)", "grand-père"));
d.Add (new Card ("декабрь", "décembre"));
d.Add (new Card ("делать", "faire"));
d.Add (new Card ("дело", "affaire"));
d.Add (new Card ("деревня", "village, campagne"));
d.Add (new Card ("дерево (plur. деревья)", "arbre"));
d.Add (new Card ("деревянный", "de bois, en bois"));
d.Add (new Card ("десять", "dix"));
d.Add (new Card ("дешёвый", "bon marché"));
d.Add (new Card ("диван", "canapé"));
d.Add (new Card ("Дижон", "Dijon"));
d.Add (new Card ("диктант", "dictée"));
d.Add (new Card ("динамо (inv.)", "dynamo"));
d.Add (new Card ("директор (plur. директора)", "directeur"));
d.Add (new Card ("дискотека", "discothèque"));
d.Add (new Card ("длинный", "long"));
d.Add (new Card ("днём", "pendant la journée"));
d.Add (new Card ("до + gén.", "jusqu'à"));
d.Add (new Card ("до свидания", "au revoir"));
d.Add (new Card ("добрый", "bon, gentil"));
d.Add (new Card ("дождь (m.)", "pluie"));
d.Add (new Card ("доктор (plur. доктора)", "docteur"));
d.Add (new Card ("долго", "longtemps"));
d.Add (new Card ("дом (plur. дома)", "la maison, l'immeuble"));
d.Add (new Card ("дома (adv.)", "chez soi, à la maison"));
d.Add (new Card ("домашнее задание", "devoir (à faire à la maison)"));
d.Add (new Card ("домашний", "de la maison, domestique"));
d.Add (new Card ("дон", "Don (fleuve)"));
d.Add (new Card ("дорога", "chemin, route"));
d.Add (new Card ("дорого", "cher (adv.)"));
d.Add (new Card ("дорогой", "cher (adj.)"));
d.Add (new Card ("дорогой", "cher"));
d.Add (new Card ("дорожка", "petit chemin"));
d.Add (new Card ("доска", "planche, tableau (noir)"));
d.Add (new Card ("дочь (f.), дочери (pl.)", "fille (par rapport à la mère)"));
d.Add (new Card ("друг, друзья (pl.)", "ami, les amis"));
d.Add (new Card ("дружеский", "amical"));
d.Add (new Card ("думать", "penser"));
d.Add (new Card ("душ", "douche"));
d.Add (new Card ("дюна", "dune"));
d.Add (new Card ("дядя", "oncle"));
d.Add (new Card ("его", "à lui"));
d.Add (new Card ("её", "à elle"));
d.Add (new Card ("если", "si (condition)"));
d.Add (new Card ("ещё", "encore"));
d.Add (new Card ("жал", "c'est dommage"));
d.Add (new Card ("жалеть", "regretter"));
d.Add (new Card ("жало", "dard"));
d.Add (new Card ("жандарм", "gendarme"));
d.Add (new Card ("жарко", "chaud (adv)"));
d.Add (new Card ("ждать", "attendre"));
d.Add (new Card ("железо", "fer"));
d.Add (new Card ("жёлтый", "jaune"));
d.Add (new Card ("жена", "femme (épouse)"));
d.Add (new Card ("женат", "marié (adv.)"));
d.Add (new Card ("женатый", "marié (adj.)"));
d.Add (new Card ("жених", "fiancé"));
d.Add (new Card ("женщина", "jeune femme"));
d.Add (new Card ("живот", "ventre"));
d.Add (new Card ("жизнь (f.)", "vie"));
d.Add (new Card ("жить", "vivre"));
d.Add (new Card ("журнал", "magasine, revue"));
d.Add (new Card ("заболеть", "tomber malade"));
d.Add (new Card ("забывать", "oublier"));
d.Add (new Card ("завод", "usine"));
d.Add (new Card ("завтра", "demain"));
d.Add (new Card ("завтрак", "petit déjeuner"));
d.Add (new Card ("завтракать", "déjeuner"));
d.Add (new Card ("задание", "devoir"));
d.Add (new Card ("закон", "loi"));
d.Add (new Card ("зал", "salle"));
d.Add (new Card ("зам(о)к", "château"));
d.Add (new Card ("замужем (inv.)", "mariée (adv.)"));
d.Add (new Card ("замужний (mou)", "mariée (adj.)"));
d.Add (new Card ("заниматься", "s'occuper, travailler"));
d.Add (new Card ("занятие", "cours, leçon"));
d.Add (new Card ("запад", "ouest"));
d.Add (new Card ("запах", "odeur"));
d.Add (new Card ("запоминать", "retenir, se rappeler"));
d.Add (new Card ("звон(о)к", "sonnerie"));
d.Add (new Card ("здание, здания (pl.)", "bâtiment"));
d.Add (new Card ("здесь (adv.)", "ici"));
d.Add (new Card ("здоров, здорова, здорово, здоровы ", "en bonne santé"));
d.Add (new Card ("здравствуй!", "Bonjour! (tu)"));
d.Add (new Card ("здраствуйте!", "Bonjour! (vous)"));
d.Add (new Card ("земля", "terre"));
d.Add (new Card ("зима", "hiver"));
d.Add (new Card ("зимний", "d'hiver, hivernal"));
d.Add (new Card ("зимой", "en hiver"));
d.Add (new Card ("знакомый", "(une) connaissance, (une) relation"));
d.Add (new Card ("знакомый", "connu"));
d.Add (new Card ("знать", "connaître, savoir"));
d.Add (new Card ("золотой", "doré"));
d.Add (new Card ("и", "et"));
d.Add (new Card ("игра", "jeu"));
d.Add (new Card ("играть ", "jouer"));
d.Add (new Card ("идти", "aller"));
d.Add (new Card ("изба", "isba"));
d.Add (new Card ("изучать", "étudier"));
d.Add (new Card ("или", "ou"));
d.Add (new Card ("имя (n.)", "prénom"));
d.Add (new Card ("инженер", "ingénieur"));
d.Add (new Card ("иностраный", "étranger (adj.)"));
d.Add (new Card ("инспектор", "inspecteur"));
d.Add (new Card ("институт", "institut (université)"));
d.Add (new Card ("интересно", "c'est intéressant"));
d.Add (new Card ("интересный", "intéressant (adj.)"));
d.Add (new Card ("искать", "chercher"));
d.Add (new Card ("испан(е)ц", "(un) espagnol"));
d.Add (new Card ("испанка", "(une) espagnole"));
d.Add (new Card ("испанский", "espagnol (adj.)"));
d.Add (new Card ("история", "histoire"));
d.Add (new Card ("итальян(е)ц", "(un) italien"));
d.Add (new Card ("итальянка", "(une) italienne"));
d.Add (new Card ("итальянский", "italien (adj.)"));
d.Add (new Card ("их", "à eux, à elles"));
d.Add (new Card ("июль", "juillet"));
d.Add (new Card ("июнь", "juin"));
d.Add (new Card ("казак", "cosaque"));
d.Add (new Card ("как", "comment"));
d.Add (new Card ("какой", "quel"));
d.Add (new Card ("какой (-ая, -ое, -ие)", "quel, quelle, quels, quelles"));
d.Add (new Card ("кам(е)нь (m.)", "pierre"));
d.Add (new Card ("каменный", "de pierre, en pierre"));
d.Add (new Card ("камин", "cheminée (âtre)"));
d.Add (new Card ("Кан", "Caen"));
d.Add (new Card ("канал", "canal"));
d.Add (new Card ("каникулы", "vacances"));
d.Add (new Card ("карандаш", "crayon"));
d.Add (new Card ("карта", "carte"));
d.Add (new Card ("картина    ", "tableau"));
d.Add (new Card ("картинка", "dessin"));
d.Add (new Card ("касса", "caisse"));
d.Add (new Card ("кафе (inv.)", "café (lieu)"));
d.Add (new Card ("квартал", "quartier"));
d.Add (new Card ("квартира", "appartement"));
d.Add (new Card ("квас", "Kvas (bière)"));
d.Add (new Card ("кино (inv.)", "cinéma"));
d.Add (new Card ("кинотеатр", "salle de cinéma"));
d.Add (new Card ("класс", "classe"));
d.Add (new Card ("Клермон-Ферран", "Clermont-Ferrand"));
d.Add (new Card ("клуб", "club"));
d.Add (new Card ("книга", "livre"));
d.Add (new Card ("ков(ё)р", "tapis"));
d.Add (new Card ("когда", "quand"));
d.Add (new Card ("код", "code (pour une porte)"));
d.Add (new Card ("колено", "genou"));
d.Add (new Card ("комната", "pièce, chambre"));
d.Add (new Card ("конец", "fin"));
d.Add (new Card ("концерт", "concert"));
d.Add (new Card ("кончать", "finir"));
d.Add (new Card ("кончаться", "finir, se terminer"));
d.Add (new Card ("коридор", "couloir"));
d.Add (new Card ("короткий", "court"));
d.Add (new Card ("короткый", "court (adj.)"));
d.Add (new Card ("который", "qui, que"));
d.Add (new Card ("кошка", "chat"));
d.Add (new Card ("край (plur. края)", "bord, pays"));
d.Add (new Card ("красивый", "beau"));
d.Add (new Card ("красный", "rouge"));
d.Add (new Card ("крепость (f.)", "forteresse"));
d.Add (new Card ("кресло  ", "fauteuil"));
d.Add (new Card ("кровать (f.)", "lit"));
d.Add (new Card ("крыша", "toit"));
d.Add (new Card ("кто", "qui"));
d.Add (new Card ("куда", "Où (mouvement)"));
d.Add (new Card ("кузен", "cousin"));
d.Add (new Card ("кузина", "cousine"));
d.Add (new Card ("курить", "fumer"));
d.Add (new Card ("курс", "année d'étude (à l'université)"));
d.Add (new Card ("кухня", "cuisine"));
d.Add (new Card ("лампа", "lampe"));
d.Add (new Card ("лёгкий", "léger, facile"));
d.Add (new Card ("лежать", "être couché"));
d.Add (new Card ("лейка", "arrosoir"));
d.Add (new Card ("лекция", "cours magistral, conférence"));
d.Add (new Card ("лес", "forêt"));
d.Add (new Card ("лес (plur. леса)", "forêt"));
d.Add (new Card ("лестница", "escalier"));
d.Add (new Card ("летний", "d'été, estival"));
d.Add (new Card ("лето", "été"));
d.Add (new Card ("летом", "en été"));
d.Add (new Card ("Лилль", "Lille"));
d.Add (new Card ("Лимож", "Limoges"));
d.Add (new Card ("Лион", "Lyon"));
d.Add (new Card ("лист (plur. листья)", "feuille (d'arbre)"));
d.Add (new Card ("литература", "littérature"));
d.Add (new Card ("лифт", "ascensceur"));
d.Add (new Card ("лифтник", "soutient-gorge (fam.)"));
d.Add (new Card ("лицо", "visage"));
d.Add (new Card ("ложиться", "se coucher"));
d.Add (new Card ("Луара", "La Loire (fleuve)"));
d.Add (new Card ("любимый", "aimé, préféré"));
d.Add (new Card ("любить", "aimer"));
d.Add (new Card ("люди (plur.)", "gens"));
d.Add (new Card ("магазин", "magasin"));
d.Add (new Card ("май", "mai"));
d.Add (new Card ("маленький", "petit"));
d.Add (new Card ("мало", "peu"));
d.Add (new Card ("мальчик", "garçon"));
d.Add (new Card ("мама", "maman"));
d.Add (new Card ("Мария", "Marie"));
d.Add (new Card ("Марсель", "Marseille"));
d.Add (new Card ("март", "mars"));
d.Add (new Card ("математика", "mathématiques"));
d.Add (new Card ("матрёшка", "Matriochka"));
d.Add (new Card ("мать (f.) + матери (pl. + decl.)", "mère"));
d.Add (new Card ("машина", "voiture"));
d.Add (new Card ("медленно", "lentement"));
d.Add (new Card ("медсистра", "infirmière"));
d.Add (new Card ("мел", "craie"));
d.Add (new Card ("место", "place, endroit"));
d.Add (new Card ("месяц", "mois"));
d.Add (new Card ("метро (inv.)", "metro"));
d.Add (new Card ("Мец", "Metz"));
d.Add (new Card ("милиция", "milice (police)"));
d.Add (new Card ("минута", "minute"));
d.Add (new Card ("мир", "paix, monde"));
d.Add (new Card ("митинг", "meeting"));
d.Add (new Card ("Миша", "Micha"));
d.Add (new Card ("младший", "cadet"));
d.Add (new Card ("много (adv.)", "beaucoup"));
d.Add (new Card ("можно", "on peut"));
d.Add (new Card ("мой, -я, -ё, -и", "mon"));
d.Add (new Card ("молодой", "jeune"));
d.Add (new Card ("молоко", "lait"));
d.Add (new Card ("Монако", "Monaco"));
d.Add (new Card ("море", "mer"));
d.Add (new Card ("мороз", "gel"));
d.Add (new Card ("Москва", "Moscou"));
d.Add (new Card ("московский", "de Moscou, moscovite"));
d.Add (new Card ("мост", "pont"));
d.Add (new Card ("мостик", "passerelle"));
d.Add (new Card ("муж (plur. Мужья)", "mari"));
d.Add (new Card ("мужчина", "homme"));
d.Add (new Card ("музыка", "musique"));
d.Add (new Card ("мука", "farine"));
d.Add (new Card ("мы", "nous"));
d.Add (new Card ("мэр", "maire"));
d.Add (new Card ("мэрия", "mairie, maison communale"));
d.Add (new Card ("мясник", "boucher"));
d.Add (new Card ("мясо", "viande"));
d.Add (new Card ("мяч", "ballon"));
d.Add (new Card ("мячик", "balle"));
d.Add (new Card ("на", "dans, sur"));
d.Add (new Card ("набережная", "quai"));
d.Add (new Card ("наверху", "en haut"));
d.Add (new Card ("надо", "il faut"));
d.Add (new Card ("Наит", "Nantes"));
d.Add (new Card ("народ", "peuple"));
d.Add (new Card ("находиться", "se trouver"));
d.Add (new Card ("начинать", "commencer"));
d.Add (new Card ("начинаться", "commencer"));
d.Add (new Card ("наш, -а, -е, -и", "notre"));
d.Add (new Card ("небо", "ciel"));
d.Add (new Card ("Нева", "Neva"));
d.Add (new Card ("невеста", "fiancée"));
d.Add (new Card ("недавно", "récemment"));
d.Add (new Card ("недалеко", "proche"));
d.Add (new Card ("неделя", "semaine"));
d.Add (new Card ("незнакомый", "inconnu"));
d.Add (new Card ("неинтересный", "inintéressant"));
d.Add (new Card ("некрасивый", "laid"));
d.Add (new Card ("нельзя", "on ne peut pas"));
d.Add (new Card ("нем(е)ц", "(un) allemand"));
d.Add (new Card ("немецкый", "allemand (ajd.)"));
d.Add (new Card ("немка", "(une) allemande"));
d.Add (new Card ("немного", "peu, un peu"));
d.Add (new Card ("немного", "un peu"));
d.Add (new Card ("несколько", "quelques (adv.)"));
d.Add (new Card ("нет", "non"));
d.Add (new Card ("неуютный", "inconfortable"));
d.Add (new Card ("низкий", "bas"));
d.Add (new Card ("никто", "personne"));
d.Add (new Card ("Ницца", "Nice"));
d.Add (new Card ("но", "mais "));
d.Add (new Card ("новости (plur.)", "informations, journal télévisé"));
d.Add (new Card ("новость (f.)", "(les) nouvelles"));
d.Add (new Card ("новый", "neuf, nouveau"));
d.Add (new Card ("нога", "jambe, pied"));
d.Add (new Card ("ноздно", "tard"));
d.Add (new Card ("номер (plur. номера)", "numéro"));
d.Add (new Card ("нормально", "normalement"));
d.Add (new Card ("ночь (f.)", "nuit"));
d.Add (new Card ("ночью", "pendant la nuit"));
d.Add (new Card ("ноябрь", "novembre"));
d.Add (new Card ("нужно", "il faut"));
d.Add (new Card ("няня", "nounou"));
d.Add (new Card ("о + loc.", "au sujet de"));
d.Add (new Card ("обед", "(un) dîner"));
d.Add (new Card ("обедать", "dîner"));
d.Add (new Card ("обнимать", "prendre dans ses bras"));
d.Add (new Card ("обсуждать", "discuter"));
d.Add (new Card ("обувь (f.)", "chaussures"));
d.Add (new Card ("общежитие", "foyer d'étudiant"));
d.Add (new Card ("объяснение", "explication"));
d.Add (new Card ("объяснять", "expliquer"));
d.Add (new Card ("обычно", "généralement"));
d.Add (new Card ("овца (plur. овцы)", "brebis"));
d.Add (new Card ("одевать", "habiller"));
d.Add (new Card ("одеваться", "s'habiller"));
d.Add (new Card ("одежда", "vêtements"));
d.Add (new Card ("один (m.)", "un"));
d.Add (new Card ("одиннадцать", "onze"));
d.Add (new Card ("озеро", "lac"));
d.Add (new Card ("океан", "océan"));
d.Add (new Card ("окно", "fenêtre"));
d.Add (new Card ("октябрь", "octobre"));
d.Add (new Card ("опять (adv.)", "à nouveau"));
d.Add (new Card ("оркестр", "orchestre"));
d.Add (new Card ("осень", "automne"));
d.Add (new Card ("осенью", "en automone"));
d.Add (new Card ("особенно", "en particulier"));
d.Add (new Card ("особенный", "particulier"));
d.Add (new Card ("остров", "île"));
d.Add (new Card ("остров (plur. острова)", "île"));
d.Add (new Card ("от(е)ц", "père"));
d.Add (new Card ("ответ", "réponse"));
d.Add (new Card ("отвечать", "répondre"));
d.Add (new Card ("отдыхать", "se reposer"));
d.Add (new Card ("отель (m.)", "hôtel"));
d.Add (new Card ("открытка", "carte postale"));
d.Add (new Card ("отметка", "note"));
d.Add (new Card ("отпуск", "congé"));
d.Add (new Card ("оценка", "note (appréciation)"));
d.Add (new Card ("очень", "très"));
d.Add (new Card ("падь, пада (adj.)", "content, contente"));
d.Add (new Card ("пальто (inv.)", "manteau"));
d.Add (new Card ("памятник", "monument"));
d.Add (new Card ("папа (m.)", "papa"));
d.Add (new Card ("Париж", "Paris"));
d.Add (new Card ("парк", "parc"));
d.Add (new Card ("паспорт (plur. паспорта)", "passeport"));
d.Add (new Card ("певец", "chanteur"));
d.Add (new Card ("пейзаж", "paysage"));
d.Add (new Card ("пенсия", "retraite, pension"));
d.Add (new Card ("перевод", "traduction"));
d.Add (new Card ("переводить", "traduire"));
d.Add (new Card ("переул(о)к", "ruelle"));
d.Add (new Card ("перо (plur. перья)", "plume"));
d.Add (new Card ("песня", "chanson"));
d.Add (new Card ("петь", "chanter"));
d.Add (new Card ("пианино (inv.)", "piano"));
d.Add (new Card ("пиво", "bière"));
d.Add (new Card ("писать", "écrire"));
d.Add (new Card ("письмо", "lettre"));
d.Add (new Card ("плакат", "affiche, pancarte"));
d.Add (new Card ("платье", "robe"));
d.Add (new Card ("плащ", "imperméable"));
d.Add (new Card ("плечо", "épaule"));
d.Add (new Card ("плохо", "mauvais, mal (adv.)"));
d.Add (new Card ("плохой", "mauvais"));
d.Add (new Card ("площадь (f.)", "place"));
d.Add (new Card ("пляж", "plage"));
d.Add (new Card ("по-немецки (adv.)", "en allemand"));
d.Add (new Card ("по-русски (adv.)", "en russe"));
d.Add (new Card ("по-французски (adv.)", "en français"));
d.Add (new Card ("повторять", "répéter"));
d.Add (new Card ("погода", "temps (météo)"));
d.Add (new Card ("погода", "temp (qu'il fait)"));
d.Add (new Card ("подвал", "cave, sous-sol"));
d.Add (new Card ("подруга", "amie"));
d.Add (new Card ("подъезд", "entrée de l'immeuble"));
d.Add (new Card ("поезд", "train"));
d.Add (new Card ("пожалуйста", "s'il vous plait"));
d.Add (new Card ("поживать", "aller (comment vas-tu ?)"));
d.Add (new Card ("позвать", "appeler"));
d.Add (new Card ("Познокомьтесь", "Faites connaissance!"));
d.Add (new Card ("покупать", "acheter"));
d.Add (new Card ("пол", "sol, plancher"));
d.Add (new Card ("полдень", "midi"));
d.Add (new Card ("поле", "champs"));
d.Add (new Card ("полка", "étagère"));
d.Add (new Card ("полночь", "minuit"));
d.Add (new Card ("помнить", "se rappeler"));
d.Add (new Card ("понидельник", "lundi"));
d.Add (new Card ("понимать", "comprendre"));
d.Add (new Card ("пора (adv.)", "il est temps"));
d.Add (new Card ("порок", "vice"));
d.Add (new Card ("португал(е)ц", "(un) portugais"));
d.Add (new Card ("португалка", "(une) portugaise"));
d.Add (new Card ("портфель", "cartable"));
d.Add (new Card ("посев", "semaille"));
d.Add (new Card ("посередине (adv.)", "au milieu"));
d.Add (new Card ("последний", "dernier"));
d.Add (new Card ("потол(о)к", "plafond"));
d.Add (new Card ("потом", "ensuite"));
d.Add (new Card ("потому что", "parce que"));
d.Add (new Card ("поход", "campagne militaire, randonnée"));
d.Add (new Card ("почему", "pourquoi"));
d.Add (new Card ("почта", "poste"));
d.Add (new Card ("поэзд (plur. поэзда)", "train"));
d.Add (new Card ("поэт", "poête"));
d.Add (new Card ("правда", "vérité"));
d.Add (new Card ("правило", "règle"));
d.Add (new Card ("правильный", "juste, correct (adj.)"));
d.Add (new Card ("праздник", "fête"));
d.Add (new Card ("праздничный", "de fête"));
d.Add (new Card ("предложение", "proposition"));
d.Add (new Card ("прекрасный", "beau"));
d.Add (new Card ("преподаватель", "professeur (homme)"));
d.Add (new Card ("преподавательница", "professeur (femme)"));
d.Add (new Card ("пресса", "presse"));
d.Add (new Card ("приятно (adv.)", "agréablement"));
d.Add (new Card ("приглашать", "inviter"));
d.Add (new Card ("принимать", "recevoir"));
d.Add (new Card ("прихожая (adj. subst.)", "entrée de l'appartement"));
d.Add (new Card ("причёсывать", "peigner, coiffer quelqu'un"));
d.Add (new Card ("причёсываться", "se peigner"));
d.Add (new Card ("приятель", "ami, copain"));
d.Add (new Card ("приятельница", "amie, copine"));
d.Add (new Card ("программа", "programme"));
d.Add (new Card ("прогулка", "promenade"));
d.Add (new Card ("продавец", "vendeur"));
d.Add (new Card ("Пролив Ла-Манш", "Passage de la manche"));
d.Add (new Card ("проспекть", "avenue, perspective"));
d.Add (new Card ("профессор", "professeur"));
d.Add (new Card ("профессор (plur. профессора)", "professeur"));
d.Add (new Card ("прошлый", "passé (adj.), dernier"));
d.Add (new Card ("прямо (adv.)", "tout droit"));
d.Add (new Card ("Пуатье", "Poitiers"));
d.Add (new Card ("пуля", "balle (projectile)"));
d.Add (new Card ("путь", "chemin, voie"));
d.Add (new Card ("пытка", "torture"));
d.Add (new Card ("Пьер", "Pierre"));
d.Add (new Card ("пятнадцать", "quinze"));
d.Add (new Card ("пятница", "vendredi"));
d.Add (new Card ("пять (f.)", "cinq"));
d.Add (new Card ("работа", "travail"));
d.Add (new Card ("работать", "travailler"));
d.Add (new Card ("рабочий", "de travail"));
d.Add (new Card ("рабочий день", "jour de travail"));
d.Add (new Card ("радио", "radio"));
d.Add (new Card ("раз", "fois"));
d.Add (new Card ("раздевать", "déshabiller quelqu'un"));
d.Add (new Card ("раздеваться", "se déshabiller"));
d.Add (new Card ("рано", "tôt"));
d.Add (new Card ("рассказ", "récit"));
d.Add (new Card ("ребён(о)к, дети (pl.)", "enfant, enfants"));
d.Add (new Card ("революция", "révolution"));
d.Add (new Card ("редко", "rarement"));
d.Add (new Card ("река", "rivière"));
d.Add (new Card ("Ренн", "Rennes"));
d.Add (new Card ("ресторан", "restaurant"));
d.Add (new Card ("рисовать", "dessiner"));
d.Add (new Card ("родитель, родители (pl.)", "parent"));
d.Add (new Card ("розовый (adj.)", "rose (adj.)"));
d.Add (new Card ("роман", "roman"));
d.Add (new Card ("Рона", "Le Rhône (fleuve)"));
d.Add (new Card ("рояль", "piano à queue"));
d.Add (new Card ("Руан", "Rouen"));
d.Add (new Card ("рубль (m.)", "Rouble"));
d.Add (new Card ("рука", "bras, main"));
d.Add (new Card ("рукав (plur. рукава)", "manche"));
d.Add (new Card ("русская", "(une) russe"));
d.Add (new Card ("русский", "(un) russe"));
d.Add (new Card ("ручка", "stylo"));
d.Add (new Card ("рынок", "marché"));
d.Add (new Card ("рядом", "à côté"));
d.Add (new Card ("с + instr.", "avec"));
d.Add (new Card ("сад", "jardin"));
d.Add (new Card ("салат", "salade"));
d.Add (new Card ("сапог", "botte"));
d.Add (new Card ("свёкор", "beau-père (pour m.)"));
d.Add (new Card ("свекровь", "belle-mère (pour f.)"));
d.Add (new Card ("светлый", "clair"));
d.Add (new Card ("свободен", "libre"));
d.Add (new Card ("свой", "son "));
d.Add (new Card ("север", "nord"));
d.Add (new Card ("севодня (adv.)", "aujourd'hui"));
d.Add (new Card ("сейчас (adv.)", "maintenant"));
d.Add (new Card ("секретарша", "secrétaire"));
d.Add (new Card ("семинар", "séminaire"));
d.Add (new Card ("семнадцать", "dix-sept"));
d.Add (new Card ("семь (f.)", "sept"));
d.Add (new Card ("семья", "famille"));
d.Add (new Card ("семя", "graine"));
d.Add (new Card ("Сена", "La Seine (fleuve)"));
d.Add (new Card ("сентябрь", "septembre"));
d.Add (new Card ("сестра", "soeur"));
d.Add (new Card ("сигарета", "cigarette"));
d.Add (new Card ("сидеть", "être assis"));
d.Add (new Card ("симпатичный", "sympathique"));
d.Add (new Card ("синий", "bleu"));
d.Add (new Card ("скамейка", "banc"));
d.Add (new Card ("сквер", "square"));
d.Add (new Card ("сколько", "combien"));
d.Add (new Card ("скорый (adj.)", "rapide, prompt"));
d.Add (new Card ("скульптор", "sculpteur"));
d.Add (new Card ("скучно", "c'est ennuyeux"));
d.Add (new Card ("скучный", "ennuyeux"));
d.Add (new Card ("слева (adv.)", "à gauche"));
d.Add (new Card ("слишком", "trop"));
d.Add (new Card ("словарь (m.)", "dictionnaire"));
d.Add (new Card ("слово", "mot, parole"));
d.Add (new Card ("слушать", "écouter"));
d.Add (new Card ("слышать", "entendre"));
d.Add (new Card ("смотреть", "regarder"));
d.Add (new Card ("сначала", "au début, d'abord"));
d.Add (new Card ("снег (plur. снега)", "neige"));
d.Add (new Card ("собака", "chien"));
d.Add (new Card ("собираться", "se réunir"));
d.Add (new Card ("собор", "cathédrale"));
d.Add (new Card ("собрание", "réunion"));
d.Add (new Card ("современный", "moderne, contemporain"));
d.Add (new Card ("сожаление", "regret"));
d.Add (new Card ("сок", "jus de fruit"));
d.Add (new Card ("сорт (plur. сорта)", "sorte"));
d.Add (new Card ("сосед (plur. Соседи)", "voisin"));
d.Add (new Card ("соседка", "voisine"));
d.Add (new Card ("соседний", "voisin (adj.)"));
d.Add (new Card ("спальня", "chambre à coucher"));
d.Add (new Card ("спасибо", "merci"));
d.Add (new Card ("спать", "dormir"));
d.Add (new Card ("спектакль (m.)", "spectacle"));
d.Add (new Card ("спина", "dos"));
d.Add (new Card ("справа (adv.)", "à droite"));
d.Add (new Card ("спрашивать", "demander"));
d.Add (new Card ("среда", "mercredi"));
d.Add (new Card ("Средиземное море", "Mer méditerranée"));
d.Add (new Card ("средний (adj.)", "puîné"));
d.Add (new Card ("ставить отметку", "mettre une note"));
d.Add (new Card ("стажировка", "stage"));
d.Add (new Card ("стакан", "verre"));
d.Add (new Card ("сталь", "acier"));
d.Add (new Card ("станция", "station de métro"));
d.Add (new Card ("старинный (adj.)", "ancien"));
d.Add (new Card ("старший (adj.)", "aîné"));
d.Add (new Card ("старый (adj.)", "vieux"));
d.Add (new Card ("статья", "article (de journal)"));
d.Add (new Card ("стена", "mur"));
d.Add (new Card ("стоить", "coûter"));
d.Add (new Card ("стол", "table"));
d.Add (new Card ("столик", "petite table"));
d.Add (new Card ("столица", "capitale"));
d.Add (new Card ("столовая (adj. subst.)", "salle à manger"));
d.Add (new Card ("стоять", "être debout"));
d.Add (new Card ("страна", "pays"));
d.Add (new Card ("строгий", "sévère, strict"));
d.Add (new Card ("стройтель", "ouvrier du bâtiment"));
d.Add (new Card ("студент", "étudiant"));
d.Add (new Card ("студентка", "étudiante"));
d.Add (new Card ("студенческий", "d'étudiant(s)"));
d.Add (new Card ("стул (plur. стулья)", "chaise"));
d.Add (new Card ("суббота", "samedi"));
d.Add (new Card ("сумка", "sac"));
d.Add (new Card ("суп", "soupe"));
d.Add (new Card ("сутки", "24 heures"));
d.Add (new Card ("съезд", "congrès"));
d.Add (new Card ("сын (plur. Синовья)", "fils"));
d.Add (new Card ("таз", "bassin"));
d.Add (new Card ("так", "si (+ adj)"));
d.Add (new Card ("такой", "tel"));
d.Add (new Card ("такси (n., inv.)", "taxi"));
d.Add (new Card ("таксист", "chauffeur de taxi"));
d.Add (new Card ("там", "là-bas"));
d.Add (new Card ("танцевать", "danser"));
d.Add (new Card ("твой, -я, -ё, -и", "ton"));
d.Add (new Card ("театр", "théâtre"));
d.Add (new Card ("текст", "texte"));
d.Add (new Card ("телевизор", "poste de télévision"));
d.Add (new Card ("телеграмма", "télégramme"));
d.Add (new Card ("телефон", "téléphone"));
d.Add (new Card ("тёмный (adj.)", "sombre"));
d.Add (new Card ("теперь", "mainteant"));
d.Add (new Card ("тепло", "bon temps (adv)"));
d.Add (new Card ("тёплый (adj.)", "tiède"));
d.Add (new Card ("тесть", "beau-père (pour f.)"));
d.Add (new Card ("тетрадь (f.)", "cahier"));
d.Add (new Card ("тётя", "tante"));
d.Add (new Card ("тёща", "belle-mère (pour h.)"));
d.Add (new Card ("тихий (adj.)", "calme"));
d.Add (new Card ("тихо", "à voix basse, doucement"));
d.Add (new Card ("товарищ", "camarade"));
d.Add (new Card ("тогда", "alors"));
d.Add (new Card ("тоже", "aussi"));
d.Add (new Card ("том (plur. тома)", "tome"));
d.Add (new Card ("трамвай", "tramway"));
d.Add (new Card ("третий", "troisième"));
d.Add (new Card ("три", "trois"));
d.Add (new Card ("тринадцать", "treize"));
d.Add (new Card ("тротуар", "trottoir"));
d.Add (new Card ("трудный", "difficile"));
d.Add (new Card ("туалет", "toilette"));
d.Add (new Card ("Тулуза", "Toulouse"));
d.Add (new Card ("тумбочка", "table de nuit"));
d.Add (new Card ("Тур", "Tours"));
d.Add (new Card ("турист", "touriste"));
d.Add (new Card ("тут ", "ici"));
d.Add (new Card ("ты", "tu, toi"));
d.Add (new Card ("у + gen", "chez qqun, près de qqch"));
d.Add (new Card ("угол", "coin, angle"));
d.Add (new Card ("удоволствие", "plaisir, satisfaction"));
d.Add (new Card ("уже (adv.)", "déjà"));
d.Add (new Card ("ужинать", "souper"));
d.Add (new Card ("узкий ", "étroit"));
d.Add (new Card ("улица", "rue"));
d.Add (new Card ("уметь", "pouvoir"));
d.Add (new Card ("умывать", "laver (la figure)"));
d.Add (new Card ("умываться", "se laver (la figure et les mains)"));
d.Add (new Card ("университет", "université"));
d.Add (new Card ("упражнение", "exercice"));
d.Add (new Card ("урок", "leçon"));
d.Add (new Card ("утро", "matin"));
d.Add (new Card ("утром", "le matin (adv.)"));
d.Add (new Card ("учёба", "études"));
d.Add (new Card ("учебник", "manuel scolaire"));
d.Add (new Card ("ученик", "élève"));
d.Add (new Card ("учитель", "instituteur"));
d.Add (new Card ("учитель (plur. учителя)", "professeur"));
d.Add (new Card ("учительница", "institutrice"));
d.Add (new Card ("учить", "apprendre"));
d.Add (new Card ("учить", "enseigner, apprendre"));
d.Add (new Card ("учиться", "apprendre, étudier"));
d.Add (new Card ("уютный", "confortable"));
d.Add (new Card ("фабрика", "fabrique"));
d.Add (new Card ("факультет", "faculté"));
d.Add (new Card ("фамилия", "nom de famille"));
d.Add (new Card ("февраль", "février"));
d.Add (new Card ("физика", "(la) physique"));
d.Add (new Card ("филмь", "film"));
d.Add (new Card ("фирма", "firme"));
d.Add (new Card ("фотография", "photographie"));
d.Add (new Card ("француженка", "(une) française"));
d.Add (new Card ("француз", "français"));
d.Add (new Card ("французский", "français (adj.)"));
d.Add (new Card ("футбол", "football"));
d.Add (new Card ("химия", "chimie"));
d.Add (new Card ("холодный (adj.)", "froid (adj.)"));
d.Add (new Card ("хор", "chorale"));
d.Add (new Card ("хороший", "bon (adj)"));
d.Add (new Card ("художник", "peintre"));
d.Add (new Card ("цветок (plur. цветы)", "fleur"));
d.Add (new Card ("целовать", "embrasser, donner un baiser"));
d.Add (new Card ("целый", "entier"));
d.Add (new Card ("церк(о)вь (f.)", "église"));
d.Add (new Card ("час", "heure"));
d.Add (new Card ("чей, чья, чьё, чьи", "à qui, de qui?"));
d.Add (new Card ("чердак", "grenier"));
d.Add (new Card ("чёрный", "noir"));
d.Add (new Card ("четверг", "jeudi"));
d.Add (new Card ("четыре", "quatre"));
d.Add (new Card ("четырнадцать", "quatorze"));
d.Add (new Card ("читать", "lire"));
d.Add (new Card ("что", "quoi"));
d.Add (new Card ("Шалон-ан-Шампань", "Châlon-en-Champagne"));
d.Add (new Card ("швейцар(е)ц", "(un) suisse"));
d.Add (new Card ("швейцарка", "(une) suisse"));
d.Add (new Card ("шестнадцать", "seize"));
d.Add (new Card ("шесть", "six"));
d.Add (new Card ("шея", "cou"));
d.Add (new Card ("широкий", "large"));
d.Add (new Card ("шишка", "bosse"));
d.Add (new Card ("шкаф", "armoire, placard"));
d.Add (new Card ("школа", "école"));
d.Add (new Card ("школьник", "écolier"));
d.Add (new Card ("шляпа", "chapeau"));
d.Add (new Card ("штат", "État (division administrative)"));
d.Add (new Card ("шумный (adj.)", "bruyant"));
d.Add (new Card ("шутить", "plaisanter"));
d.Add (new Card ("экзамен", "examen"));
d.Add (new Card ("экономика", "(l') économie"));
d.Add (new Card ("эстрада", "spectacle de variété"));
d.Add (new Card ("этаж", "étage"));
d.Add (new Card ("это", "c'est"));
d.Add (new Card ("этот", "celui-ci"));
d.Add (new Card ("юг", "sud"));
d.Add (new Card ("юноша", "jeune homme"));
d.Add (new Card ("я", "je"));
d.Add (new Card ("ягодица", "fesse"));
d.Add (new Card ("язык", "langue (langage)"));
d.Add (new Card ("январь", "janvier"));
d.Add (new Card ("ясный", "clair, évident"));


            return d;
        }

        internal static object CreateTestDeck(SQLiteConnection db)
        {
            // Create the test deck
            var deck = new Deck() { Name = "Test deck" };
            db.Insert(deck);
            
            // Create three subdecks
            var sdeck1 = new SubDeck() { Name = "Lesson 1", IsActive = true };
            var sdeck2 = new SubDeck() { Name = "Lesson 2", IsActive = true };
            var sdeck3 = new SubDeck() { Name = "Lesson 3", IsActive = false };
            db.InsertAll(new [] { sdeck1, sdeck2, sdeck3 });
            
            // Adds the subdecks to the test decks
            deck.SubDecks = new List<SubDeck>() { sdeck1, sdeck2, sdeck3 };
            db.UpdateWithChildren(deck);
            
            // Create cards
            var c1 = new Card("a", "a");
            var c2 = new Card("b", "b");
            var c3 = new Card("c", "c");
            db.InsertAll(new [] { c1, c2, c3 });

            // Adds the cards to the subdecks
            sdeck1.Cards = new List<Card>() { c1 };
            sdeck2.Cards = new List<Card>() { c2 };
            sdeck3.Cards = new List<Card>() { c3 };
            db.UpdateWithChildren(sdeck1);
            db.UpdateWithChildren(sdeck2);
            db.UpdateWithChildren(sdeck3);

            return null;
            
        }
    }
}
