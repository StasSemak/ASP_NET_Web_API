using Data.Models;

namespace Data.Data
{
    public static class MockData
    {
        public static List<Phone> GetPhones()
        {
            return new List<Phone>()
            {
                new Phone()
                {
                    Id = 1,
                    Model = "SAMSUNG Galaxy S20",
                    Screen = "6.5 inches",
                    RAM = 8,
                    Storage = 256,
                    Camera = "12MP triple main, 32 MP front",
                    Price = 769.99M,
                    Battery = 4500,
                    ImagePath = "https://fdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s20-fe-5g-1.jpg",
                    OperationSystemId = 1
                },
                new Phone()
                {
                    Id = 2,
                    Model = "Apple iPhone 13",
                    Screen = "6.1 inches",
                    RAM = 4,
                    Storage = 256,
                    Camera = "12MP dual main, 12 MP front",
                    Price = 829.99M,
                    Battery = 3240,
                    ImagePath = "https://fdn2.gsmarena.com/vv/pics/apple/apple-iphone-13-01.jpg",
                    OperationSystemId = 8
                },
                new Phone()
                {
                    Id = 3,
                    Model = "Google Pixel 6",
                    Screen = "6.4 inches",
                    RAM = 8,
                    Storage = 256,
                    Camera = "50MP dual main, 8 MP front",
                    Price = 599,
                    Battery = 4614,
                    ImagePath = "https://fdn2.gsmarena.com/vv/pics/google/google-pixel-6-1.jpg",
                    OperationSystemId = 3
                },
                new Phone()
                {
                    Id = 4,
                    Model = "Xiaomi Redmi 11",
                    Screen = "6.58 inches",
                    RAM = 6,
                    Storage = 128,
                    Camera = "50MP dual main, 8 MP front",
                    Price = 799.99M,
                    Battery = 5000,
                    ImagePath = "https://fdn2.gsmarena.com/vv/pics/xiaomi/xiaomi-redmi-10-5g-1.jpg",
                    OperationSystemId = 4
                }
            };
        }

        public static List<OperationSystem> GetOSs()
        {
            return new List<OperationSystem>()
            {
                new OperationSystem()
                {
                    Id = 1,
                    Name = "Android 10"
                },
                new OperationSystem()
                {
                    Id = 2,
                    Name = "Android 11"
                },
                new OperationSystem()
                {
                    Id = 3,
                    Name = "Android 12"
                },
                new OperationSystem()
                {
                    Id = 4,
                    Name = "Android 13"
                },
                new OperationSystem()
                {
                    Id = 5,
                    Name = "iOS 13"
                },
                new OperationSystem()
                {
                    Id = 6,
                    Name = "iOS 14"
                },
                new OperationSystem()
                {
                    Id = 7,
                    Name = "iOS 15"
                },
                new OperationSystem()
                {
                    Id = 8,
                    Name = "iOS 16"
                }
            };
        }
    }
}
