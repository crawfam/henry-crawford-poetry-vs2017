
function getLastLineWord(words) {
    var n = words.split(" ");
    return n[n.length - 1];
}


function getRhyme(word) {

    //var words = json_data.sort(function (a, b) { return parseInt(a.numSyllables) < parseInt(b.numSyllables); })
    // SEE: https://stackoverflow.com/questions/6536475/sorting-a-jquery-list-populated-from-a-json-array

    // "https://api.datamuse.com//words?rel_rhy=" + word

    var wordToFind = getLastLineWord(word);

    $.getJSON('https://api.datamuse.com//words?rel_rhy=' + removeEndPunctuation(wordToFind), function (json_data) {

        var words = json_data.sort(function (a, b) { return parseInt(a.numSyllables) > parseInt(b.numSyllables); })
        var list = $("#wordList");

        list.empty();

        $.each(words, function () {
            list.append("<li>" + this.word + "</li>");
        });
        
    });

}

function removeEndPunctuation(s)
{
    var newString = s.replace(".", "");
    newString = newString.replace(",", "");
    newString = newString.replace(";", "");
    newString = newString.replace("?", "");
    newString = newString.replace(":", "");
    newString = newString.replace("-", "");

    
    return newString;
}

function setLines(word, lineType) {


    // get last word in line for hints
    // on other lines
    //var lastWord = getLastLineWord(word);
    
    if (lineType === "refrain1") {

        var lastWord = removeEndPunctuation(getLastLineWord(word.trim()));


        $("#Line6").val(word.trim());
        $("#Line12").val(word.trim());
        $("#Line18").val(word.trim());

        // lines that have to rhyme with refreain 1
        
        $("#Line4").val(lastWord);
        $("#Line7").val(lastWord);
        $("#Line10").val(lastWord);
        $("#Line13").val(lastWord);
        $("#Line16").val(lastWord);


    } else if (lineType === "refrain2") {

        $("#Line9").val(word.trim());
        $("#Line15").val(word.trim());
        $("#Line19").val(word.trim());

    } else if (lineType === "B_Rhymes") {

        // lines that have to rhyme with line 2

        var lastWord = removeEndPunctuation(getLastLineWord(word.trim()));

        $("#Line5").val(lastWord);
        $("#Line8").val(lastWord);
        $("#Line11").val(lastWord);
        $("#Line14").val(lastWord);
        $("#Line17").val(lastWord);
    }

}