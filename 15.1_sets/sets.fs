// 42.3
let rec allSubsets n k =
  let rec iter n_list accum =
    if List.length n_list > 1
    then
      let settish_filtered = (List.map (fun x -> List.filter (fun y -> y <> x) n_list) n_list)
      List.map (fun a -> iter a (n_list::accum)) settish_filtered |> Seq.concat |> List.ofSeq
    else
      (n_list::accum)

  let sublists_set = Set.ofList (iter [1..n] [])
  let subsets_set = Set.map Set.ofList sublists_set
  let k_len_filtered = Set.filter (fun x -> Set.count x = k) subsets_set
  k_len_filtered
