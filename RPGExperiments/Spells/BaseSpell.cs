using System.Collections.Generic;

namespace RPGExperiments.Spells
{
    public enum Element { None, Earth, Air, Fire, Water, Lightning, Ice, Nature, Light, Dark }
    public enum Target { SingleEnemy, EitherEnemy, AllEnemy, SingleAlly, EitherAlly, AllAlly, None }

    public class BaseSpell
    {
        protected string name;
        public string Name { get => name; }

        protected Target target;
        public Target Target { get => target; }

        protected bool black;
        public bool Black { get => black; }

        protected bool blue;
        public bool Blue { get => blue; }

        protected ushort cost;
        public ushort Cost { get => cost; }

        public BaseSpell(string name_, Target target_, bool black_, ushort cost_)
        {
            name = name_;
            target = target_;
            black = black_;
            cost = cost_;
        }
    }
}
