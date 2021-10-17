using System;
using System.Linq;
using AsmResolver.DotNet;

namespace NetRenamer
{
    internal class Rename
    {
        private static readonly Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string nums = "0123456789";
            const string foreign =
                "䂥䂀䂁䂀䂀䁿䁾䁽䂌䂋䂎䃞䃝䃜䃛䃫䃬䃮䃰䃱䃲䃳䃴䃵䃶䃷䃸䃹䃺䃪䃩䃙䄣䄢䄡䄠䄟䒐䒏䒎䒍䒌䒋䑬䑽䑼䑾䒀䒂䑳䄞䄝䄜䄛䄋䃻䃫䃬䃭䃮䃯䃰䃱䃲䃳䃴䃵䃶䃷䃸䃹䃺䆴䇀䇁䆱䇟䇮䇯䇱䇝䇜䇍䉶䉱䉲䉢䉣䊃䊅䊖䊦䊥䊐䊞䊟䌵䌴䌳䍦䍥䍷䍷䍹";
            const string special =
                "ƀƁƂƄƅƆƈƉƋƍƎƏƐƑƒƓƔƕƖƗƘƙƜƛơƣƥƪƩƱƲƳƴǍǎǢǣǤǥǭȄȜȞȣȮփռպֆӸӂҿҧͲͳʹͶͷͻͼͽΆΙΘΗΖΕΔΓΒΑΐΏΎΌΉΈΛάέήίΰαβϡϠϝϞϜϛϦФЯЮПЎЍЌЫЬЭЮйЩШЙЉЊϪϚѤѬѭѮѰѹ҈҉ҘѾүҾӁ";

            return List.watermark
                ? List.WaterMark + new string(Enumerable.Repeat(foreign, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray())
                : new string(Enumerable.Repeat(foreign, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void rename(ModuleDefinition module)
        {
            foreach (var type in module.GetAllTypes())
            {
                foreach (var method in type.Methods)
                {
                    foreach (var obj in List.tcb.ElementAt(0).CheckedItems)
                    {
                        if (obj.ToString() == method.FullName)
                            method.Name = RandomString(22);
                    }
                }

                foreach (var field in type.Fields)
                {
                    foreach (var obj in List.tcb.ElementAt(1).CheckedItems)
                    {
                        if (obj.ToString() == field.FullName)
                            field.Name = RandomString(22);
                    }
                }

                foreach (var property in type.Fields)
                {
                    foreach (var obj in List.tcb.ElementAt(2).CheckedItems)
                    {
                        if (obj.ToString() == property.FullName)
                            property.Name = RandomString(22);
                    }
                }

                foreach (var eventt in type.Events)
                {
                    foreach (var obj in List.tcb.ElementAt(3).CheckedItems)
                    {
                        if (obj.ToString() == eventt.FullName)
                            eventt.Name = RandomString(22);
                    }
                }

                if (type.IsClass && List.renameClasses)
                    type.Name = RandomString(22);
            }
        }
    }
}