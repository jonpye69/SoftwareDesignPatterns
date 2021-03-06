﻿using System.Collections.Generic;

namespace DesignPatterns.PrototypePattern
{
    public class ShapePrototypeCache
    {
        private static Dictionary<int, ShapePrototype> shapeMap = new Dictionary<int, ShapePrototype>();

        public SquarePrototype SquarePrototype
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public RectanglePrototype RectanglePrototype
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public CirclePrototype CirclePrototype
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public static ShapePrototype GetShape(int shapeId)
        {
            if (shapeMap.ContainsKey(shapeId))
            {
                var cachedShape = shapeMap[shapeId];

                return (ShapePrototype)cachedShape.Clone();
            }

            return null;
        }

        // for each shape run database query and create shape
        // shapeMap.put(shapeKey, shape);
        // for example, we are adding three shapes

        public static void LoadCache()
        {
            var circle = new CirclePrototype();
            circle.SetId(1);
            shapeMap.Add(circle.GetId(), circle);

            var square = new SquarePrototype();
            square.SetId(2);
            shapeMap.Add(square.GetId(), square);

            var rectangle = new RectanglePrototype();
            rectangle.SetId(3);
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}
