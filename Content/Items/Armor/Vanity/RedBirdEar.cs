using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;

namespace CheemsVanityItems.Content.Items.Armor.Vanity
{
	// This tells tModLoader to look for a texture called MinionBossMask_Head, which is the texture on the player
	// and then registers this item to be accepted in head equip slots
	[AutoloadEquip(EquipType.Head)]
	public class RedBirdEar : ModItem
	{
		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 20;

			// Common values for every boss mask
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(copper: 50, silver: 1);
			Item.vanity = true;
			Item.maxStack = 1;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Feather, 15);
			recipe.AddIngredient(ItemID.Bacon, 1);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
	}
}