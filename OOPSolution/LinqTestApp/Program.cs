using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, 6, 7, 1, 5, 10, 4, 2 };
            arr.Sort();

            var profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "톰크루즈", Height = 170 });
            profiles.Add(new Profile() { Name = "주지훈", Height = 192 });
            var profiles1 = from item in profiles
                            orderby item.Height descending
                            select new { Name = item.Name, Inch = item.Height * 0.393 };  //방법1

            var profiles2 = profiles.Where(p => p.Height < 172)
                .OrderByDescending(p => p.Height)
                .Select(item => new
                {
                    Name = item.Name,
                    Inch = item.Height * 0.393
                }); //방법2
            Console.WriteLine("전체 프로필 리스트(키 내림차순)");
            foreach(var item in profiles1)
            {
                Console.WriteLine($"{item.Name} : {item.Inch} inch.");
            }

            /*List<Profile> newProfiles = new List<Profile>();
            foreach (var item in profiles)
            {
                if (item.Height <172)
                {
                    newProfiles.Add(item);
                }
            }*/
            //여기서 키큰순으로 정렬 작업 --> 3~4줄 더 필요

            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending
                              select item;



            Console.WriteLine("171이하 프로필");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }

            //
            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = i + 1;
            }
            var result = from item in numbers
                         where item % 3 == 0
                         select item;
            foreach(var item in result)
            {
                Console.Write($"{item} \t");
            }

            //15.3
            Console.WriteLine();
            InstClass[] arrClass =
             {
                new InstClass(){Name = "연두반", Scores = new int[]{99,80,70,24}} ,
                new InstClass(){Name = "분홍반", Scores = new int[]{60,45,87,72}},
                new InstClass(){Name = "파랑반", Scores = new int[]{92,30,85,94} },
                new InstClass(){Name = "노랑반", Scores = new int[]{90,88,0,17 } },

            };

            var rstClass = from item in arrClass
                           from score in item.Scores
                           where score < 60
                           orderby score ascending
                           select new { Name = item.Name, Lowest = score };
            foreach (var item in rstClass)
            {
                Console.WriteLine($"{item.Name} : {item.Lowest}");
            }

            //group by
            var listProfiles = from item in profiles
                               group item by item.Height < 172 into g
                               select new { GroupKey = g.Key, Profiles = g };
            foreach (var item in listProfiles)
            {
                Console.WriteLine($".. 172미만 : {item.GroupKey}");
                foreach (var sub in item.Profiles)
                {
                    Console.WriteLine($">>>{sub.Name} : {sub.Height}");
                }
            }

        }
    }
}
