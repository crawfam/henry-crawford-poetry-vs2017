
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


//////////////////////////////////////////// PANTOUM FUNCTIONS ////////////////////////////////////////////
function setPantoumLine(str, num)
{            

    switch (num)
    {
        case 1:
            $("#PLine1").val(str);
            $("#PLine20").val(str);
            break;
        case 2:
            $("#PLine2").val(str);
            $("#PLine5").val(str);
            break;
        case 3:
            $("#PLine3").val(str);
            $("#PLine18").val(str);
            break;
        case 4:
            $("#PLine4").val(str);
            $("#PLine7").val(str);
            break;
        case 5:
            $("#PLine6").val(str);
            $("#PLine9").val(str);
            break;
        case 6:
            $("#PLine8").val(str);
            $("#PLine11").val(str);
            break;
        case 7:
            $("#PLine10").val(str);
            $("#PLine13").val(str);
            break;
        case 8:
            $("#PLine12").val(str);
            $("#PLine15").val(str);
            break;
        case 9:
            $("#PLine14").val(str);
            $("#PLine17").val(str);
            break;
        case 10:
            $("#PLine16").val(str);
            $("#PLine19").val(str);
            break;
    }

}

function clearPantoumLine(num) {

    switch (num)
    {
        case 1:
            $("#Line1").val("");
            $("#PLine1").val("");
            $("#PLine20").val("");
            break;
        case 2:
            $("#Line2").val("");
            $("#PLine2").val("");
            $("#PLine5").val("");
            break;
        case 3:
            $("#Line3").val("");
            $("#PLine3").val("");
            $("#PLine18").val("");
            break;
        case 4:
            $("#Line4").val("");
            $("#PLine4").val("");
            $("#PLine7").val("");
            break;
        case 5:
            $("#Line5").val("");
            $("#PLine6").val("");
            $("#PLine9").val("");
            break;
        case 6:
            $("#Line6").val("");
            $("#PLine8").val("");
            $("#PLine11").val("");
            break;
        case 7:
            $("#Line7").val("");
            $("#PLine10").val("");
            $("#PLine13").val("");
            break;
        case 8:
            $("#Line8").val("");
            $("#PLine12").val("");
            $("#PLine15").val("");
            break;
        case 9:
            $("#Line9").val("");
            $("#PLine14").val("");
            $("#PLine17").val("");
            break;
        case 10:
            $("#Line10").val("");
            $("#PLine16").val("");
            $("#PLine19").val("");
            break;
    }
}

function clearAll()
{
    $("#Line1").val("");
    $("#PLine1").val("");
    $("#PLine20").val("");
    $("#Line2").val("");
    $("#PLine2").val("");
    $("#PLine5").val("");
    $("#Line3").val("");
    $("#PLine3").val("");
    $("#PLine18").val("");
    $("#Line4").val("");
    $("#PLine4").val("");
    $("#PLine7").val("");
    $("#Line5").val("");
    $("#PLine6").val("");
    $("#PLine9").val("");
    $("#Line6").val("");
    $("#PLine8").val("");
    $("#PLine11").val("");
    $("#Line7").val("");
    $("#PLine10").val("");
    $("#PLine13").val("");
    $("#Line8").val("");
    $("#PLine12").val("");
    $("#PLine15").val("");
    $("#Line9").val("");
    $("#PLine14").val("");
    $("#PLine17").val("");
    $("#Line10").val("");
    $("#PLine16").val("");
    $("#PLine19").val("");
}


 