using UnityEngine;
using UnityEngine.UI;

public class GreatTree : MonoBehaviour
{
    public SpriteRenderer TreeSpriteRenderer;
    public Sprite TreeLv1;
    public Sprite TreeLv2;
    public Sprite TreeLv3;

    public TreeHealthBar TreeHealthBar;

    public Text text_TreeHealth;
    public Text text_TreeLevel;

    public int TreeLevel = 0;

    void Start()
    {
        TreeLevel = 1;
    }

    void Update()
    {
        text_TreeHealth.text = ""+TreeHealthBar.currentTreeHealth;
        text_TreeLevel.text = "Tree Level: " + CheckTreeLevel();
    }

    public void UpdateHealthOnAttack(int damage)
    {
        TreeHealthBar.currentTreeHealth -= damage;
    }

    public void TreeLevelUp()
    {
        TreeLevel++;
        if (TreeLevel == 0)
            TreeSpriteRenderer.sprite = TreeLv1;
        else if (TreeLevel == 1)
        {
            TreeSpriteRenderer.sprite = TreeLv1;
            TreeHealthBar.SetMaxTreeHealth(GameParameters.TreeLvl1MaxHealth);
        }
        else if (TreeLevel == 2)
        {
            TreeSpriteRenderer.sprite = TreeLv2;
            TreeHealthBar.SetMaxTreeHealth(GameParameters.TreeLvl2MaxHealth);
        }
        else if (TreeLevel == 3)
        {
            TreeSpriteRenderer.sprite = TreeLv3;
            TreeHealthBar.SetMaxTreeHealth(GameParameters.TreeLvl3MaxHealth);
        }

        TreeHealthBar.FillToMax();
    }

    public int CheckTreeLevel()
    {
        return TreeLevel;
    }
}
