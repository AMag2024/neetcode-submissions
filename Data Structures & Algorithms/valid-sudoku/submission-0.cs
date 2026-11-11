public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new List<HashSet<char>>(9);
        var cols = new List<HashSet<char>>(9);
        var boxs = new List<HashSet<char>>(9);

        for(int i = 0; i<9; i++)
        {
            rows.Add(new HashSet<char>());
            cols.Add(new HashSet<char>());
            boxs.Add(new HashSet<char>());
        }

        for(int row = 0; row < 9; row++)
        {
            for(int col = 0; col < 9; col++)
            {
                char current = board[row][col];
                if(current == '.') continue;
                if(rows[row].Add(current) && cols[col].Add(current) && boxs[(row/3) * 3 + col / 3].Add(current))
                {
                }else {return false;}
            }
        }
    
    return true;

    }
}
