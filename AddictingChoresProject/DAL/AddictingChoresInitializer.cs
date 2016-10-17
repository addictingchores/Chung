using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AddictingChoresProject.Models;
using ValueType = AddictingChoresProject.Models.ValueType;

namespace AddictingChoresProject.DAL
{
    public class AddictingChoresInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AddictingChoresContext>
    {
        protected override void Seed(AddictingChoresContext context)
        {
            var children = new List<Child>
            {
            new Child{ChildId = 0,LastName = "Puppers",FirstName = "Rydo",BronzeBalance = 0,SilverBalance = 0,GoldBalance = 10,DateOfBirth =DateTime.Parse("2005-09-23")},
            new Child{ChildId = 1,LastName = "Kozmina",FirstName = "Viktoriya",BronzeBalance = 0,SilverBalance = 10,GoldBalance = 0,DateOfBirth =DateTime.Parse("2006-09-23")},
            new Child{ChildId = 2,LastName = "Schommer",FirstName = "Francis",BronzeBalance = 10,SilverBalance = 0,GoldBalance = 0,DateOfBirth =DateTime.Parse("2007-09-23")},
            new Child{ChildId = 3,LastName = "Guthrie",FirstName = "Gabrielle",BronzeBalance = 8,SilverBalance = 5,GoldBalance = 2,DateOfBirth =DateTime.Parse("2008-09-23")},
                };

            children.ForEach(s => context.Children.Add(s));
            context.SaveChanges();

            var chores = new List<Chore>
            {
            new Chore {ChoreId = 0,ChoreTitle = "Mow the lawn",Description= "Mow the front and the back, make sure to get the sides as well.",StartDate = DateTime.Parse("10/14/2016"),DeadlineDate =DateTime.Parse("2005-10-29"),Value=2,ValueType= ValueType.Gold,Assignment = null},
            new Chore {ChoreId = 1,ChoreTitle = "Edging the yard",Description= "Edge the entire front and back yard, as well as sidewalks. Must sweep afterwards.",StartDate = DateTime.Parse("10/14/2016"),DeadlineDate =DateTime.Parse("2005-10-29"),Value=1,ValueType= ValueType.Gold,Assignment = null},
            new Chore {ChoreId = 2,ChoreTitle = "Wash Dishes",Description= "Wash the dishes, including pots, pans, and dishes scattered around house.",StartDate = DateTime.Parse("10/14/2016"),DeadlineDate =DateTime.Parse("2005-10-29"),Value=10,ValueType= ValueType.Silver,Assignment = null},
            new Chore {ChoreId = 3,ChoreTitle = "Walk Dog",Description= "Walk the dog around the block, minimum of 15 minutes. Messes must be picked up and thrown away.",StartDate = DateTime.Parse("10/14/2016"),DeadlineDate =DateTime.Parse("2005-10-29"),Value=75,ValueType= ValueType.Bronze,Assignment = null},
            };
            chores.ForEach(s => context.Chores.Add(s));
            context.SaveChanges();

            var rewards = new List<Reward>
            {
            new Reward {RewardId = 0,Cost = 15,CostType = ValueType.Bronze,RewardTitle = "1 Hr of video games",Description = "One hour of video games on XBOX or PS4",CreateTime = DateTime.Now},
            new Reward {RewardId = 1,Cost = 1,CostType = ValueType.Silver,RewardTitle = "1 Hr of computer time",Description = "One hour allowed on computer for playing games or watching movies",CreateTime = DateTime.Now},
            new Reward {RewardId = 2,Cost = 15,CostType = ValueType.Bronze,RewardTitle = "1 Hr Netflix",Description = "One hour of watching netflix on TV",CreateTime = DateTime.Now},
            new Reward {RewardId = 3,Cost = 1,CostType = ValueType.Gold,RewardTitle = "Dinner Outing Choice",Description = "Pick where the family goes out to dinner. You can pick anything off menu up to $20.",CreateTime = DateTime.Now},
            };
            rewards.ForEach(s => context.Rewards.Add(s));
            context.SaveChanges();

        }
    }
}